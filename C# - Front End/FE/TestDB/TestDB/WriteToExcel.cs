using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;

namespace TestDB
{
    class WriteToExcel
    {
        public static void Excel_FromDataTable(DataTable dt)
        {
            // Create an Excel object and add workbook...
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook workbook = excel.Application.Workbooks.Add(true); // true for object template???

            // Add column headings...
            int iCol = 0;
            foreach (DataColumn c in dt.Columns)
            {
                iCol++;
                excel.Cells[1, iCol] = c.ColumnName;
            }
            // for each row of data...
            int iRow = 0;
            foreach (DataRow r in dt.Rows)
            {
                iRow++;

                // add each row's cell data...
                iCol = 0;
                foreach (DataColumn c in dt.Columns)
                {
                    iCol++;
                    excel.Cells[iRow + 1, iCol] = r[c.ColumnName];
                }
            }

            // Global missing reference for objects we are not defining...
            object missing = System.Reflection.Missing.Value;

            // If wanting to Save the workbook...
            workbook.SaveAs("G:/IssueLogger/IssueLog.xls",
            Excel.XlFileFormat.xlXMLSpreadsheet, missing, missing,
            false, false, Excel.XlSaveAsAccessMode.xlNoChange,
            missing, missing, missing, missing, missing);//Change_Me

            // If wanting to make Excel visible and activate the worksheet...
            excel.Visible = true;
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.ActiveSheet;
            ((Excel._Worksheet)worksheet).Activate();

            // If wanting excel to shutdown...
            ((Excel._Application)excel).Quit();
        }
    }
}
