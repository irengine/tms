using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarsMaintenance.Common;
using TMS.Model;

namespace CarsMaintenance.Reports
{
    public partial class LandingForm : BaseForm
    {
        public LandingForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {            
            var query = (from o in SystemHelper.TMSContext.Articles
                         orderby o.IsTop descending, o.LastUpdateTime descending
                        where !o.Deleted
                        select o).Take(3);

            this.line1.Text = "1.欢迎使用工属具管理应用系统，欢迎提供宝贵意见！";
            this.line2.Text = "";
            this.line3.Text = "";
            
            int i = 1;
            foreach (Article a in query)
            {
                if (i == 1)
                    this.line1.Text ="1."+ a.Content;
                else if (i == 2)
                    this.line2.Text = "2." + a.Content;
                else if (i == 3)
                    this.line3.Text = "3." + a.Content;

                i++;
            }

            lblUserName.Text = SystemHelper.CurrentUser.Name;

            string roleNames = "";
            string[] roleCodes = SystemHelper.CurrentUser.Roles.Split(',');
            foreach (string code in roleCodes)
            {
                SystemRole role = SystemHelper.TMSContext.SystemRoles.First(r => r.Code == code);
                roleNames += role.Name;
            }

            lblRoles.Text = roleNames;

            //lblTotal.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_RATED).Replace(".00", " ");
            //lblStock.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_STOCK).Replace(".00", " ");
            //lblOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_OUT).Replace(".00", " ");
            //lbScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_SCRAP).Replace(".00", " ");

            lblDay1Out.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY1_OUT, DateTime.Now).Replace(".00", " ");
            lblDay2Out.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY2_OUT, DateTime.Now).Replace(".00", " ");
            lblMonthOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_MONTH_OUT, DateTime.Now).Replace(".00", " ");
            lblYearOut.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_YEAR_OUT, DateTime.Now).Replace(".00", " ");

            lblDay1Scrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY1_SCRAP, DateTime.Now).Replace(".00", " ");
            lblDay2Scrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_DAY2_SCRAP, DateTime.Now).Replace(".00", " ");
            lblMonthScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_MONTH_SCRAP, DateTime.Now).Replace(".00", " ");
            lblYearScrap.Text = SQLHelper.QueryLandForm(SQLHelper.SQL_YEAR_SCRAP, DateTime.Now).Replace(".00", " ");


            // Set grid view
            DataSet ds = SQLHelper.QueryLoginFormToTools();
            this.gvSummary.Columns.Clear();
            this.gvSummary.Rows.Clear();

            int columnCount = ds.Tables[0].Rows.Count * 2 + 1;

            for (int col = 0; col < columnCount; col++)
            {
                string name = "name" + col;
                string header = col < 3 || col%2 == 0 ? " " : ds.Tables[0].Rows[(col - 3)/2]["Name"].ToString();
                this.gvSummary.Columns.Add(name, header);
            }  
            this.gvSummary.Rows.Add(4);

            // Set header value

            this.gvSummary.Columns[0].Width = 80;
            this.gvSummary.Columns[1].Width = 80;
            this.gvSummary.Columns[2].Width = 20;
            this.gvSummary.Columns[3].Width = 60;
            this.gvSummary.Columns[4].Width = 20;
            this.gvSummary.Columns[5].Width = 60;
            this.gvSummary.Columns[6].Width = 20;
            this.gvSummary.Columns[7].Width = 60;
            this.gvSummary.Columns[8].Width = 20;
            this.gvSummary.Columns[9].Width = 60;
            this.gvSummary.Columns[10].Width = 20;
            this.gvSummary.Columns[11].Width = 60;
            this.gvSummary.Columns[12].Width = 20;
            this.gvSummary.Columns[13].Width = 60;
            this.gvSummary.Columns[14].Width = 20;
            this.gvSummary.Columns[15].Width = 60;
            this.gvSummary.Columns[16].Width = 20;
            this.gvSummary.Columns[17].Width = 60;
            this.gvSummary.Columns[18].Width = 20;

            this.gvSummary.Rows[0].Cells[0].Value = "总额定数";
            this.gvSummary.Rows[1].Cells[0].Value = "总在库数";
            this.gvSummary.Rows[2].Cells[0].Value = "总外借数";
            this.gvSummary.Rows[3].Cells[0].Value = "总报废数";

            this.gvSummary.Rows[0].Cells[1].Value = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_RATED).Replace(".00", " ");
            this.gvSummary.Rows[1].Cells[1].Value = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_STOCK).Replace(".00", " ");
            this.gvSummary.Rows[2].Cells[1].Value = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_OUT).Replace(".00", " ");
            this.gvSummary.Rows[3].Cells[1].Value = SQLHelper.QueryLandForm(SQLHelper.SQL_TOTAL_SCRAP).Replace(".00", " ");

            for (int col = 2; col < columnCount; col++)
            {
                if (col%2 == 0)
                {
                    this.gvSummary.Rows[0].Cells[col].Value = "件";
                    this.gvSummary.Rows[1].Cells[col].Value = "件";
                    this.gvSummary.Rows[2].Cells[col].Value = "件";
                    this.gvSummary.Rows[3].Cells[col].Value = "件";
                }
                else
                {
                    this.gvSummary.Rows[0].Cells[col].Value = ds.Tables[0].Rows[(col - 3) / 2]["RatedQuantity"].ToString().Replace(".00", " ");
                    this.gvSummary.Rows[1].Cells[col].Value = ds.Tables[0].Rows[(col - 3) / 2]["Quantity"].ToString().Replace(".00", " ");
                    this.gvSummary.Rows[2].Cells[col].Value = ds.Tables[0].Rows[(col - 3) / 2]["OutQuantity"].ToString().Replace(".00", " ");
                    this.gvSummary.Rows[3].Cells[col].Value = ds.Tables[0].Rows[(col - 3) / 2]["ScrapQuantity"].ToString().Replace(".00", " ");
                }
            }
        }

        private void Currently_Time_Tick(object sender, EventArgs e)
        {
            this.Lb_Date.Text = System.DateTime.Now.Date.ToShortDateString();
            this.Lb_Time.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void LandingForm_Activated(object sender, EventArgs e)
        {
            //this.SuspendLayout();
            //LoadData();
            //this.ResumeLayout();
        }
    }
}
