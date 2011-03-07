namespace CarsMaintenance.OrderManagement
{
    partial class CreateScrapOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCode = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this._operationsPanel = new System.Windows.Forms.Panel();
            this._cancelButton = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbSystemUser = new System.Windows.Forms.ComboBox();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.dtScrapDate = new System.Windows.Forms.DateTimePicker();
            this.lblScrapDate = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrescrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepairingQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapReason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsAbnormal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbJob = new System.Windows.Forms.GroupBox();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.cbJobPosition = new System.Windows.Forms.ComboBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.lblJobType = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtHatch = new System.Windows.Forms.TextBox();
            this.lblHatch = new System.Windows.Forms.Label();
            this.txtShip = new System.Windows.Forms.TextBox();
            this.lblShip = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.txtBerth = new System.Windows.Forms.TextBox();
            this.lblBerth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this._operationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.gbJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(23, 7);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 12);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "报废单号";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(561, 3);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 33);
            this._saveButton.TabIndex = 0;
            this._saveButton.Text = "保存";
            this._saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Enabled = false;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(91, 33);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(200, 20);
            this.cbCustomer.TabIndex = 16;
            this.cbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomer_Validating);
            // 
            // _operationsPanel
            // 
            this._operationsPanel.Controls.Add(this._saveButton);
            this._operationsPanel.Controls.Add(this._cancelButton);
            this._operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._operationsPanel.Location = new System.Drawing.Point(0, 411);
            this._operationsPanel.Name = "_operationsPanel";
            this._operationsPanel.Size = new System.Drawing.Size(883, 39);
            this._operationsPanel.TabIndex = 20;
            // 
            // _cancelButton
            // 
            this._cancelButton.CausesValidation = false;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(642, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 33);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "取消";
            this._cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(23, 35);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(41, 12);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.Text = "装卸组";
            // 
            // cbSystemUser
            // 
            this.cbSystemUser.FormattingEnabled = true;
            this.cbSystemUser.Location = new System.Drawing.Point(414, 32);
            this.cbSystemUser.Name = "cbSystemUser";
            this.cbSystemUser.Size = new System.Drawing.Size(200, 20);
            this.cbSystemUser.TabIndex = 18;
            this.cbSystemUser.Validating += new System.ComponentModel.CancelEventHandler(this.cbSystemUser_Validating);
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.AutoSize = true;
            this.lblSystemUser.Location = new System.Drawing.Point(346, 36);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(41, 12);
            this.lblSystemUser.TabIndex = 17;
            this.lblSystemUser.Text = "收发工";
            // 
            // dtScrapDate
            // 
            this.dtScrapDate.Location = new System.Drawing.Point(414, 4);
            this.dtScrapDate.Name = "dtScrapDate";
            this.dtScrapDate.Size = new System.Drawing.Size(200, 21);
            this.dtScrapDate.TabIndex = 14;
            // 
            // lblScrapDate
            // 
            this.lblScrapDate.AutoSize = true;
            this.lblScrapDate.Location = new System.Drawing.Point(346, 10);
            this.lblScrapDate.Name = "lblScrapDate";
            this.lblScrapDate.Size = new System.Drawing.Size(29, 12);
            this.lblScrapDate.TabIndex = 13;
            this.lblScrapDate.Text = "日期";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(91, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 21);
            this.txtCode.TabIndex = 12;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AllowUserToOrderColumns = true;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemCode,
            this.PrescrapQuantity,
            this.ItemName,
            this.ItemDimensions,
            this.Quantity,
            this.RepairingQuantity,
            this.ScrapQuantity,
            this.ScrapReason,
            this.IsAbnormal});
            this.dataGridViewDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewDetail.Location = new System.Drawing.Point(25, 227);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(833, 181);
            this.dataGridViewDetail.TabIndex = 19;
            this.dataGridViewDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDetail_CellValidating);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "工属具编码";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 90;
            // 
            // PrescrapQuantity
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.PrescrapQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrescrapQuantity.HeaderText = "预报废数量";
            this.PrescrapQuantity.Name = "PrescrapQuantity";
            this.PrescrapQuantity.ReadOnly = true;
            this.PrescrapQuantity.Width = 90;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 90;
            // 
            // ItemDimensions
            // 
            this.ItemDimensions.HeaderText = "规格";
            this.ItemDimensions.Name = "ItemDimensions";
            this.ItemDimensions.ReadOnly = true;
            this.ItemDimensions.Width = 90;
            // 
            // Quantity
            // 
            dataGridViewCellStyle6.Format = "N0";
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quantity.HeaderText = "归还数";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 72;
            // 
            // RepairingQuantity
            // 
            dataGridViewCellStyle7.Format = "N0";
            this.RepairingQuantity.DefaultCellStyle = dataGridViewCellStyle7;
            this.RepairingQuantity.HeaderText = "修理数";
            this.RepairingQuantity.Name = "RepairingQuantity";
            this.RepairingQuantity.Width = 96;
            // 
            // ScrapQuantity
            // 
            dataGridViewCellStyle8.Format = "N0";
            this.ScrapQuantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.ScrapQuantity.HeaderText = "报废数";
            this.ScrapQuantity.Name = "ScrapQuantity";
            this.ScrapQuantity.Width = 72;
            // 
            // ScrapReason
            // 
            this.ScrapReason.HeaderText = "报废原因";
            this.ScrapReason.Name = "ScrapReason";
            this.ScrapReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScrapReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IsAbnormal
            // 
            this.IsAbnormal.HeaderText = "异损";
            this.IsAbnormal.Name = "IsAbnormal";
            this.IsAbnormal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAbnormal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbJob
            // 
            this.gbJob.Controls.Add(this.cbJobType);
            this.gbJob.Controls.Add(this.cbJobPosition);
            this.gbJob.Controls.Add(this.txtProcess);
            this.gbJob.Controls.Add(this.lblJobType);
            this.gbJob.Controls.Add(this.lblProcess);
            this.gbJob.Controls.Add(this.lblJobPosition);
            this.gbJob.Controls.Add(this.txtQuantity);
            this.gbJob.Controls.Add(this.lblQuantity);
            this.gbJob.Controls.Add(this.txtCargo);
            this.gbJob.Controls.Add(this.lblCargo);
            this.gbJob.Controls.Add(this.txtHatch);
            this.gbJob.Controls.Add(this.lblHatch);
            this.gbJob.Controls.Add(this.txtShip);
            this.gbJob.Controls.Add(this.lblShip);
            this.gbJob.Controls.Add(this.txtMachine);
            this.gbJob.Controls.Add(this.lblMachine);
            this.gbJob.Controls.Add(this.txtBerth);
            this.gbJob.Controls.Add(this.lblBerth);
            this.gbJob.Location = new System.Drawing.Point(25, 59);
            this.gbJob.Name = "gbJob";
            this.gbJob.Size = new System.Drawing.Size(634, 155);
            this.gbJob.TabIndex = 21;
            this.gbJob.TabStop = false;
            this.gbJob.Text = "作业信息";
            // 
            // cbJobType
            // 
            this.cbJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Location = new System.Drawing.Point(403, 20);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(200, 20);
            this.cbJobType.TabIndex = 3;
            // 
            // cbJobPosition
            // 
            this.cbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobPosition.FormattingEnabled = true;
            this.cbJobPosition.Location = new System.Drawing.Point(79, 18);
            this.cbJobPosition.Name = "cbJobPosition";
            this.cbJobPosition.Size = new System.Drawing.Size(200, 20);
            this.cbJobPosition.TabIndex = 1;
            // 
            // txtProcess
            // 
            this.txtProcess.Enabled = false;
            this.txtProcess.Location = new System.Drawing.Point(79, 126);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(200, 21);
            this.txtProcess.TabIndex = 17;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Location = new System.Drawing.Point(334, 23);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(29, 12);
            this.lblJobType.TabIndex = 2;
            this.lblJobType.Text = "类型";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(11, 129);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(53, 12);
            this.lblProcess.TabIndex = 16;
            this.lblProcess.Text = "操作过程";
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Location = new System.Drawing.Point(11, 20);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(53, 12);
            this.lblJobPosition.TabIndex = 0;
            this.lblJobPosition.Text = "作业位置";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(402, 102);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 21);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(334, 105);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(29, 12);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "数量";
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(79, 99);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 21);
            this.txtCargo.TabIndex = 13;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(11, 102);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(29, 12);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "货种";
            // 
            // txtHatch
            // 
            this.txtHatch.Enabled = false;
            this.txtHatch.Location = new System.Drawing.Point(402, 75);
            this.txtHatch.Name = "txtHatch";
            this.txtHatch.Size = new System.Drawing.Size(200, 21);
            this.txtHatch.TabIndex = 11;
            // 
            // lblHatch
            // 
            this.lblHatch.AutoSize = true;
            this.lblHatch.Location = new System.Drawing.Point(334, 78);
            this.lblHatch.Name = "lblHatch";
            this.lblHatch.Size = new System.Drawing.Size(29, 12);
            this.lblHatch.TabIndex = 10;
            this.lblHatch.Text = "舱口";
            // 
            // txtShip
            // 
            this.txtShip.Enabled = false;
            this.txtShip.Location = new System.Drawing.Point(79, 72);
            this.txtShip.Name = "txtShip";
            this.txtShip.Size = new System.Drawing.Size(200, 21);
            this.txtShip.TabIndex = 9;
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Location = new System.Drawing.Point(11, 75);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(29, 12);
            this.lblShip.TabIndex = 8;
            this.lblShip.Text = "船名";
            // 
            // txtMachine
            // 
            this.txtMachine.Enabled = false;
            this.txtMachine.Location = new System.Drawing.Point(402, 48);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(200, 21);
            this.txtMachine.TabIndex = 7;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(334, 51);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(53, 12);
            this.lblMachine.TabIndex = 6;
            this.lblMachine.Text = "使用机械";
            // 
            // txtBerth
            // 
            this.txtBerth.Enabled = false;
            this.txtBerth.Location = new System.Drawing.Point(79, 45);
            this.txtBerth.Name = "txtBerth";
            this.txtBerth.Size = new System.Drawing.Size(200, 21);
            this.txtBerth.TabIndex = 5;
            // 
            // lblBerth
            // 
            this.lblBerth.AutoSize = true;
            this.lblBerth.Location = new System.Drawing.Point(11, 48);
            this.lblBerth.Name = "lblBerth";
            this.lblBerth.Size = new System.Drawing.Size(53, 12);
            this.lblBerth.TabIndex = 4;
            this.lblBerth.Text = "码头泊位";
            // 
            // CreateScrapOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.gbJob);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this._operationsPanel);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbSystemUser);
            this.Controls.Add(this.lblSystemUser);
            this.Controls.Add(this.dtScrapDate);
            this.Controls.Add(this.lblScrapDate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dataGridViewDetail);
            this.Name = "CreateScrapOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报废单管理";
            this.Load += new System.EventHandler(this.CreateScrapOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this._operationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.gbJob.ResumeLayout(false);
            this.gbJob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Panel _operationsPanel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbSystemUser;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.DateTimePicker dtScrapDate;
        private System.Windows.Forms.Label lblScrapDate;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescrapQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairingQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScrapReason;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAbnormal;
        private System.Windows.Forms.GroupBox gbJob;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.ComboBox cbJobPosition;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtHatch;
        private System.Windows.Forms.Label lblHatch;
        private System.Windows.Forms.TextBox txtShip;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.TextBox txtBerth;
        private System.Windows.Forms.Label lblBerth;
    }
}