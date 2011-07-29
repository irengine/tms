using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarsMaintenance.Common;
using System.Data;
using TMS.Model;
using System.Windows.Forms;

namespace CarsMaintenance.OrderManagement
{
    public class ExcelImport
    {
        public static void ImportVechicle()
        {
            /*
             * 编号   Job
             * 驳船
             * 货名   Cargo
             * 操作过程     Process
             * 使用机械     Machine
             * 装卸队组
             * 船名   Ship
             * 工班
             */

            // Check file name
            String excelName = ExcelHelper.GetFile();

            if ("" == excelName)
                return;

            DataTable dt = ExcelHelper.ImportWorkSheet(excelName, true);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String code = dt.Rows[i][0].ToString();

                Console.Write(code);

                // Any row should include code
                if (String.IsNullOrEmpty(code))
                    continue;

                Job job = SystemHelper.TMSContext.Jobs.FirstOrDefault(s => s.JobCode == code);
                if (null == job)
                {
                    job = SystemHelper.TMSContext.CreateObject<Job>();
                    job.JobCode = code;
                    SystemHelper.TMSContext.AddToJobs(job);
                }
                job.Cargo = dt.Rows[i]["货名"].ToString();
                job.Process = dt.Rows[i]["操作过程"].ToString();
                job.Machine = dt.Rows[i]["使用机械"].ToString();
                job.Ship = dt.Rows[i]["船名"].ToString();
                SystemHelper.TMSContext.SaveChanges();

                Console.WriteLine("-");
            }

            MessageBox.Show(excelName + "导入成功");
        }

        public static void ImportShip()
        {
            /*
             * 编号   Job
             * 泊位   Berth
             * 船名   Ship
             * 舱口   Hatch
             * 货名   Cargo
             * 操作过程     Process
             * 工班
             * 航次
             * 靠泊时间
             * 使用机械     Machine
             * 装卸队组
             */

            // Check file name
            String excelName = ExcelHelper.GetFile();

            if ("" == excelName)
                return;

            DataTable dt = ExcelHelper.ImportWorkSheet(excelName, true);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String code = dt.Rows[i][0].ToString();

                // Any row should include code
                if (String.IsNullOrEmpty(code))
                    continue;

                Job job = SystemHelper.TMSContext.Jobs.FirstOrDefault(s => s.JobCode == code);
                if (null == job)
                {
                    job = SystemHelper.TMSContext.CreateObject<Job>();
                    job.JobCode = code;
                    SystemHelper.TMSContext.AddToJobs(job);
                }
                job.Berth = dt.Rows[i]["泊位"].ToString();
                job.Ship = dt.Rows[i]["船名"].ToString();
                job.Hatch = dt.Rows[i]["舱口"].ToString();
                job.Cargo = dt.Rows[i]["货名"].ToString();
                job.Process = dt.Rows[i]["操作过程"].ToString();
                job.Machine = dt.Rows[i]["使用机械"].ToString();
                SystemHelper.TMSContext.SaveChanges();
            }

            MessageBox.Show(excelName + "导入成功");
        }
    }
}
