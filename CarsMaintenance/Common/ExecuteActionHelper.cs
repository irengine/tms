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
                MessageBox.Show("�����ѱ������ͻ��˸��ģ������½���!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
			catch (Exception exception)
			{
                log.Error(exception);
				MessageBox.Show("�����쳣��ֹ�����뿪����Ա��ϵ!", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
		}
	}
}
