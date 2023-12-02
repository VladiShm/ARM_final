using ClosedXML.Excel;
using Npgsql;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_final
{
    internal class ExcelData
    {
        public static SqlCommands commands = new SqlCommands();

        public static void GetInfo()
        {
            DataTable dataTable = new DataTable();
            try
            {
                commands.Connection();
                string command = "select m.name, m.surname, c.name, c.surname, address,  date from visits as v join master as m on " +
                    "m.id = v.master_id join branches as b on b.id = v.branch_id join client as c on c.id = v.client_id";
                dataTable = new DataTable();
                using (var cmd = new NpgsqlCommand(command, commands.strCon))
                {
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dataTable.Load(dr);
                }
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
                    string[] columnNames = { "Имя мастера", "Фамилия мастера", "Имя клиента", "Фамилия клиента", "Адрес", "Дата" };
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = columnNames[i];
                    }

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int column = 0; column < dataTable.Columns.Count; column++)
                        {
                            worksheet.Cells[row + 2, column + 1].Value = dataTable.Rows[row][column];
                        }
                    }

                    string currentTime = DateTime.Now.ToString("HHmmss");
                    FileInfo excelFile = new FileInfo($"C:\\Users\\vladi\\source\\repos\\ARM_final\\отчет\\file_{currentTime}.xlsx");
                    package.SaveAs(excelFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
