namespace LEDSHOW
{
    partial class OrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ForeShow = new System.Windows.Forms.ToolStripMenuItem();
            this.BackShow = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbbillnolist = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbno22 = new System.Windows.Forms.Label();
            this.lbno2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbcurrentcard22 = new System.Windows.Forms.Label();
            this.lbaddress22 = new System.Windows.Forms.Label();
            this.lbcurrentcard2 = new System.Windows.Forms.Label();
            this.lbaddress2 = new System.Windows.Forms.Label();
            this.lbcarnum2 = new System.Windows.Forms.Label();
            this.lbcompletetime2 = new System.Windows.Forms.Label();
            this.lbcompletetime22 = new System.Windows.Forms.Label();
            this.lbcarnum22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelorder1 = new System.Windows.Forms.Panel();
            this.lbno12 = new System.Windows.Forms.Label();
            this.lbno1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbadress11 = new System.Windows.Forms.Label();
            this.lbcarcode11 = new System.Windows.Forms.Label();
            this.lbaddress1 = new System.Windows.Forms.Label();
            this.lbcarnum1 = new System.Windows.Forms.Label();
            this.lbcompletetime1 = new System.Windows.Forms.Label();
            this.lbcompletetime11 = new System.Windows.Forms.Label();
            this.lbcarnum11 = new System.Windows.Forms.Label();
            this.lbcurrentcard1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbworkstate = new System.Windows.Forms.Label();
            this.lblBatchValue2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeTxt = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelorder1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LED显示屏";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenScreen,
            this.CloseScreen,
            this.ForeShow,
            this.BackShow,
            this.ExitScreen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 114);
            // 
            // OpenScreen
            // 
            this.OpenScreen.Name = "OpenScreen";
            this.OpenScreen.Size = new System.Drawing.Size(158, 22);
            this.OpenScreen.Text = "打开LED显示屏";
            this.OpenScreen.Click += new System.EventHandler(this.OpenScreen_Click);
            // 
            // CloseScreen
            // 
            this.CloseScreen.Name = "CloseScreen";
            this.CloseScreen.Size = new System.Drawing.Size(158, 22);
            this.CloseScreen.Text = "关闭LED显示屏";
            this.CloseScreen.Click += new System.EventHandler(this.CloseScreen_Click);
            // 
            // ForeShow
            // 
            this.ForeShow.Name = "ForeShow";
            this.ForeShow.Size = new System.Drawing.Size(158, 22);
            this.ForeShow.Text = "前台播放LED屏";
            this.ForeShow.Click += new System.EventHandler(this.ForeShow_Click);
            // 
            // BackShow
            // 
            this.BackShow.Name = "BackShow";
            this.BackShow.Size = new System.Drawing.Size(158, 22);
            this.BackShow.Text = "后台播放LED屏";
            this.BackShow.Click += new System.EventHandler(this.BackShow_Click);
            // 
            // ExitScreen
            // 
            this.ExitScreen.Name = "ExitScreen";
            this.ExitScreen.Size = new System.Drawing.Size(158, 22);
            this.ExitScreen.Text = "退出LED显示屏";
            this.ExitScreen.Click += new System.EventHandler(this.ExitScreen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblBatchValue2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 510);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Snow;
            this.panel8.Controls.Add(this.lbbillnolist);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(9, 417);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1004, 42);
            this.panel8.TabIndex = 40;
            // 
            // lbbillnolist
            // 
            this.lbbillnolist.AutoSize = true;
            this.lbbillnolist.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.lbbillnolist.ForeColor = System.Drawing.Color.Red;
            this.lbbillnolist.Location = new System.Drawing.Point(181, 8);
            this.lbbillnolist.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.lbbillnolist.Name = "lbbillnolist";
            this.lbbillnolist.Size = new System.Drawing.Size(150, 25);
            this.lbbillnolist.TabIndex = 48;
            this.lbbillnolist.Text = "暂无排队任务";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(-1, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "送货单排队序列:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(514, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 407);
            this.panel5.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.lbno2);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(8, 214);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(490, 180);
            this.panel7.TabIndex = 42;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbno22);
            this.panel9.Location = new System.Drawing.Point(3, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(486, 116);
            this.panel9.TabIndex = 46;
            // 
            // lbno22
            // 
            this.lbno22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbno22.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.lbno22.ForeColor = System.Drawing.Color.Red;
            this.lbno22.Location = new System.Drawing.Point(0, 0);
            this.lbno22.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.lbno22.Name = "lbno22";
            this.lbno22.Size = new System.Drawing.Size(486, 116);
            this.lbno22.TabIndex = 45;
            this.lbno22.Text = "车牌号1002：等待时间约30分钟";
            // 
            // lbno2
            // 
            this.lbno2.AutoSize = true;
            this.lbno2.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.lbno2.ForeColor = System.Drawing.Color.Red;
            this.lbno2.Location = new System.Drawing.Point(4, 33);
            this.lbno2.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.lbno2.Name = "lbno2";
            this.lbno2.Size = new System.Drawing.Size(355, 25);
            this.lbno2.TabIndex = 44;
            this.lbno2.Text = "车牌号1002：等待时间约30分钟";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(163, 1);
            this.label18.Margin = new System.Windows.Forms.Padding(150, 15, 3, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 27);
            this.label18.TabIndex = 41;
            this.label18.Text = "排队车牌号";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17073F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82927F));
            this.tableLayoutPanel2.Controls.Add(this.lbcurrentcard22, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbaddress22, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbcurrentcard2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbaddress2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbcarnum2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbcompletetime2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbcompletetime22, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbcarnum22, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.35165F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64835F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 178);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // lbcurrentcard22
            // 
            this.lbcurrentcard22.AutoSize = true;
            this.lbcurrentcard22.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcurrentcard22.ForeColor = System.Drawing.Color.Black;
            this.lbcurrentcard22.Location = new System.Drawing.Point(13, 8);
            this.lbcurrentcard22.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcurrentcard22.Name = "lbcurrentcard22";
            this.lbcurrentcard22.Size = new System.Drawing.Size(187, 25);
            this.lbcurrentcard22.TabIndex = 4;
            this.lbcurrentcard22.Text = "当前入库车牌号";
            // 
            // lbaddress22
            // 
            this.lbaddress22.AutoSize = true;
            this.lbaddress22.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbaddress22.ForeColor = System.Drawing.Color.Black;
            this.lbaddress22.Location = new System.Drawing.Point(13, 46);
            this.lbaddress22.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbaddress22.Name = "lbaddress22";
            this.lbaddress22.Size = new System.Drawing.Size(112, 27);
            this.lbaddress22.TabIndex = 32;
            this.lbaddress22.Text = "中烟信息";
            // 
            // lbcurrentcard2
            // 
            this.lbcurrentcard2.AutoSize = true;
            this.lbcurrentcard2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcurrentcard2.ForeColor = System.Drawing.Color.Black;
            this.lbcurrentcard2.Location = new System.Drawing.Point(247, 8);
            this.lbcurrentcard2.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcurrentcard2.Name = "lbcurrentcard2";
            this.lbcurrentcard2.Size = new System.Drawing.Size(78, 25);
            this.lbcurrentcard2.TabIndex = 37;
            this.lbcurrentcard2.Text = "E110";
            // 
            // lbaddress2
            // 
            this.lbaddress2.AutoSize = true;
            this.lbaddress2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbaddress2.ForeColor = System.Drawing.Color.Black;
            this.lbaddress2.Location = new System.Drawing.Point(247, 46);
            this.lbaddress2.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbaddress2.Name = "lbaddress2";
            this.lbaddress2.Size = new System.Drawing.Size(112, 27);
            this.lbaddress2.TabIndex = 38;
            this.lbaddress2.Text = "四川中烟";
            // 
            // lbcarnum2
            // 
            this.lbcarnum2.AutoSize = true;
            this.lbcarnum2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcarnum2.ForeColor = System.Drawing.Color.Black;
            this.lbcarnum2.Location = new System.Drawing.Point(247, 86);
            this.lbcarnum2.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcarnum2.Name = "lbcarnum2";
            this.lbcarnum2.Size = new System.Drawing.Size(44, 27);
            this.lbcarnum2.TabIndex = 39;
            this.lbcarnum2.Text = "10";
            // 
            // lbcompletetime2
            // 
            this.lbcompletetime2.AutoSize = true;
            this.lbcompletetime2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcompletetime2.ForeColor = System.Drawing.Color.Black;
            this.lbcompletetime2.Location = new System.Drawing.Point(247, 136);
            this.lbcompletetime2.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcompletetime2.Name = "lbcompletetime2";
            this.lbcompletetime2.Size = new System.Drawing.Size(78, 27);
            this.lbcompletetime2.TabIndex = 40;
            this.lbcompletetime2.Text = "1小时";
            // 
            // lbcompletetime22
            // 
            this.lbcompletetime22.AutoSize = true;
            this.lbcompletetime22.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcompletetime22.ForeColor = System.Drawing.Color.Black;
            this.lbcompletetime22.Location = new System.Drawing.Point(13, 136);
            this.lbcompletetime22.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcompletetime22.Name = "lbcompletetime22";
            this.lbcompletetime22.Size = new System.Drawing.Size(162, 27);
            this.lbcompletetime22.TabIndex = 31;
            this.lbcompletetime22.Text = "预计完成时间";
            // 
            // lbcarnum22
            // 
            this.lbcarnum22.AutoSize = true;
            this.lbcarnum22.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcarnum22.ForeColor = System.Drawing.Color.Black;
            this.lbcarnum22.Location = new System.Drawing.Point(13, 86);
            this.lbcarnum22.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcarnum22.Name = "lbcarnum22";
            this.lbcarnum22.Size = new System.Drawing.Size(162, 27);
            this.lbcarnum22.TabIndex = 30;
            this.lbcarnum22.Text = "排队车辆总数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(96, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "二号链板机入库情况";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 407);
            this.panel4.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelorder1);
            this.panel6.Controls.Add(this.lbno1);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(3, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 180);
            this.panel6.TabIndex = 41;
            // 
            // panelorder1
            // 
            this.panelorder1.Controls.Add(this.lbno12);
            this.panelorder1.Location = new System.Drawing.Point(3, 64);
            this.panelorder1.Name = "panelorder1";
            this.panelorder1.Size = new System.Drawing.Size(484, 113);
            this.panelorder1.TabIndex = 46;
            // 
            // lbno12
            // 
            this.lbno12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbno12.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.lbno12.ForeColor = System.Drawing.Color.Red;
            this.lbno12.Location = new System.Drawing.Point(0, 0);
            this.lbno12.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.lbno12.Name = "lbno12";
            this.lbno12.Size = new System.Drawing.Size(484, 113);
            this.lbno12.TabIndex = 45;
            this.lbno12.Text = "车牌号1001：等待时间约30分钟";
            // 
            // lbno1
            // 
            this.lbno1.Font = new System.Drawing.Font("华文中宋", 16F, System.Drawing.FontStyle.Bold);
            this.lbno1.ForeColor = System.Drawing.Color.Red;
            this.lbno1.Location = new System.Drawing.Point(2, 34);
            this.lbno1.Margin = new System.Windows.Forms.Padding(30, 15, 3, 5);
            this.lbno1.Name = "lbno1";
            this.lbno1.Size = new System.Drawing.Size(474, 25);
            this.lbno1.TabIndex = 44;
            this.lbno1.Text = "车牌号1001：等待时间约30分钟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(160, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(150, 15, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 27);
            this.label10.TabIndex = 41;
            this.label10.Text = "排队车牌号";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.48665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.51335F));
            this.tableLayoutPanel1.Controls.Add(this.lbadress11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbcarcode11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbaddress1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbcarnum1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbcompletetime1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbcompletetime11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbcarnum11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbcurrentcard1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.35165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.64835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 178);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // lbadress11
            // 
            this.lbadress11.AutoSize = true;
            this.lbadress11.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbadress11.ForeColor = System.Drawing.Color.Black;
            this.lbadress11.Location = new System.Drawing.Point(13, 46);
            this.lbadress11.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbadress11.Name = "lbadress11";
            this.lbadress11.Size = new System.Drawing.Size(112, 27);
            this.lbadress11.TabIndex = 4;
            this.lbadress11.Text = "中烟信息";
            // 
            // lbcarcode11
            // 
            this.lbcarcode11.AutoSize = true;
            this.lbcarcode11.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcarcode11.ForeColor = System.Drawing.Color.Black;
            this.lbcarcode11.Location = new System.Drawing.Point(13, 8);
            this.lbcarcode11.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcarcode11.Name = "lbcarcode11";
            this.lbcarcode11.Size = new System.Drawing.Size(187, 25);
            this.lbcarcode11.TabIndex = 32;
            this.lbcarcode11.Text = "当前入库车牌号";
            // 
            // lbaddress1
            // 
            this.lbaddress1.AutoSize = true;
            this.lbaddress1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbaddress1.ForeColor = System.Drawing.Color.Black;
            this.lbaddress1.Location = new System.Drawing.Point(254, 46);
            this.lbaddress1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbaddress1.Name = "lbaddress1";
            this.lbaddress1.Size = new System.Drawing.Size(112, 27);
            this.lbaddress1.TabIndex = 33;
            this.lbaddress1.Text = "湖南中烟";
            // 
            // lbcarnum1
            // 
            this.lbcarnum1.AutoSize = true;
            this.lbcarnum1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcarnum1.ForeColor = System.Drawing.Color.Black;
            this.lbcarnum1.Location = new System.Drawing.Point(254, 86);
            this.lbcarnum1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcarnum1.Name = "lbcarnum1";
            this.lbcarnum1.Size = new System.Drawing.Size(28, 27);
            this.lbcarnum1.TabIndex = 34;
            this.lbcarnum1.Text = "5";
            // 
            // lbcompletetime1
            // 
            this.lbcompletetime1.AutoSize = true;
            this.lbcompletetime1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcompletetime1.ForeColor = System.Drawing.Color.Black;
            this.lbcompletetime1.Location = new System.Drawing.Point(254, 136);
            this.lbcompletetime1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcompletetime1.Name = "lbcompletetime1";
            this.lbcompletetime1.Size = new System.Drawing.Size(94, 27);
            this.lbcompletetime1.TabIndex = 35;
            this.lbcompletetime1.Text = "30分钟";
            // 
            // lbcompletetime11
            // 
            this.lbcompletetime11.AutoSize = true;
            this.lbcompletetime11.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcompletetime11.ForeColor = System.Drawing.Color.Black;
            this.lbcompletetime11.Location = new System.Drawing.Point(13, 136);
            this.lbcompletetime11.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcompletetime11.Name = "lbcompletetime11";
            this.lbcompletetime11.Size = new System.Drawing.Size(162, 27);
            this.lbcompletetime11.TabIndex = 31;
            this.lbcompletetime11.Text = "预计完成时间";
            // 
            // lbcarnum11
            // 
            this.lbcarnum11.AutoSize = true;
            this.lbcarnum11.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcarnum11.ForeColor = System.Drawing.Color.Black;
            this.lbcarnum11.Location = new System.Drawing.Point(13, 86);
            this.lbcarnum11.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcarnum11.Name = "lbcarnum11";
            this.lbcarnum11.Size = new System.Drawing.Size(162, 27);
            this.lbcarnum11.TabIndex = 30;
            this.lbcarnum11.Text = "排队车辆总数";
            // 
            // lbcurrentcard1
            // 
            this.lbcurrentcard1.AutoSize = true;
            this.lbcurrentcard1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.lbcurrentcard1.ForeColor = System.Drawing.Color.Black;
            this.lbcurrentcard1.Location = new System.Drawing.Point(254, 8);
            this.lbcurrentcard1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.lbcurrentcard1.Name = "lbcurrentcard1";
            this.lbcurrentcard1.Size = new System.Drawing.Size(78, 25);
            this.lbcurrentcard1.TabIndex = 36;
            this.lbcurrentcard1.Text = "E110";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("华文新魏", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(94, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 30);
            this.label11.TabIndex = 38;
            this.label11.Text = "一号链板机入库情况";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.lbworkstate);
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 48);
            this.panel3.TabIndex = 36;
            // 
            // lbworkstate
            // 
            this.lbworkstate.AutoSize = true;
            this.lbworkstate.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbworkstate.ForeColor = System.Drawing.Color.Green;
            this.lbworkstate.Location = new System.Drawing.Point(402, 11);
            this.lbworkstate.Name = "lbworkstate";
            this.lbworkstate.Size = new System.Drawing.Size(223, 29);
            this.lbworkstate.TabIndex = 30;
            this.lbworkstate.Text = "调度作业进行中";
            // 
            // lblBatchValue2
            // 
            this.lblBatchValue2.AutoSize = true;
            this.lblBatchValue2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.lblBatchValue2.ForeColor = System.Drawing.Color.Red;
            this.lblBatchValue2.Location = new System.Drawing.Point(1122, 140);
            this.lblBatchValue2.Name = "lblBatchValue2";
            this.lblBatchValue2.Size = new System.Drawing.Size(0, 24);
            this.lblBatchValue2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblTimeTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 90);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(321, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "永州入库车辆调度系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTime.Location = new System.Drawing.Point(3, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(137, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "北京时间：";
            // 
            // lblTimeTxt
            // 
            this.lblTimeTxt.AutoSize = true;
            this.lblTimeTxt.Font = new System.Drawing.Font("宋体", 18F);
            this.lblTimeTxt.ForeColor = System.Drawing.Color.White;
            this.lblTimeTxt.Location = new System.Drawing.Point(136, 58);
            this.lblTimeTxt.Name = "lblTimeTxt";
            this.lblTimeTxt.Size = new System.Drawing.Size(0, 24);
            this.lblTimeTxt.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Interval = 10000000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(351, 148);
            this.Name = "OrderList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelorder1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenScreen;
        private System.Windows.Forms.ToolStripMenuItem CloseScreen;
        private System.Windows.Forms.ToolStripMenuItem BackShow;
        private System.Windows.Forms.ToolStripMenuItem ExitScreen;
        private System.Windows.Forms.ToolStripMenuItem ForeShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBatchValue2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbworkstate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbadress11;
        private System.Windows.Forms.Label lbcarnum11;
        private System.Windows.Forms.Label lbcompletetime11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbcarnum22;
        private System.Windows.Forms.Label lbcurrentcard22;
        private System.Windows.Forms.Label lbcompletetime22;
        private System.Windows.Forms.Label lblTimeTxt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbno1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbno2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbcarcode11;
        private System.Windows.Forms.Label lbaddress22;
        private System.Windows.Forms.Label lbbillnolist;
        private System.Windows.Forms.Label lbno12;
        private System.Windows.Forms.Label lbno22;
        private System.Windows.Forms.Label lbaddress1;
        private System.Windows.Forms.Label lbcarnum1;
        private System.Windows.Forms.Label lbcompletetime1;
        private System.Windows.Forms.Label lbcurrentcard1;
        private System.Windows.Forms.Label lbcurrentcard2;
        private System.Windows.Forms.Label lbaddress2;
        private System.Windows.Forms.Label lbcarnum2;
        private System.Windows.Forms.Label lbcompletetime2;
        private System.Windows.Forms.Panel panelorder1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Timer timer2;

    }
}