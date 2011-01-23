﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.OrderManagement
{
    public partial class ViewOutboundOrderForm : BaseForm
    {
        #region Role
        protected override void RoleToSystmeManage()
        {
            for (int i = 0; i < contextMenuStripOutboundOrder.Items.Count; i++)
            {
                contextMenuStripOutboundOrder.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolsManage()
        {
            for (int i = 0; i < contextMenuStripOutboundOrder.Items.Count; i++)
            {
                contextMenuStripOutboundOrder.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolArticleManage()
        {
            for (int i = 0; i < contextMenuStripOutboundOrder.Items.Count; i++)
            {
                contextMenuStripOutboundOrder.Items[i].Enabled = true;
            }

        }
        protected override void RoleToToolsOutOrInUser()
        {
            for (int i = 0; i < contextMenuStripOutboundOrder.Items.Count; i++)
            {
                contextMenuStripOutboundOrder.Items[i].Enabled = true;
            }
        }
        protected override void RoleToToolsConservator()
        {
            for (int i = 0; i < contextMenuStripOutboundOrder.Items.Count; i++)
            {
                contextMenuStripOutboundOrder.Items[i].Enabled = true;
            }
        }
        #endregion
        public ViewOutboundOrderForm()
        {
            InitializeComponent();
        }

        protected void LoadData()
        {
            var query = from o in SystemHelper.TMSContext.OutboundOrders
                        orderby o.OutboundDate
                        select o;

            CarsMaintenance.Common.Sorting.SortableBindingList<object> outboundOrders = new CarsMaintenance.Common.Sorting.SortableBindingList<object>();
            foreach (object o in query)
            {
                outboundOrders.Add(o);
            }

            dataGridViewOutboundOrder.DataSource = outboundOrders;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private OutboundOrder GetSelectedOrder()
        {
            if (dataGridViewOutboundOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择借用单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
            int id;
            if (!int.TryParse(Convert.ToString(dataGridViewOutboundOrder.SelectedRows[0].Cells[0].Value), out id))
            {
                MessageBox.Show("请重新选择借用单!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }

            return SystemHelper.TMSContext.OutboundOrders.First(u => u.OutboundOrderID == id);
        }

        private void Create()
        {
            using (CreateOutboundOrderForm form = new CreateOutboundOrderForm())
            {
                form.CurrentOrder = new OutboundOrder();
                form.CurrentMode = CreateOutboundOrderForm.MODE_CREATE;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void Browse()
        {
            using (CreateOutboundOrderForm form = new CreateOutboundOrderForm())
            {
                form.CurrentOrder = GetSelectedOrder();
                form.CurrentMode = CreateOutboundOrderForm.MODE_BROWSE;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void Append()
        {
            using (CreateOutboundOrderForm form = new CreateOutboundOrderForm())
            {
                form.CurrentOrder = GetSelectedOrder();
                form.CurrentMode = CreateOutboundOrderForm.MODE_APPEND;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void Return()
        {
            using (CreateInboundOrderForm form = new CreateInboundOrderForm())
            {
                form.CurrentOrder = new InboundOrder();
                form.ReferenceOrder = GetSelectedOrder();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    SystemHelper.RefreshOrder(form.CurrentOrder);
                }
            }
        }

        private void toolStripMenuItemCreateOutboundOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Create);
        }

        private void toolStripMenuItemAppendOutboundOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Append);
        }

        private void toolStripMenuItemReturnOutboundOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Return);
        }

        private void toolStripMenuItemBrowseOutboundOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Browse);
        }

        private void dataGridViewOutboundOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Browse);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime beginDate = dtBeginDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date.AddDays(1);
            var query = from o in SystemHelper.TMSContext.OutboundOrders
                        where o.OutboundDate >= beginDate && o.OutboundDate <= endDate
                        orderby o.OutboundDate
                        select o;

            dataGridViewOutboundOrder.DataSource = query;
        }

        private void toolStripMenuItemPrintOutboundOrder_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(delegate()
            {
                FormsManager.OpenForm(typeof(CarsMaintenance.Reports.OutboundOrderReport), new object[] {"ID", GetSelectedOrder().OutboundOrderID});
            });
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ExecuteActionHelper.ExecuteAction(Create);
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            string ship = txtShip.Text;
            string machine = txtMachine.Text;
            string cargo = txtCargo.Text;

            var query = from o in SystemHelper.TMSContext.OutboundOrders
                        where o.Ship.StartsWith(ship) && o.Machine.StartsWith(machine) && o.Cargo.StartsWith(cargo)
                        orderby o.OutboundDate
                        select o;

            dataGridViewOutboundOrder.DataSource = query;
        }
    }
}
