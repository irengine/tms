﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using CarsMaintenance.Common.Validation;
using TMS.Model;

namespace CarsMaintenance.OrderManagement
{
    public partial class CreateScrapOrderForm : Form
    {
        //public OutboundOrder ReferenceOrder { get; set; }
        public ScrapOrder CurrentOrder { get; set; }
        public string CurrentMode { get; set; }

        public static string MODE_BROWSE = "BROWSE";
        public static string MODE_CREATE = "CREATE";
        public static string MODE_CREATESELF = "CREATESELF";

        public CreateScrapOrderForm()
        {
            InitializeComponent();
            RegisterControlsForValidation();
        }

        public CreateScrapOrderForm(string Mode)
        {
            CurrentMode = Mode;
            InitializeComponent();
            SetControls();
            RegisterControlsForValidation();
        }

        private void SetControls()
        {
            if (CurrentMode == MODE_CREATESELF)
            {
                dataGridViewDetail.AllowUserToAddRows = true;
                dataGridViewDetail.AllowUserToDeleteRows = true;

                dataGridViewDetail.Columns[1].ReadOnly = false;
                dataGridViewDetail.Columns[2].Visible = false;
                dataGridViewDetail.Columns[5].Visible = false;
                dataGridViewDetail.Columns[6].Visible = false;
            }
        }

        private ValidationManager _validationManager;

        private void RegisterControlsForValidation()
        {
            _validationManager = new ValidationManager()
            {
                Provider = _errorProvider
            };
            // Do not validate code because of auto generation
            //_validationManager.Validators.Add(new RequiredValidator()
            //{
            //    Control = txtCode,
            //    ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblCode.Text)
            //});
            // Customer can be null when create self scrap order
            //_validationManager.Validators.Add(new RequiredValidator()
            //{
            //    Control = cbCustomer,
            //    ErrorMessage = string.Format(CarsMaintenance.Properties.Resources.RequiredErrorMessage, lblCustomer.Text)
            //});
        }

        private void LoadData()
        {
            SystemHelper.BindComboxToCustomer(cbCustomer);
            SystemHelper.BindComboxToSystemUser(cbSystemUser);
            SystemHelper.BindComboxToJobPosition(cbJobPosition);
            SystemHelper.BindComboxToJobType(cbJobType);
            SystemHelper.BindComboBoxToScrapReason(dataGridViewDetail.Columns["ScrapReason"] as DataGridViewComboBoxColumn);

            // Set data object value
            if (CurrentOrder == null)
            {
                CurrentOrder = new ScrapOrder();
                CurrentMode = MODE_CREATESELF;
            }

            if (CurrentMode == MODE_CREATESELF)
            {
                CurrentOrder.Status = 1;
                CurrentOrder.SystemUser = SystemHelper.CurrentUser;
            }

            txtCode.Text = CurrentOrder.Code;
            dtScrapDate.Value = CurrentOrder.ScrapDate;

            cbCustomer.SelectedItem = CurrentOrder.Customer;
            cbSystemUser.SelectedItem = CurrentOrder.SystemUser;

            // show outbound order information
            if (CurrentOrder.OutboundOrder != null)
            {
                cbJobPosition.Text = CurrentOrder.OutboundOrder.JobPosition;
                cbJobType.Text = CurrentOrder.OutboundOrder.JobType;
                txtBerth.Text = CurrentOrder.OutboundOrder.Berth;
                txtMachine.Text = CurrentOrder.OutboundOrder.Machine;
                txtShip.Text = CurrentOrder.OutboundOrder.Ship;
                txtHatch.Text = CurrentOrder.OutboundOrder.Hatch;
                txtCargo.Text = CurrentOrder.OutboundOrder.Cargo;
                txtQuantity.Text = CurrentOrder.OutboundOrder.Quantity;
                txtProcess.Text = CurrentOrder.OutboundOrder.Process;
            }

            foreach (ScrapOrderDetail item in CurrentOrder.Items)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                object[] row = { item.ScrapOrderDetailID, item.Tool.Code, item.PrescrapQuantity, item.Tool.Name, item.Tool.Dimensions, item.Quantity, item.RepairingQuantity, item.ScrapQuantity, item.ScrapReason, item.IsAbnormal };
                dataGridViewDetail.Rows.Add(row);
            }
        }

        private void EnableForm()
        {
            if (CurrentMode == MODE_BROWSE)
                _saveButton.Enabled = false;
        }

        private void CreateScrapOrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableForm();
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                if (!_validationManager.Validate())
                {
                    return;
                }

                CurrentOrder.Code = txtCode.Text;
                CurrentOrder.ScrapDate = dtScrapDate.Value;

                CurrentOrder.Customer = cbCustomer.SelectedItem as Unit;
                CurrentOrder.SystemUser = cbSystemUser.SelectedItem as SystemUser;

                if (CurrentOrder.EntityKey == null)
                    SystemHelper.TMSContext.AddToScrapOrders(CurrentOrder);

                //CurrentOrder.SystemUser = SystemHelper.CurrentUser;
                CurrentOrder.LastUpdateTime = System.DateTime.Now;

                RepairOrder repairOrder = new RepairOrder();

