using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Common.Logging;
using System.Data;

namespace CarsMaintenance.Common
{
	public delegate void ExecuteActionDelegate();

	public static class ExecuteActionHelper
	{
        private static ILog log = LogManager.GetCurrentClassLogger();

		public static void ExecuteAction(ExecuteActionDelegate action)
		{
			try
			{
				if (action == null)
				{
					return;
				}
				action.Invoke();
			}
            catch (OptimisticConcurrencyException oce)
            {
                log.Error(oce);
                MessageBox.Show("数据已被其它客户端更改，请重新进入!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
			catch (Exception exception)
			{
                log.Error(exception);
				MessageBox.Show("程序异常中止，请与开发人员联系!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
	}
}
