using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Drawing;

namespace LeaderWithRealSense
{
    public partial class Form1 : Form
    {
        Thread read;
        Socket socket;
        byte[] buffer;
        bool connectFlag = false;

        bool moveJ = false;
        bool moveL = false;
        bool playRoute= false;
        bool fristFlag = true;
        byte[] data;
        string cmd = "";

        public RoutePoint PointHead = new RoutePoint();
        public RoutePoint PointCurrent = null;
        public RoutePoint routePoint = null;
        double Xmax = -9999999;
        double Xmin = 9999999;
        double Ymax = -9999999;
        double Ymin = 9999999;
        double Zmax = -9999999;
        double Zmin = 9999999;
        bool isPicBoxClick = true;
        int tmp = 0;

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!connectFlag)
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    socket.Connect("192.168.0.75", 5000);

                    connectFlag = true;
                    read = new Thread(readData);
                    read.IsBackground = true;
                    read.Start();
                    btn_connect.Text = "中斷連線";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("連線失敗" + ex.Message);
                    btn_connect.Text = "連線";
                }
            }
            else
            {
                btn_connect.Text = "連線";
                connectFlag = false;
                read.Abort();
                read = null;
            }
        }
        private void readData()
        {
            buffer = new byte[2048];
            RoutePoint pointScan = null;
            while (connectFlag)
            {

                if (moveJ)
                {
                    //cmd = "moveJ([0,0,0,0,0,0],v = 10,delayStatus = 0,delayTime = 0,RO_Status = 00000000000000000000000000000000)";
                    cmd = "moveJ([" + tBx_J1.Text + "," + tBx_J2.Text + "," + tBx_J3.Text + ","
                                    + tBx_J4.Text + "," + tBx_J5.Text + "," + tBx_J6.Text + "],v = "
                                    + tBx_speed.Text + ",delayStatus = 0,delayTime = 0,RO_Status = 00000000000000000000000000000000)";
                    moveJ = false;
                }
                else if (moveL)
                {
                    //cmd = "moveL([0,0,0,0,0,0],v = 10,delayStatus = 0,delayTime = 0,RO_Status = 00000000000000000000000000000000)";
                    cmd = "moveL([" + tBx_X.Text + "," + tBx_Y.Text + "," + tBx_Z.Text + ","
                                    + tBx_RX.Text + "," + tBx_RY.Text + "," + tBx_RZ.Text + "],v = "
                                    + tBx_speed.Text + ",delayStatus = 0,delayTime = 0,RO_Status = 00000000000000000000000000000000)";
                    moveL = false;
                }
                else if (playRoute)
                {
                    
                    if (fristFlag)
                    {
                        routePoint = PointHead.Next;
                        fristFlag = false;
                    }
                    tmp++;


                    if (routePoint != null)
                    {
                        if (tmp % 2 == 1)
                        {
                            cmd = "moveL([" + routePoint.X.ToString() + "," + routePoint.Y.ToString() + "," + routePoint.Z.ToString() + ","
                                            + routePoint.RX.ToString() + "," + routePoint.RY.ToString() + "," + routePoint.RZ.ToString() + "],v = 50"
                                            + ",delayStatus = 0,delayTime = 0,RO_Status = 00000000000000000000000000000000)";
                            routePoint = routePoint.Next;
                        }
                        else if(tmp % 2 == 0)
                        {
                            cmd = "moveL([" + routePoint.Prev.X.ToString() + "," + routePoint.Prev.Y.ToString() + "," + (routePoint.Prev.Z + Math.Abs(routePoint.Prev.Z - routePoint.Z) + 20).ToString() + ","
                                            + routePoint.Prev.RX.ToString() + "," + routePoint.Prev.RY.ToString() + "," + routePoint.Prev.RZ.ToString() + "],v = 50"
                                            + ",delayStatus = 0,delayTime = 0,RO_Status = 00000000000000000000000000000000)";
                        }
                    }
                    else
                    {
                        playRoute = false;
                        fristFlag = true;
                    }
                    
                }
                else if (!(moveJ && moveL))
                    cmd = "Got Info()";

                data = Encoding.UTF8.GetBytes(cmd);
                socket.Send(data);

                int length = socket.Receive(buffer);
                string msg = Encoding.ASCII.GetString(buffer, 0, length);
                RobotInfo(msg);

                Thread.Sleep(200);

            }

        }



        private void btn_move_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Equals(btn_moveJ))
            {
                moveJ = true;
                moveL = !moveJ;
                playRoute = !moveJ;
            }
            else if (button.Equals(btn_moveL))
            {
                moveL = true;
                moveJ = !moveL;
                playRoute = !moveL;
            }
            else if (button.Equals(btn_playRoute))
            {
                playRoute = true;
                moveL = !playRoute;
                moveJ = !playRoute;
            }

        }


        private void RobotInfo(string message)
        {
            if (message.Contains("Data_Got_moveL"))
                Console.WriteLine("Data_Got_moveL");
            else if (message.Contains("Data_Got_moveJ"))
                Console.WriteLine("Data_Got_moveJ");
            else
            {
                string[] msgTmp = message.Split(',');
                Invoke((Action)(() =>
                {
                    msgTmp[0] = msgTmp[0].Replace("[", "");
                    msgTmp[5] = msgTmp[5].Replace("]", "");
                    msgTmp[6] = msgTmp[6].Replace("[", "");
                    msgTmp[11] = msgTmp[11].Replace("]", "");
                    if (msgTmp[119].Substring(1, 1) == "1")
                    {
                        lbl_state.Text = "動作狀態: 手臂待機中";
                    }
                    else if (msgTmp[119].Substring(1, 1) == "0")
                    {
                        lbl_state.Text = "動作狀態: 手臂動作中";
                    }

                    lbl_Joint.Text = "關節位置 \t[J1: " + msgTmp[0] + "\tJ2: " + msgTmp[1] + "\tJ3: " + msgTmp[2] +
                                     "\tJ4: " + msgTmp[3] + "\tJ5: " + msgTmp[4] + "\tJ6: " + msgTmp[5] + "]";
                    lbl_XYZ.Text = "XYZ位置 \t[X: " + msgTmp[6] + "\tY: " + msgTmp[7] + "\tZ: " + msgTmp[8] +
                                   "\tRX: " + msgTmp[9] + "\tRY: " + msgTmp[10] + "\tRZ: " + msgTmp[11] + "]";
                    //Console.WriteLine(message);
                }));

            }
        }

        private void btn_fileLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "";
            openFileDialog1.Filter = "文字文件 (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                routeLoad(openFileDialog1.FileName);

                picBox_route.Refresh();

            }
        }

        private void routeLoad(string path)
        {

            string str;



            try
            {
                str = "";
                StreamReader sr = new StreamReader(path, Encoding.Default);
                str = sr.ReadLine();
                if (isPicBoxClick)
                {

                    RoutePoint pointScan = PointHead;
                    Xmax = -9999999;
                    Xmin = 9999999;
                    Ymax = -9999999;
                    Ymin = 9999999;
                    Zmax = -9999999;
                    Zmin = 9999999;
                    while (str != null)
                    {
                        string[] temparray = str.Split(',');
                        RoutePoint pointNew = new RoutePoint();
                        pointNew.ID = temparray[0];
                        pointNew.X = Convert.ToDouble(temparray[1]);
                        pointNew.Y = Convert.ToDouble(temparray[2]);
                        pointNew.Z = Convert.ToDouble(temparray[3]);
                        pointNew.RX = Convert.ToDouble(temparray[4]);
                        pointNew.RY = Convert.ToDouble(temparray[5]);
                        pointNew.RZ = Convert.ToDouble(temparray[6]);
                        //pointNew.shiftX = Convert.ToDouble(temparray[7]);
                        //pointNew.shiftY = Convert.ToDouble(temparray[8]);
                        //pointNew.shiftZ = Convert.ToDouble(temparray[9]);
                        //pointNew.shiftA = Convert.ToDouble(temparray[10]);
                        //pointNew.shiftB = Convert.ToDouble(temparray[11]);
                        //pointNew.shiftC = Convert.ToDouble(temparray[12]);

                        pointScan.Next = pointNew;
                        pointNew.Prev = pointScan;
                        pointNew.Next = null;
                        pointScan = pointNew;

                        if (pointNew.X > Xmax)
                        {
                            Xmax = pointNew.X;
                        }
                        if (pointNew.X < Xmin)
                        {
                            Xmin = pointNew.X;
                        }
                        if (-pointNew.Y > Ymax)
                        {
                            Ymax = -pointNew.Y;
                        }
                        if (-pointNew.Y < Ymin)
                        {
                            Ymin = -pointNew.Y;
                        }
                        if (-pointNew.Z > Zmax)
                        {
                            Zmax = -pointNew.Z;
                        }
                        if (-pointNew.Z < Zmin)
                        {
                            Zmin = -pointNew.Z;
                        }
                        str = sr.ReadLine();

                    }
                    picBox_route.Enabled = true;
                }
            }
            catch (Exception ex) { }
            System.GC.Collect();

        }

        private void btn_prevPoint_Click(object sender, EventArgs e)
        {
            if (isPicBoxClick)
            {
                if (PointCurrent.Prev == PointHead)
                {
                    MessageBox.Show("已到第一個點", "注意");
                }
                else if (PointCurrent != null)
                {
                    PointCurrent = PointCurrent.Prev;
                    lbl_pointID.Text = "路徑點編號: " + PointCurrent.ID;
                    textBox_UI_Updata();

                    picBox_route.Refresh();
                }
            }
        }

        private void btn_nextPoint_Click(object sender, EventArgs e)
        {
            if (isPicBoxClick)
            {
                if (PointCurrent.Next == null)
                {
                    MessageBox.Show("已到最後一個點", "注意");
                }
                else if (PointCurrent != null)
                {
                    PointCurrent = PointCurrent.Next;

                    textBox_UI_Updata();
                    lbl_pointID.Text = "路徑點編號: " + PointCurrent.ID;

                    picBox_route.Refresh();
                }
            }

        }

        private void textBox_UI_Updata()
        {
            if (isPicBoxClick)
            {
                tBxPointX.Text = PointCurrent.X.ToString("0.0000") + "";
                tBxPointY.Text = PointCurrent.Y.ToString("0.0000") + "";
                tBxPointZ.Text = PointCurrent.Z.ToString("0.0000") + "";
                tBxPointRX.Text = PointCurrent.RX.ToString("0.0000") + "";
                tBxPointRY.Text = PointCurrent.RY.ToString("0.0000") + "";
                tBxPointRZ.Text = PointCurrent.RZ.ToString("0.0000") + "";
                //tBx_totShiftX.Text = PointCurrent.shiftX.ToString("0.0000") + "";
                //tBx_totShiftY.Text = PointCurrent.shiftY.ToString("0.0000") + "";
                //tBx_totShiftZ.Text = PointCurrent.shiftZ.ToString("0.0000") + "";
                //tBx_totShiftA.Text = PointCurrent.shiftA.ToString("0.0000") + "";
                //tBx_totShiftB.Text = PointCurrent.shiftB.ToString("0.0000") + "";
                //tBx_totShiftC.Text = PointCurrent.shiftC.ToString("0.0000") + "";
            }
            //tBx_shiftX.Text = "0";
            //tBx_shiftY.Text = "0";
            //tBx_shiftZ.Text = "0";
            //tBx_shiftA.Text = "0";
            //tBx_shiftB.Text = "0";
            //tBx_shiftC.Text = "0";
        }

        private void picBox_route_Paint(object sender, PaintEventArgs e)
        {
            Graphics objGraphic = e.Graphics;
            Pen drawLine = new Pen(Color.Green, 1);
            Pen CurrentLine = new Pen(Color.DarkOrange, 1);
            SolidBrush drawPoint = new SolidBrush(Color.DodgerBlue);
            SolidBrush drawCurrent = new SolidBrush(Color.Red);


            for (RoutePoint pointScan = PointHead.Next; pointScan != null; pointScan = pointScan.Next)
            {
                Point pointNormal = Normalization(pointScan.X + pointScan.shiftX, -pointScan.Y - pointScan.shiftY);
                pointScan.NormalizationX = pointNormal.X;
                pointScan.NormalizationY = pointNormal.Y;
                pointScan.LinePointUpdata(pointScan.NormalizationX, pointScan.NormalizationY, pointScan.RX + pointScan.shiftA);
                objGraphic.FillEllipse(drawPoint, pointScan.NormalizationX - 5, pointScan.NormalizationY - 5, 10, 10);
                objGraphic.DrawLine(drawLine, pointScan.NormalizationX, pointScan.NormalizationY, pointScan.LinePoint.X, pointScan.LinePoint.Y);
                objGraphic.DrawString(pointScan.ID, new Font("標楷體", 12), Brushes.Green, pointScan.NormalizationX, pointScan.NormalizationY - 15);
            }
            if (PointCurrent != null)
            {

                objGraphic.FillEllipse(drawCurrent, PointCurrent.NormalizationX - 5, PointCurrent.NormalizationY - 5, 10, 10);
                objGraphic.DrawLine(CurrentLine, PointCurrent.NormalizationX, PointCurrent.NormalizationY, PointCurrent.LinePoint.X, PointCurrent.LinePoint.Y);
                objGraphic.DrawString(PointCurrent.ID, new Font("標楷體", 12), Brushes.Red, PointCurrent.NormalizationX, PointCurrent.NormalizationY - 15);
            }

        }


        private void picBox_route_MouseDown(object sender, MouseEventArgs e)
        {
            PointCurrent = null;
            float dis_min = 10;

            for (RoutePoint pointLoad = PointHead.Next; pointLoad != null; pointLoad = pointLoad.Next)
            {
                float distance = (float)Math.Sqrt((pointLoad.NormalizationX - e.X) * (pointLoad.NormalizationX - e.X) + (pointLoad.NormalizationY - e.Y) * (pointLoad.NormalizationY - e.Y));
                if (distance < dis_min)
                {
                    dis_min = distance;
                    PointCurrent = pointLoad;
                    break;
                }
            }
            
            if (PointCurrent != null)
            {
                lbl_pointID.Text = "路徑點編號: " + PointCurrent.ID;
                textBox_UI_Updata();
            }
            picBox_route.Refresh();
        }



        private Point Normalization(double X, double Y)//影像座標轉PictureBox座標
        {
            double XminLast = 0, XmaxLast = 0, YminLast = 0, YmaxLast = 0, ZminLast = 0, ZmaxLast = 0, width = 0, height = 0;
            if (isPicBoxClick)
            {
                XmaxLast = Xmax;
                XminLast = Xmin;
                YmaxLast = Ymax;
                YminLast = Ymin;
                ZmaxLast = Zmax;
                ZminLast = Zmin;
                width = picBox_route.Width;
                height = picBox_route.Height;
            }
            double x = (X - XminLast) / (XmaxLast - XminLast) * (width - 40) + 10;
            double y = (Y - YminLast) / (YmaxLast - YminLast) * (height - 60) + 40;
            double z = (Y - ZminLast) / (ZmaxLast - ZminLast) * (height - 150) + 50;


            return new Point((int)Math.Round(x), (int)Math.Round(y));
            

        }
    }
}
