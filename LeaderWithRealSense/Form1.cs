using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using LinearAlgebra;

namespace LeaderWithRealSense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btn_pointEdit, "編輯座標");
            toolTip1.SetToolTip(btn_pointSave, "儲存檔案");
            toolTip1.SetToolTip(btn_fileLoad, "開啟檔案");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connectFlag)
            {
                connectFlag = false;
                read.Abort();
                read = null;
            }

        }

        private void btn_createPath_Click(object sender, EventArgs e)
        {
            List<Xyz> points = new List<Xyz>();
            List<Xyz> normals = new List<Xyz>();
            List<Xyz> tangents = new List<Xyz>();
            List<Xyz> ypr = new List<Xyz>();

            string[] tmpLines = File.ReadAllLines("bottom_edge_normalC.pcd");
            string[] point;
            StreamWriter writer = new StreamWriter("Tangents.txt");
            for (int i = 11; i < tmpLines.Length; i += 1)
            {
                //法向量原點
                point = tmpLines[i].Split(' ');
                double x = double.Parse(point[0]);
                double y = double.Parse(point[1]);
                double z = double.Parse(point[2]);
                points.Add(new Xyz(x, y, z));
                //法向量
                double nx = -double.Parse(point[4]);
                double ny = -double.Parse(point[5]);
                double nz = -double.Parse(point[6]);
                normals.Add(new Xyz(nx, ny, nz));
                //下一個點
                int next = i + 1 <= tmpLines.Length - 1 ? i + 1 : 11;
                point = tmpLines[next].Split(' ');
                double xx = double.Parse(point[0]);
                double yy = double.Parse(point[1]);
                double zz = double.Parse(point[2]);

                //投影向量
                double a = nx, b = ny, c = nz;
                double t = ((nx * x + ny * y + nz * z) - (xx * a) - (yy * b) - (zz * c)) / ((nx * a) + (ny * b) + (nz * c));
                double hx = xx + t * nx;
                double hy = yy + t * ny;
                double hz = zz + t * nz;

                //切線向量
                double gx = x - hx;
                double gy = y - hy;
                double gz = z - hz;
                double leng = Math.Sqrt(gx * gx + gy * gy + gz * gz);
                gx /= leng; gy /= leng; gz /= leng;
                double theta = Math.Acos((nx * gx + ny * gy + nz * gz)) * 180 / Math.PI;
                //Console.WriteLine($"目標點：{x},{y},{z}  投影點：{hx},{hy},{hz}");
                //Console.WriteLine($"法向量：{nx},{ny},{nz}  切線向量：{gx},{gy},{gz}  夾角：{theta}");
                tangents.Add(new Xyz(gx, gy, gz));
                writer.WriteLine($"{i - 10},{gx},{gy},{gz}");
            }
            writer.Flush();
            writer.Close();

            writer = new StreamWriter("SprayPath.txt");
            double len = 0;
            double nyaw = 0, npitch = 0, nlen = 0;
            for (int i = 0; i < points.Count(); i++)
            {
                double x = normals[i].X;
                double y = normals[i].Y;
                double z = normals[i].Z;

                len = Math.Sqrt(x * x + y * y + z * z);
                nlen = Math.Sqrt(x * x + y * y);
                nyaw = Math.Acos(x / nlen);
                if (y < 0) nyaw = -nyaw;
                npitch = Math.Acos(nlen / len);
                if (z > 0) npitch = -npitch;

                Matrix m = new Matrix(new double[,] { { tangents[i].X, tangents[i].Y, tangents[i].Z } });
                Matrix yaxis = new Matrix(new double[,] { { 0 }, { 1 }, { 0 } });

                Matrix Rx = new Matrix(new double[,] { { 1, 0, 0 }, { 0, Math.Cos(0), -Math.Sin(0) }, { 0, Math.Sin(0), Math.Cos(0) } });
                Matrix Ry = new Matrix(new double[,] { { Math.Cos(npitch), 0, Math.Sin(npitch) }, { 0, 1, 0 }, { -Math.Sin(npitch), 0, Math.Cos(npitch) } });
                Matrix Rz = new Matrix(new double[,] { { Math.Cos(nyaw), -Math.Sin(nyaw), 0 }, { Math.Sin(nyaw), Math.Cos(nyaw), 0 }, { 0, 0, 1 } });

                Matrix t = Rz * yaxis;
                double gx = t.Elements[0, 0];
                double gy = t.Elements[1, 0];
                double gz = t.Elements[2, 0];
                nlen = Math.Sqrt(gx * gx + gy * gy);
                double nrow = Math.Acos((m.Elements[0, 0] * gx + m.Elements[0, 1] * gy + m.Elements[0, 2] * gz) / 1);// * 180 / Math.PI;
                if (m.Elements[0, 2] - gz < 0) nrow = -nrow;
                //Console.WriteLine($"yaw：{nyaw}  pitch：{npitch}");
                //Console.WriteLine($"法向量：{x},{y},{z}  y軸旋轉後向量：{gx},{gy},{gz}  夾角：{nrow}");

                ypr.Add(new Xyz(nyaw * 180 / Math.PI, npitch * 180 / Math.PI, nrow * 180 / Math.PI));
                writer.WriteLine($"{i + 1},{points[i].X},{points[i].Y},{points[i].Z},{nyaw * 180 / Math.PI},{npitch * 180 / Math.PI},{nrow * 180 / Math.PI}");
            }
            writer.Flush();
            writer.Close();
        }
    }
}