                // Iterate all rows
                foreach (DataGridViewRow dgvr in dataGridViewDetail.Rows)
                {
                    if (!dgvr.IsNewRow)
                    {
                        // for scrap detail
                        string code = dgvr.Cells["ItemCode"].Value.ToString();
                        Tool t = SystemHelper.FindToolByCode(code);

                        decimal scrapQuantity = 0;
                        decimal.TryParse(dgvr.Cells["ScrapQuantity"].Value.ToString(), out scrapQuantity);

                        ScrapOrderDetail item;

                        if (dgvr.Cells["ItemID"].Value == null)
                        {
                            item = SystemHelper.TMSContext.ScrapOrderDetails.CreateObject();
                            item.Tool = t;
                            item.UnitPrice = t.ToolInventory.UnitPrice;
                            item.ScrapQuantity = scrapQuantity;
                            item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;
                            item.ScrapDate = CurrentOrder.LastUpdateTime;
                            //item.IsAbnormal = (bool)dgvr.Cells["IsAbnormal"].Value;
                            item.IsAbnormal = null == dgvr.Cells["IsAbnormal"].Value ? false : (bool)dgvr.Cells["IsAbnormal"].Value;

                            CurrentOrder.Items.Add(item);
                        }
                        else
                        {
                            if (!(ValidateRow(dgvr.Index)))
                                return;

                            decimal quantity = 0;
                            if (dgvr.Cells["Quantity"].Value != null)
                                decimal.TryParse(dgvr.Cells["Quantity"].Value.ToString(), out quantity);

                            decimal prescrapQuantity = 0;
                            if (dgvr.Cells["PrescrapQuantity"].Value != null)
                                decimal.TryParse(dgvr.Cells["PrescrapQuantity"].Value.ToString(), out prescrapQuantity);

                            decimal repairingQuantity = 0;
                            if (dgvr.Cells["RepairingQuantity"].Value != null)
                                decimal.TryParse(dgvr.Cells["RepairingQuantity"].Value.ToString(), out repairingQuantity); 
                            
                            int itemID = 0;
                            int.TryParse(dgvr.Cells["ItemID"].Value.ToString(), out itemID);
                            item = SystemHelper.TMSContext.ScrapOrderDetails.FirstOrDefault(s => s.ScrapOrderDetailID == itemID);
                            item.PrescrapQuantity = prescrapQuantity;
                            item.ScrapQuantity = scrapQuantity;
                            item.Quantity = quantity;
                            item.RepairingQuantity = repairingQuantity;
                            item.ScrapReason = dgvr.Cells["ScrapReason"].Value as string;
                            item.ScrapDate = CurrentOrder.LastUpdateTime;
                            //item.IsAbnormal = (bool)dgvr.Cells["IsAbnormal"].Value;
                            item.IsAbnormal = null == dgvr.Cells["IsAbnormal"].Value ? false : (bool)dgvr.Cells["IsAbnormal"].Value;
                        }

                        // for inventory and inventory history
                        OrderManager.Scrap(CurrentOrder, item);

                        // for prescrap order
                        if (item.RepairingQuantity != 0)
                        {
                            RepairOrderDetail repairItem = new RepairOrderDetail();
                            repairItem.Tool = item.Tool;
                            repairItem.OutboundOrderDetail = item.OutboundOrderDetail;
                            repairItem.RepairDate = item.ScrapDate;
                            repairItem.RepairingQuantity = item.RepairingQuantity;
                            repairItem.UnitPrice = item.UnitPrice;

                            repairOrder.Items.Add(repairItem);
                        }
                    }
                }

                if (repairOrder.Items.Count > 0)
                {
                    repairOrder.OutboundOrder = CurrentOrder.OutboundOrder;
                    repairOrder.RepairDate = CurrentOrder.ScrapDate;
                    repairOrder.Customer = CurrentOrder.Customer;
                    repairOrder.SystemUser = CurrentOrder.SystemUser;
                    repairOrder.LastUpdateTime = CurrentOrder.LastUpdateTime;
                    SystemHelper.TMSContext.AddToRepairOrders(repairOrder);
                }

                CurrentOrder.Status = 1;

                SystemHelper.TMSContext.SaveChanges();

                DialogResult = DialogResult.OK;
            });
        }

        private void dataGridViewDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue == null || e.FormattedValue.ToString().Length == 0)
                return;

            switch (e.ColumnIndex)
            {
                case 1:
                    string code = e.FormattedValue.ToString();
                    Tool t = SystemHelper.FindToolByCode(code);
                    if (t == null)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ItemName"].Value = t.Name;
                        dataGridViewDetail.Rows[e.RowIndex].Cells["ItemDimensions"].Value = t.Dimensions;
                    }
                    break;
                case 5:
                case 6:
                case 7:
                    //decimal quantity = 0;
                    //if (!decimal.TryParse(e.FormattedValue.ToString(), out quantity))
                    //    e.Cancel = true;
                    e.Cancel = !SystemHelper.IsInteger(e.FormattedValue);
                    break;

            }
        }

        private void cbCustomer_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForCustomer(cbCustomer);
        }

        private void cbSystemUser_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !SystemHelper.ValidateComboxForSystemUser(cbSystemUser);
        }

        private bool ValidateRow(int row)
        {
            decimal quantity = SystemHelper.ConvertToNumber(dataGridViewDetail.Rows[row].Cells["Quantity"].Value);

            decimal prescrapQuantity = SystemHelper.ConvertToNumber(dataGridViewDetail.Rows[row].Cells["PrescrapQuantity"].Value);

            decimal repairingQuantity = SystemHelper.ConvertToNumber(dataGridViewDetail.Rows[row].Cells["RepairingQuantity"].Value);

            decimal scrapQuantity = SystemHelper.ConvertToNumber(dataGridViewDetail.Rows[row].Cells["ScrapQuantity"].Value);

            if (prescrapQuantity != (quantity + repairingQuantity + scrapQuantity))
            {
                dataGridViewDetail.Rows[row].ErrorText = "归还数、修理数和报废数之和必须等于未归还数.";
                return false;
            }
            else
            {
                dataGridViewDetail.Rows[row].ErrorText = "";
                return true;
            }
        }
    }
}
