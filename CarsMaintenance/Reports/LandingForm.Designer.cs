namespace CarsMaintenance.Reports
{
    partial class LandingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Currently_Time = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvSummary = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.Lb_Date = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.line3 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.gbIO = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblDay2Scrap = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblYearScrap = new System.Windows.Forms.Label();
            this.lblYearOut = new System.Windows.Forms.Label();
            this.lblMonthScrap = new System.Windows.Forms.Label();
            this.lblMonthOut = new System.Windows.Forms.Label();
            this.lblDay2Out = new System.Windows.Forms.Label();
            this.lblDay1Scrap = new System.Windows.Forms.Label();
            this.lblDay1Out = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.gbIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // Currently_Time
            // 
            this.Currently_Time.Enabled = true;
            this.Currently_Time.Interval = 1000;
            this.Currently_Time.Tick += new System.EventHandler(this.Currently_Time_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbMessage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbIO, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.gvSummary);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(895, 170);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "工属具统计情况";
            // 
            // gvSummary
            // 
            this.gvSummary.AllowUserToAddRows = false;
            this.gvSummary.AllowUserToDeleteRows = false;
            this.gvSummary.AllowUserToResizeColumns = false;
            this.gvSummary.AllowUserToResizeRows = false;
            this.gvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSummary.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSummary.Enabled = false;
            this.gvSummary.EnableHeadersVisualStyles = false;
            this.gvSummary.Location = new System.Drawing.Point(3, 17);
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.ReadOnly = true;
            this.gvSummary.RowHeadersVisible = false;
            this.gvSummary.RowTemplate.Height = 23;
            this.gvSummary.Size = new System.Drawing.Size(889, 150);
            this.gvSummary.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.Lb_Time);
            this.groupBox2.Controls.Add(this.Lb_Date);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(512, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "工属具使用情况";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(523, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 14);
            this.label16.TabIndex = 6;
            this.label16.Text = "工属具管理应用系统";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(425, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(315, 14);
            this.label15.TabIndex = 5;
            this.label15.Text = "上港国际港务（集团）股份有限公司军工路分公司";
            // 
            // Lb_Time
            // 
            this.Lb_Time.AutoSize = true;
            this.Lb_Time.Location = new System.Drawing.Point(226, 92);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(0, 12);
            this.Lb_Time.TabIndex = 4;
            // 
            // Lb_Date
            // 
            this.Lb_Date.AutoSize = true;
            this.Lb_Date.Location = new System.Drawing.Point(130, 92);
            this.Lb_Date.Name = "Lb_Date";
            this.Lb_Date.Size = new System.Drawing.Size(0, 12);
            this.Lb_Date.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(201, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "[";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "现在是：北京时间";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblRoles);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(453, 419);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "今日当班";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "岗位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "姓名";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(172, 53);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(47, 12);
            this.lblRoles.TabIndex = 1;
            this.lblRoles.Text = "label10";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(46, 53);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label10";
            // 
            // gbMessage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbMessage, 2);
            this.gbMessage.Controls.Add(this.line3);
            this.gbMessage.Controls.Add(this.line2);
            this.gbMessage.Controls.Add(this.line1);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessage.Location = new System.Drawing.Point(3, 123);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(895, 114);
            this.gbMessage.TabIndex = 0;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "公告栏";
            // 
            // line3
            // 
            this.line3.AutoSize = true;
            this.line3.Location = new System.Drawing.Point(29, 81);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(35, 12);
            this.line3.TabIndex = 2;
            this.line3.Text = "line3";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(29, 56);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(35, 12);
            this.line2.TabIndex = 1;
            this.line2.Text = "line2";
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(29, 30);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(35, 12);
            this.line1.TabIndex = 0;
            this.line1.Text = "line1";
            // 
            // gbIO
            // 
            this.gbIO.Controls.Add(this.label34);
            this.gbIO.Controls.Add(this.lblDay2Scrap);
            this.gbIO.Controls.Add(this.label33);
            this.gbIO.Controls.Add(this.label32);
            this.gbIO.Controls.Add(this.label31);
            this.gbIO.Controls.Add(this.label30);
            this.gbIO.Controls.Add(this.label29);
            this.gbIO.Controls.Add(this.label28);
            this.gbIO.Controls.Add(this.label25);
            this.gbIO.Controls.Add(this.lblYearScrap);
            this.gbIO.Controls.Add(this.lblYearOut);
            this.gbIO.Controls.Add(this.lblMonthScrap);
            this.gbIO.Controls.Add(this.lblMonthOut);
            this.gbIO.Controls.Add(this.lblDay2Out);
            this.gbIO.Controls.Add(this.lblDay1Scrap);
            this.gbIO.Controls.Add(this.lblDay1Out);
            this.gbIO.Controls.Add(this.label9);
            this.gbIO.Controls.Add(this.label8);
            this.gbIO.Controls.Add(this.label7);
            this.gbIO.Controls.Add(this.label3);
            this.gbIO.Controls.Add(this.label2);
            this.gbIO.Controls.Add(this.label1);
            this.gbIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIO.Location = new System.Drawing.Point(3, 419);
            this.gbIO.Name = "gbIO";
            this.gbIO.Size = new System.Drawing.Size(444, 230);
            this.gbIO.TabIndex = 2;
            this.gbIO.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(322, 78);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 12);
            this.label34.TabIndex = 29;
            this.label34.Text = "件";
            // 
            // lblDay2Scrap
            // 
            this.lblDay2Scrap.AutoSize = true;
            this.lblDay2Scrap.Location = new System.Drawing.Point(269, 79);
            this.lblDay2Scrap.Name = "lblDay2Scrap";
            this.lblDay2Scrap.Size = new System.Drawing.Size(47, 12);
            this.lblDay2Scrap.TabIndex = 28;
            this.lblDay2Scrap.Text = "label11";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(322, 133);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(17, 12);
            this.label33.TabIndex = 27;
            this.label33.Text = "件";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(322, 106);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(17, 12);
            this.label32.TabIndex = 26;
            this.label32.Text = "件";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(322, 52);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 25;
            this.label31.Text = "件";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(198, 133);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 12);
            this.label30.TabIndex = 24;
            this.label30.Text = "件";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(198, 106);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 12);
            this.label29.TabIndex = 23;
            this.label29.Text = "件";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(198, 79);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 12);
            this.label28.TabIndex = 22;
            this.label28.Text = "件";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(198, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 12);
            this.label25.TabIndex = 21;
            this.label25.Text = "件";
            // 
            // lblYearScrap
            // 
            this.lblYearScrap.AutoSize = true;
            this.lblYearScrap.Location = new System.Drawing.Point(269, 133);
            this.lblYearScrap.Name = "lblYearScrap";
            this.lblYearScrap.Size = new System.Drawing.Size(47, 12);
            this.lblYearScrap.TabIndex = 20;
            this.lblYearScrap.Text = "label17";
            // 
            // lblYearOut
            // 
            this.lblYearOut.AutoSize = true;
            this.lblYearOut.Location = new System.Drawing.Point(138, 133);
            this.lblYearOut.Name = "lblYearOut";
            this.lblYearOut.Size = new System.Drawing.Size(47, 12);
            this.lblYearOut.TabIndex = 19;
            this.lblYearOut.Text = "label16";
            // 
            // lblMonthScrap
            // 
            this.lblMonthScrap.AutoSize = true;
            this.lblMonthScrap.Location = new System.Drawing.Point(269, 106);
            this.lblMonthScrap.Name = "lblMonthScrap";
            this.lblMonthScrap.Size = new System.Drawing.Size(47, 12);
            this.lblMonthScrap.TabIndex = 18;
            this.lblMonthScrap.Text = "label15";
            // 
            // lblMonthOut
            // 
            this.lblMonthOut.AutoSize = true;
            this.lblMonthOut.Location = new System.Drawing.Point(138, 106);
            this.lblMonthOut.Name = "lblMonthOut";
            this.lblMonthOut.Size = new System.Drawing.Size(47, 12);
            this.lblMonthOut.TabIndex = 17;
            this.lblMonthOut.Text = "label14";
            // 
            // lblDay2Out
            // 
            this.lblDay2Out.AutoSize = true;
            this.lblDay2Out.Location = new System.Drawing.Point(138, 79);
            this.lblDay2Out.Name = "lblDay2Out";
            this.lblDay2Out.Size = new System.Drawing.Size(47, 12);
            this.lblDay2Out.TabIndex = 15;
            this.lblDay2Out.Text = "label12";
            // 
            // lblDay1Scrap
            // 
            this.lblDay1Scrap.AutoSize = true;
            this.lblDay1Scrap.Location = new System.Drawing.Point(269, 53);
            this.lblDay1Scrap.Name = "lblDay1Scrap";
            this.lblDay1Scrap.Size = new System.Drawing.Size(47, 12);
            this.lblDay1Scrap.TabIndex = 14;
            this.lblDay1Scrap.Text = "label11";
            // 
            // lblDay1Out
            // 
            this.lblDay1Out.AutoSize = true;
            this.lblDay1Out.Location = new System.Drawing.Point(138, 52);
            this.lblDay1Out.Name = "lblDay1Out";
            this.lblDay1Out.Size = new System.Drawing.Size(47, 12);
            this.lblDay1Out.TabIndex = 13;
            this.lblDay1Out.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "报废";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "借还";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "当年累计:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "当月累计:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "第二班:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "第一班:";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LandingForm";
            this.Text = "工属具使用情况";
            this.Activated += new System.EventHandler(this.LandingForm_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbIO.ResumeLayout(false);
            this.gbIO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.GroupBox gbIO;
        private System.Windows.Forms.Label lblYearScrap;
        private System.Windows.Forms.Label lblYearOut;
        private System.Windows.Forms.Label lblMonthScrap;
        private System.Windows.Forms.Label lblMonthOut;
        private System.Windows.Forms.Label lblDay2Out;
        private System.Windows.Forms.Label lblDay1Scrap;
        private System.Windows.Forms.Label lblDay1Out;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lb_Time;
        private System.Windows.Forms.Label Lb_Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer Currently_Time;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblDay2Scrap;
        private System.Windows.Forms.DataGridView gvSummary;

    }
}