﻿namespace WSV.MyLog
{
    partial class Mylog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv = new WSV.Control.DataGridView.MyDataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Search = new System.Windows.Forms.ToolStripButton();
            this.Btn_Export = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fresh = new System.Windows.Forms.ToolStripButton();
            this.Btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_UsedName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dt_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.Dt_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dt_TimeBegin = new System.Windows.Forms.DateTimePicker();
            this.Dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Code,
            this.Work,
            this.Col_Name,
            this.InTime,
            this.OutTime});
            this.gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv.EnterNextRow = true;
            this.gv.Location = new System.Drawing.Point(0, 138);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowCode = true;
            this.gv.RowTemplate.Height = 23;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(618, 316);
            this.gv.TabIndex = 2;
            this.gv.Total = false;
            this.gv.TotalText = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Search,
            this.Btn_Export,
            this.Btn_Fresh,
            this.Btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(618, 32);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::WSV.Properties.Resources.Btn_Search;
            this.Btn_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(58, 29);
            this.Btn_Search.Text = "查询";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Export
            // 
            this.Btn_Export.Image = global::WSV.Properties.Resources.Btn_Export;
            this.Btn_Export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(58, 29);
            this.Btn_Export.Text = "导出";
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.Image = global::WSV.Properties.Resources.Btn_Fresh;
            this.Btn_Fresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Fresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(58, 29);
            this.Btn_Fresh.Text = "刷新";
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Image = global::WSV.Properties.Resources.Btn_Close;
            this.Btn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(58, 29);
            this.Btn_Exit.Text = "退出";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cmb_UsedName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Dt_TimeEnd);
            this.groupBox1.Controls.Add(this.Dt_DateEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dt_TimeBegin);
            this.groupBox1.Controls.Add(this.Dt_DateBegin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "操作人员:";
            // 
            // Cmb_UsedName
            // 
            this.Cmb_UsedName.FormattingEnabled = true;
            this.Cmb_UsedName.Location = new System.Drawing.Point(412, 25);
            this.Cmb_UsedName.Name = "Cmb_UsedName";
            this.Cmb_UsedName.Size = new System.Drawing.Size(87, 20);
            this.Cmb_UsedName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "结束时间:";
            // 
            // Dt_TimeEnd
            // 
            this.Dt_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeEnd.Location = new System.Drawing.Point(261, 65);
            this.Dt_TimeEnd.Name = "Dt_TimeEnd";
            this.Dt_TimeEnd.ShowUpDown = true;
            this.Dt_TimeEnd.Size = new System.Drawing.Size(75, 21);
            this.Dt_TimeEnd.TabIndex = 37;
            // 
            // Dt_DateEnd
            // 
            this.Dt_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_DateEnd.Location = new System.Drawing.Point(170, 65);
            this.Dt_DateEnd.Name = "Dt_DateEnd";
            this.Dt_DateEnd.Size = new System.Drawing.Size(87, 21);
            this.Dt_DateEnd.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "开始时间:";
            // 
            // Dt_TimeBegin
            // 
            this.Dt_TimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dt_TimeBegin.Location = new System.Drawing.Point(261, 24);
            this.Dt_TimeBegin.Name = "Dt_TimeBegin";
            this.Dt_TimeBegin.ShowUpDown = true;
            this.Dt_TimeBegin.Size = new System.Drawing.Size(75, 21);
            this.Dt_TimeBegin.TabIndex = 34;
            // 
            // Dt_DateBegin
            // 
            this.Dt_DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dt_DateBegin.Location = new System.Drawing.Point(170, 24);
            this.Dt_DateBegin.Name = "Dt_DateBegin";
            this.Dt_DateBegin.Size = new System.Drawing.Size(87, 21);
            this.Dt_DateBegin.TabIndex = 33;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 80;
            // 
            // Work
            // 
            this.Work.DataPropertyName = "Work";
            this.Work.HeaderText = "操作方式";
            this.Work.Name = "Work";
            this.Work.ReadOnly = true;
            this.Work.Width = 180;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "操作人员";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // InTime
            // 
            this.InTime.DataPropertyName = "InTime";
            this.InTime.HeaderText = "开始时间";
            this.InTime.Name = "InTime";
            this.InTime.ReadOnly = true;
            this.InTime.Width = 130;
            // 
            // OutTime
            // 
            this.OutTime.DataPropertyName = "OutTime";
            this.OutTime.HeaderText = "结束时间";
            this.OutTime.Name = "OutTime";
            this.OutTime.ReadOnly = true;
            this.OutTime.Width = 130;
            // 
            // Mylog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 454);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Mylog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作日志";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mylog_FormClosed);
            this.Load += new System.EventHandler(this.Mylog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.DataGridView.MyDataGridView gv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Search;
        private System.Windows.Forms.ToolStripButton Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_UsedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dt_TimeEnd;
        private System.Windows.Forms.DateTimePicker Dt_DateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dt_TimeBegin;
        private System.Windows.Forms.DateTimePicker Dt_DateBegin;
        private System.Windows.Forms.ToolStripButton Btn_Export;
        private System.Windows.Forms.ToolStripButton Btn_Fresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;

    }
}