﻿using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CarsMaintenance.Common
{
    public class ExcelHelper
    {
        /// <summary>
        /// Imports worksheet from an excel file (xls, xlsx or csv). Guesses data types and picks the first worksheet found.
        /// </summary>
        /// <param name="excelFile">The excel file path.</param>
        /// <param name="hasHeaderRow">if set to <c>true</c>, the first row is a header row.</param>
        public static DataTable ImportWorkSheet(string excelFile, bool hasHeaderRow)
        {
            return ImportWorkSheet(excelFile, hasHeaderRow, false, null);
        }

        /// <summary>
        /// Imports worksheet from an excel file (xls, xlsx or csv).
        /// </summary>
        /// <param name="excelFile">The excel file path.</param>
        /// <param name="hasHeaderRow">if set to <c>true</c>, the first row is a header row.</param>
        /// <param name="allText">Indicates all columns will be treated as text strings</param>
        /// <param name="tabName">Name of the sheet (or null if unknown - uses GetSchema to derive it)</param>
        public static DataTable ImportWorkSheet(string excelFile, bool hasHeaderRow, bool allText, string tabName)
        {
            string connectionString = GetExcelConnectionString(excelFile, hasHeaderRow, allText);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                if (Path.GetExtension(excelFile).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    tabName = Path.GetFileName(excelFile);
                else
                    tabName = EnsureTableName(connection, tabName);
                string selectString = string.Format("SELECT * FROM [{0}]", tabName);

                DataTable table = new DataTable(tabName);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectString, connection))
                    adapter.Fill(table);

                return table;
            }
        }

        /// <summary>
        /// Imports all sheets from an Excel file
        /// </summary>
        /// <param name="excelFile">The excel file path.</param>
        /// <returns></returns>
        public static DataSet ImportAll(string excelFile)
        {
            DataSet ds = new DataSet();

            string connectionString = GetExcelConnectionString(excelFile, false, true);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                //csv doesn't have worksheets, and table name == file name
                if (Path.GetExtension(excelFile).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    LoadTableIntoDataSet(connection, Path.GetFileName(excelFile), ds);
                    return ds;
                }

                //xls and xlsx have worksheets, so load each one as a datatable
                DataTable worksheets = connection.GetSchema("Tables");
                foreach (DataRow row in worksheets.Rows)
                {
                    //this can also return Excel named ranges
                    string tabName = (string)row["TABLE_NAME"];
                    //so look for sheets (excel puts $ after the name and may single-quote the name)
                    if (tabName.EndsWith("$") || tabName.EndsWith("$'"))
                        LoadTableIntoDataSet(connection, tabName, ds);
                }
            }
            return ds;
        }

        private static void LoadTableIntoDataSet(OleDbConnection connection, string tabName, DataSet ds)
        {
            string selectString = string.Format("SELECT * FROM [{0}]", tabName);

            DataTable table = new DataTable(tabName);
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectString, connection))
                adapter.Fill(table);
            ds.Tables.Add(table);
        }

        private static string EnsureTableName(DbConnection connection, string tabName)
        {
            if (string.IsNullOrEmpty(tabName))
            {
                //use GetSchema to find the first sheet == table name
                DataTable worksheets = connection.GetSchema("Tables");
                foreach (DataRow row in worksheets.Rows)
                {
                    //this can also return Excel named ranges
                    tabName = (string)row["TABLE_NAME"];
                    //so look for sheets (excel puts $ after the name and may single-quote the name)
                    if (tabName.EndsWith("$") || tabName.EndsWith("$'"))
                        return tabName;
                    //otherwise we'll fall through with whatever we find
                }
            }
            //they supplied a worksheet name; ensure always has $ suffix
            else if (!tabName.EndsWith("$"))
                tabName += "$";
            return tabName;
        }

        private static string GetExcelConnectionString(string filePath, bool hasHeaderRow, bool allText)
        {
            //http://www.connectionstrings.com/?carrier=excel
            string connectionString;
            string ext = Path.GetExtension(filePath);
            if (ext.Equals(".csv", StringComparison.OrdinalIgnoreCase))
            {
                //uses directory path, not file path
                //for format definition, write a schema.ini in the folder: http://msdn.microsoft.com/en-us/library/ms709353.aspx
                connectionString = string.Format(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=""text;FMT=Delimited;{1}{2}""",
                    filePath.Remove(filePath.IndexOf(Path.GetFileName(filePath))),
                    hasHeaderRow ? "HDR=YES;" : "HDR=NO;",
                    allText ? "IMEX=1" : string.Empty);
            }
            else if (ext.Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                //if this fails, install 2007 providers from http://www.microsoft.com/downloads/details.aspx?FamilyID=7554F536-8C28-4598-9B72-EF94E038C891&displaylang=en
                connectionString = string.Format(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties=""Excel 12.0 Xml;{1}{2}""",
                    filePath,
                    hasHeaderRow ? "HDR=YES;" : "HDR=NO;",
                    allText ? "IMEX=1" : string.Empty);
            }
            else //assume normal excel
            {
                connectionString = string.Format(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=""Excel 8.0;{1}{2}""",
                    filePath,
                    hasHeaderRow ? "HDR=YES;" : "HDR=NO;",
                    allText ? "IMEX=1" : string.Empty);
            }
            return connectionString;
        }

        // Import the data from DataTable to SQL Server via SqlBulkCopy
        public static void SqlBulkCopyImport(String sqlConnectionString, String sqlTableName, DataTable dtExcel)
        {
            using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionString))
            {
                // Open the connection.
                sqlConnection.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlConnection))
                {
                    // Specify the destination table name.
                    bulkCopy.DestinationTableName = sqlTableName;

                    foreach (DataColumn dc in dtExcel.Columns)
                    {
                        // Because the number of the test Excel columns is not 
                        // equal to the number of table columns, we need to map 
                        // columns.
                        bulkCopy.ColumnMappings.Add(dc.ColumnName, dc.ColumnName);
                    }

                    // Write from the source to the destination.
                    bulkCopy.WriteToServer(dtExcel);
                }
            }
        }

        public static String GetFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel 97-2003 Files (*.xls)|*.XLS|Excel 2007 Files (*.xlsx)|*.XLSX";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }

            return "";
        }
    }
}
