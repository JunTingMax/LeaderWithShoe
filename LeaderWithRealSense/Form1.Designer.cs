namespace LeaderWithRealSense
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage_route = new System.Windows.Forms.TabPage();
            this.lbl_pointID = new System.Windows.Forms.Label();
            this.btn_playRoute = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_prevPoint = new System.Windows.Forms.Button();
            this.btn_nextPoint = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tBxPointRY = new System.Windows.Forms.TextBox();
            this.tBxPointRZ = new System.Windows.Forms.TextBox();
            this.tBxPointZ = new System.Windows.Forms.TextBox();
            this.tBxPointRX = new System.Windows.Forms.TextBox();
            this.tBxPointY = new System.Windows.Forms.TextBox();
            this.tBxPointX = new System.Windows.Forms.TextBox();
            this.picBox_route = new System.Windows.Forms.PictureBox();
            this.btn_fileLoad = new System.Windows.Forms.Button();
            this.btn_pointSave = new System.Windows.Forms.Button();
            this.btn_pointEdit = new System.Windows.Forms.Button();
            this.tabPage_Leader = new System.Windows.Forms.TabPage();
            this.lbl_state = new System.Windows.Forms.Label();
            this.tBx_RZ = new System.Windows.Forms.TextBox();
            this.tBx_J6 = new System.Windows.Forms.TextBox();
            this.tBx_RY = new System.Windows.Forms.TextBox();
            this.tBx_J5 = new System.Windows.Forms.TextBox();
            this.tBx_RX = new System.Windows.Forms.TextBox();
            this.tBx_J4 = new System.Windows.Forms.TextBox();
            this.tBx_Z = new System.Windows.Forms.TextBox();
            this.tBx_J3 = new System.Windows.Forms.TextBox();
            this.tBx_Y = new System.Windows.Forms.TextBox();
            this.tBx_J2 = new System.Windows.Forms.TextBox();
            this.tBx_speed = new System.Windows.Forms.TextBox();
            this.tBx_X = new System.Windows.Forms.TextBox();
            this.tBx_J1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_XYZ = new System.Windows.Forms.Label();
            this.lbl_Joint = new System.Windows.Forms.Label();
            this.btn_moveL = new System.Windows.Forms.Button();
            this.btn_moveJ = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_createPath = new System.Windows.Forms.Button();
            this.tabPage_route.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_route)).BeginInit();
            this.tabPage_Leader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_route
            // 
            this.tabPage_route.Controls.Add(this.btn_createPath);
            this.tabPage_route.Controls.Add(this.lbl_pointID);
            this.tabPage_route.Controls.Add(this.btn_playRoute);
            this.tabPage_route.Controls.Add(this.btn_confirm);
            this.tabPage_route.Controls.Add(this.btn_prevPoint);
            this.tabPage_route.Controls.Add(this.btn_nextPoint);
            this.tabPage_route.Controls.Add(this.label34);
            this.tabPage_route.Controls.Add(this.label35);
            this.tabPage_route.Controls.Add(this.label36);
            this.tabPage_route.Controls.Add(this.label37);
            this.tabPage_route.Controls.Add(this.label38);
            this.tabPage_route.Controls.Add(this.label39);
            this.tabPage_route.Controls.Add(this.tBxPointRY);
            this.tabPage_route.Controls.Add(this.tBxPointRZ);
            this.tabPage_route.Controls.Add(this.tBxPointZ);
            this.tabPage_route.Controls.Add(this.tBxPointRX);
            this.tabPage_route.Controls.Add(this.tBxPointY);
            this.tabPage_route.Controls.Add(this.tBxPointX);
            this.tabPage_route.Controls.Add(this.picBox_route);
            this.tabPage_route.Controls.Add(this.btn_fileLoad);
            this.tabPage_route.Controls.Add(this.btn_pointSave);
            this.tabPage_route.Controls.Add(this.btn_pointEdit);
            this.tabPage_route.Location = new System.Drawing.Point(4, 22);
            this.tabPage_route.Name = "tabPage_route";
            this.tabPage_route.Size = new System.Drawing.Size(1109, 536);
            this.tabPage_route.TabIndex = 3;
            this.tabPage_route.Text = "路徑";
            this.tabPage_route.UseVisualStyleBackColor = true;
            // 
            // lbl_pointID
            // 
            this.lbl_pointID.AutoSize = true;
            this.lbl_pointID.Font = new System.Drawing.Font("標楷體", 12F);
            this.lbl_pointID.Location = new System.Drawing.Point(878, 13);
            this.lbl_pointID.Name = "lbl_pointID";
            this.lbl_pointID.Size = new System.Drawing.Size(112, 16);
            this.lbl_pointID.TabIndex = 94;
            this.lbl_pointID.Text = "路徑點編號: *";
            // 
            // btn_playRoute
            // 
            this.btn_playRoute.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_playRoute.Location = new System.Drawing.Point(892, 437);
            this.btn_playRoute.Name = "btn_playRoute";
            this.btn_playRoute.Size = new System.Drawing.Size(212, 54);
            this.btn_playRoute.TabIndex = 93;
            this.btn_playRoute.Text = "執行路徑";
            this.btn_playRoute.UseVisualStyleBackColor = true;
            this.btn_playRoute.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Enabled = false;
            this.btn_confirm.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_confirm.Location = new System.Drawing.Point(973, 395);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(131, 36);
            this.btn_confirm.TabIndex = 92;
            this.btn_confirm.Text = "確認修改";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // btn_prevPoint
            // 
            this.btn_prevPoint.Location = new System.Drawing.Point(892, 375);
            this.btn_prevPoint.Name = "btn_prevPoint";
            this.btn_prevPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_prevPoint.TabIndex = 91;
            this.btn_prevPoint.Text = "上一個點";
            this.btn_prevPoint.UseVisualStyleBackColor = true;
            this.btn_prevPoint.Click += new System.EventHandler(this.btn_prevPoint_Click);
            // 
            // btn_nextPoint
            // 
            this.btn_nextPoint.Location = new System.Drawing.Point(892, 404);
            this.btn_nextPoint.Name = "btn_nextPoint";
            this.btn_nextPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_nextPoint.TabIndex = 90;
            this.btn_nextPoint.Text = "下一個點";
            this.btn_nextPoint.UseVisualStyleBackColor = true;
            this.btn_nextPoint.Click += new System.EventHandler(this.btn_nextPoint_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label34.Location = new System.Drawing.Point(971, 250);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 16);
            this.label34.TabIndex = 83;
            this.label34.Text = "RZ:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label35.Location = new System.Drawing.Point(972, 209);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(32, 16);
            this.label35.TabIndex = 82;
            this.label35.Text = "RY:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label36.Location = new System.Drawing.Point(972, 168);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 16);
            this.label36.TabIndex = 81;
            this.label36.Text = "RX:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label37.Location = new System.Drawing.Point(976, 127);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(24, 16);
            this.label37.TabIndex = 78;
            this.label37.Text = "Z:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label38.Location = new System.Drawing.Point(976, 86);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(24, 16);
            this.label38.TabIndex = 80;
            this.label38.Text = "Y:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.Location = new System.Drawing.Point(976, 45);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(24, 16);
            this.label39.TabIndex = 79;
            this.label39.Text = "X:";
            // 
            // tBxPointRY
            // 
            this.tBxPointRY.Enabled = false;
            this.tBxPointRY.Location = new System.Drawing.Point(1006, 203);
            this.tBxPointRY.Name = "tBxPointRY";
            this.tBxPointRY.Size = new System.Drawing.Size(81, 22);
            this.tBxPointRY.TabIndex = 88;
            // 
            // tBxPointRZ
            // 
            this.tBxPointRZ.Enabled = false;
            this.tBxPointRZ.Location = new System.Drawing.Point(1006, 244);
            this.tBxPointRZ.Name = "tBxPointRZ";
            this.tBxPointRZ.Size = new System.Drawing.Size(81, 22);
            this.tBxPointRZ.TabIndex = 89;
            // 
            // tBxPointZ
            // 
            this.tBxPointZ.Enabled = false;
            this.tBxPointZ.Location = new System.Drawing.Point(1006, 121);
            this.tBxPointZ.Name = "tBxPointZ";
            this.tBxPointZ.Size = new System.Drawing.Size(81, 22);
            this.tBxPointZ.TabIndex = 86;
            // 
            // tBxPointRX
            // 
            this.tBxPointRX.Enabled = false;
            this.tBxPointRX.Location = new System.Drawing.Point(1006, 162);
            this.tBxPointRX.Name = "tBxPointRX";
            this.tBxPointRX.Size = new System.Drawing.Size(81, 22);
            this.tBxPointRX.TabIndex = 87;
            // 
            // tBxPointY
            // 
            this.tBxPointY.Enabled = false;
            this.tBxPointY.Location = new System.Drawing.Point(1006, 80);
            this.tBxPointY.Name = "tBxPointY";
            this.tBxPointY.Size = new System.Drawing.Size(81, 22);
            this.tBxPointY.TabIndex = 85;
            // 
            // tBxPointX
            // 
            this.tBxPointX.Enabled = false;
            this.tBxPointX.Location = new System.Drawing.Point(1006, 39);
            this.tBxPointX.Name = "tBxPointX";
            this.tBxPointX.Size = new System.Drawing.Size(81, 22);
            this.tBxPointX.TabIndex = 84;
            // 
            // picBox_route
            // 
            this.picBox_route.Location = new System.Drawing.Point(11, 9);
            this.picBox_route.Name = "picBox_route";
            this.picBox_route.Size = new System.Drawing.Size(859, 520);
            this.picBox_route.TabIndex = 77;
            this.picBox_route.TabStop = false;
            this.picBox_route.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_route_Paint);
            this.picBox_route.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_route_MouseDown);
            // 
            // btn_fileLoad
            // 
            this.btn_fileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fileLoad.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_fileLoad.Image = ((System.Drawing.Image)(resources.GetObject("btn_fileLoad.Image")));
            this.btn_fileLoad.Location = new System.Drawing.Point(973, 349);
            this.btn_fileLoad.Name = "btn_fileLoad";
            this.btn_fileLoad.Size = new System.Drawing.Size(40, 40);
            this.btn_fileLoad.TabIndex = 76;
            this.btn_fileLoad.UseVisualStyleBackColor = false;
            this.btn_fileLoad.Click += new System.EventHandler(this.btn_fileLoad_Click);
            // 
            // btn_pointSave
            // 
            this.btn_pointSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_pointSave.Image")));
            this.btn_pointSave.Location = new System.Drawing.Point(1018, 349);
            this.btn_pointSave.Name = "btn_pointSave";
            this.btn_pointSave.Size = new System.Drawing.Size(40, 40);
            this.btn_pointSave.TabIndex = 75;
            this.btn_pointSave.UseVisualStyleBackColor = true;
            // 
            // btn_pointEdit
            // 
            this.btn_pointEdit.BackColor = System.Drawing.Color.Transparent;
            this.btn_pointEdit.Image = ((System.Drawing.Image)(resources.GetObject("btn_pointEdit.Image")));
            this.btn_pointEdit.Location = new System.Drawing.Point(1064, 349);
            this.btn_pointEdit.Name = "btn_pointEdit";
            this.btn_pointEdit.Size = new System.Drawing.Size(40, 40);
            this.btn_pointEdit.TabIndex = 74;
            this.btn_pointEdit.UseVisualStyleBackColor = false;
            // 
            // tabPage_Leader
            // 
            this.tabPage_Leader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_Leader.Controls.Add(this.lbl_state);
            this.tabPage_Leader.Controls.Add(this.tBx_RZ);
            this.tabPage_Leader.Controls.Add(this.tBx_J6);
            this.tabPage_Leader.Controls.Add(this.tBx_RY);
            this.tabPage_Leader.Controls.Add(this.tBx_J5);
            this.tabPage_Leader.Controls.Add(this.tBx_RX);
            this.tabPage_Leader.Controls.Add(this.tBx_J4);
            this.tabPage_Leader.Controls.Add(this.tBx_Z);
            this.tabPage_Leader.Controls.Add(this.tBx_J3);
            this.tabPage_Leader.Controls.Add(this.tBx_Y);
            this.tabPage_Leader.Controls.Add(this.tBx_J2);
            this.tabPage_Leader.Controls.Add(this.tBx_speed);
            this.tabPage_Leader.Controls.Add(this.tBx_X);
            this.tabPage_Leader.Controls.Add(this.tBx_J1);
            this.tabPage_Leader.Controls.Add(this.label12);
            this.tabPage_Leader.Controls.Add(this.label6);
            this.tabPage_Leader.Controls.Add(this.label11);
            this.tabPage_Leader.Controls.Add(this.label5);
            this.tabPage_Leader.Controls.Add(this.label10);
            this.tabPage_Leader.Controls.Add(this.label4);
            this.tabPage_Leader.Controls.Add(this.label9);
            this.tabPage_Leader.Controls.Add(this.label3);
            this.tabPage_Leader.Controls.Add(this.label8);
            this.tabPage_Leader.Controls.Add(this.label13);
            this.tabPage_Leader.Controls.Add(this.label2);
            this.tabPage_Leader.Controls.Add(this.label7);
            this.tabPage_Leader.Controls.Add(this.label1);
            this.tabPage_Leader.Controls.Add(this.lbl_XYZ);
            this.tabPage_Leader.Controls.Add(this.lbl_Joint);
            this.tabPage_Leader.Controls.Add(this.btn_moveL);
            this.tabPage_Leader.Controls.Add(this.btn_moveJ);
            this.tabPage_Leader.Controls.Add(this.btn_connect);
            this.tabPage_Leader.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage_Leader.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Leader.Name = "tabPage_Leader";
            this.tabPage_Leader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Leader.Size = new System.Drawing.Size(1109, 536);
            this.tabPage_Leader.TabIndex = 0;
            this.tabPage_Leader.Text = "Leader";
            this.tabPage_Leader.UseVisualStyleBackColor = true;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_state.Location = new System.Drawing.Point(26, 261);
            this.lbl_state.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(109, 19);
            this.lbl_state.TabIndex = 38;
            this.lbl_state.Text = "動作狀態: ";
            // 
            // tBx_RZ
            // 
            this.tBx_RZ.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_RZ.Location = new System.Drawing.Point(704, 155);
            this.tBx_RZ.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_RZ.Name = "tBx_RZ";
            this.tBx_RZ.Size = new System.Drawing.Size(72, 28);
            this.tBx_RZ.TabIndex = 36;
            this.tBx_RZ.Text = "0";
            // 
            // tBx_J6
            // 
            this.tBx_J6.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_J6.Location = new System.Drawing.Point(704, 110);
            this.tBx_J6.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_J6.Name = "tBx_J6";
            this.tBx_J6.Size = new System.Drawing.Size(72, 28);
            this.tBx_J6.TabIndex = 35;
            this.tBx_J6.Text = "0";
            // 
            // tBx_RY
            // 
            this.tBx_RY.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_RY.Location = new System.Drawing.Point(577, 155);
            this.tBx_RY.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_RY.Name = "tBx_RY";
            this.tBx_RY.Size = new System.Drawing.Size(72, 28);
            this.tBx_RY.TabIndex = 34;
            this.tBx_RY.Text = "0";
            // 
            // tBx_J5
            // 
            this.tBx_J5.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_J5.Location = new System.Drawing.Point(577, 110);
            this.tBx_J5.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_J5.Name = "tBx_J5";
            this.tBx_J5.Size = new System.Drawing.Size(72, 28);
            this.tBx_J5.TabIndex = 33;
            this.tBx_J5.Text = "0";
            // 
            // tBx_RX
            // 
            this.tBx_RX.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_RX.Location = new System.Drawing.Point(450, 155);
            this.tBx_RX.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_RX.Name = "tBx_RX";
            this.tBx_RX.Size = new System.Drawing.Size(72, 28);
            this.tBx_RX.TabIndex = 32;
            this.tBx_RX.Text = "0";
            // 
            // tBx_J4
            // 
            this.tBx_J4.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_J4.Location = new System.Drawing.Point(450, 110);
            this.tBx_J4.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_J4.Name = "tBx_J4";
            this.tBx_J4.Size = new System.Drawing.Size(72, 28);
            this.tBx_J4.TabIndex = 31;
            this.tBx_J4.Text = "0";
            // 
            // tBx_Z
            // 
            this.tBx_Z.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_Z.Location = new System.Drawing.Point(322, 155);
            this.tBx_Z.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_Z.Name = "tBx_Z";
            this.tBx_Z.Size = new System.Drawing.Size(72, 28);
            this.tBx_Z.TabIndex = 30;
            this.tBx_Z.Text = "0";
            // 
            // tBx_J3
            // 
            this.tBx_J3.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_J3.Location = new System.Drawing.Point(322, 110);
            this.tBx_J3.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_J3.Name = "tBx_J3";
            this.tBx_J3.Size = new System.Drawing.Size(72, 28);
            this.tBx_J3.TabIndex = 28;
            this.tBx_J3.Text = "0";
            // 
            // tBx_Y
            // 
            this.tBx_Y.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_Y.Location = new System.Drawing.Point(194, 155);
            this.tBx_Y.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_Y.Name = "tBx_Y";
            this.tBx_Y.Size = new System.Drawing.Size(72, 28);
            this.tBx_Y.TabIndex = 29;
            this.tBx_Y.Text = "0";
            // 
            // tBx_J2
            // 
            this.tBx_J2.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_J2.Location = new System.Drawing.Point(194, 110);
            this.tBx_J2.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_J2.Name = "tBx_J2";
            this.tBx_J2.Size = new System.Drawing.Size(72, 28);
            this.tBx_J2.TabIndex = 37;
            this.tBx_J2.Text = "0";
            // 
            // tBx_speed
            // 
            this.tBx_speed.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_speed.Location = new System.Drawing.Point(90, 207);
            this.tBx_speed.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_speed.Name = "tBx_speed";
            this.tBx_speed.Size = new System.Drawing.Size(72, 28);
            this.tBx_speed.TabIndex = 27;
            this.tBx_speed.Text = "10";
            // 
            // tBx_X
            // 
            this.tBx_X.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_X.Location = new System.Drawing.Point(67, 155);
            this.tBx_X.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_X.Name = "tBx_X";
            this.tBx_X.Size = new System.Drawing.Size(72, 28);
            this.tBx_X.TabIndex = 26;
            this.tBx_X.Text = "0";
            // 
            // tBx_J1
            // 
            this.tBx_J1.Font = new System.Drawing.Font("新細明體", 13F);
            this.tBx_J1.Location = new System.Drawing.Point(67, 110);
            this.tBx_J1.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_J1.Name = "tBx_J1";
            this.tBx_J1.Size = new System.Drawing.Size(72, 28);
            this.tBx_J1.TabIndex = 25;
            this.tBx_J1.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 13F);
            this.label12.Location = new System.Drawing.Point(662, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "RZ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 13F);
            this.label6.Location = new System.Drawing.Point(667, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "J6 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 13F);
            this.label11.Location = new System.Drawing.Point(533, 161);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "RY : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 13F);
            this.label5.Location = new System.Drawing.Point(540, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "J5 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 13F);
            this.label10.Location = new System.Drawing.Point(405, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "RX : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 13F);
            this.label4.Location = new System.Drawing.Point(412, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "J4 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 13F);
            this.label9.Location = new System.Drawing.Point(284, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Z : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13F);
            this.label3.Location = new System.Drawing.Point(284, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "J3 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 13F);
            this.label8.Location = new System.Drawing.Point(157, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Y : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 13F);
            this.label13.Location = new System.Drawing.Point(30, 213);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Speed : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13F);
            this.label2.Location = new System.Drawing.Point(157, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "J2 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 13F);
            this.label7.Location = new System.Drawing.Point(30, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "X : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13F);
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "J1 : ";
            // 
            // lbl_XYZ
            // 
            this.lbl_XYZ.AutoSize = true;
            this.lbl_XYZ.Font = new System.Drawing.Font("標楷體", 15F);
            this.lbl_XYZ.Location = new System.Drawing.Point(26, 382);
            this.lbl_XYZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_XYZ.Name = "lbl_XYZ";
            this.lbl_XYZ.Size = new System.Drawing.Size(79, 20);
            this.lbl_XYZ.TabIndex = 11;
            this.lbl_XYZ.Text = "XYZ座標";
            // 
            // lbl_Joint
            // 
            this.lbl_Joint.AutoSize = true;
            this.lbl_Joint.Font = new System.Drawing.Font("標楷體", 15F);
            this.lbl_Joint.Location = new System.Drawing.Point(26, 318);
            this.lbl_Joint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Joint.Name = "lbl_Joint";
            this.lbl_Joint.Size = new System.Drawing.Size(89, 20);
            this.lbl_Joint.TabIndex = 10;
            this.lbl_Joint.Text = "關節座標";
            // 
            // btn_moveL
            // 
            this.btn_moveL.Location = new System.Drawing.Point(991, 157);
            this.btn_moveL.Name = "btn_moveL";
            this.btn_moveL.Size = new System.Drawing.Size(79, 26);
            this.btn_moveL.TabIndex = 8;
            this.btn_moveL.Text = "MoveL";
            this.btn_moveL.UseVisualStyleBackColor = true;
            this.btn_moveL.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_moveJ
            // 
            this.btn_moveJ.Location = new System.Drawing.Point(991, 109);
            this.btn_moveJ.Name = "btn_moveJ";
            this.btn_moveJ.Size = new System.Drawing.Size(79, 25);
            this.btn_moveJ.TabIndex = 9;
            this.btn_moveJ.Text = "MoveJ";
            this.btn_moveJ.UseVisualStyleBackColor = true;
            this.btn_moveJ.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_connect.Location = new System.Drawing.Point(30, 17);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(79, 49);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "連線";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Leader);
            this.tabControl1.Controls.Add(this.tabPage_route);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // btn_createPath
            // 
            this.btn_createPath.Font = new System.Drawing.Font("標楷體", 10F);
            this.btn_createPath.Location = new System.Drawing.Point(892, 329);
            this.btn_createPath.Name = "btn_createPath";
            this.btn_createPath.Size = new System.Drawing.Size(75, 40);
            this.btn_createPath.TabIndex = 95;
            this.btn_createPath.Text = "生成路徑";
            this.btn_createPath.UseVisualStyleBackColor = true;
            this.btn_createPath.Click += new System.EventHandler(this.btn_createPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Leader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPage_route.ResumeLayout(false);
            this.tabPage_route.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_route)).EndInit();
            this.tabPage_Leader.ResumeLayout(false);
            this.tabPage_Leader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage_route;
        private System.Windows.Forms.Label lbl_pointID;
        private System.Windows.Forms.Button btn_playRoute;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_prevPoint;
        private System.Windows.Forms.Button btn_nextPoint;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox tBxPointRY;
        private System.Windows.Forms.TextBox tBxPointRZ;
        private System.Windows.Forms.TextBox tBxPointZ;
        private System.Windows.Forms.TextBox tBxPointRX;
        private System.Windows.Forms.TextBox tBxPointY;
        private System.Windows.Forms.TextBox tBxPointX;
        private System.Windows.Forms.PictureBox picBox_route;
        private System.Windows.Forms.Button btn_fileLoad;
        private System.Windows.Forms.Button btn_pointSave;
        private System.Windows.Forms.Button btn_pointEdit;
        private System.Windows.Forms.TabPage tabPage_Leader;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox tBx_RZ;
        private System.Windows.Forms.TextBox tBx_J6;
        private System.Windows.Forms.TextBox tBx_RY;
        private System.Windows.Forms.TextBox tBx_J5;
        private System.Windows.Forms.TextBox tBx_RX;
        private System.Windows.Forms.TextBox tBx_J4;
        private System.Windows.Forms.TextBox tBx_Z;
        private System.Windows.Forms.TextBox tBx_J3;
        private System.Windows.Forms.TextBox tBx_Y;
        private System.Windows.Forms.TextBox tBx_J2;
        private System.Windows.Forms.TextBox tBx_speed;
        private System.Windows.Forms.TextBox tBx_X;
        private System.Windows.Forms.TextBox tBx_J1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_XYZ;
        private System.Windows.Forms.Label lbl_Joint;
        private System.Windows.Forms.Button btn_moveL;
        private System.Windows.Forms.Button btn_moveJ;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_createPath;
    }
}

