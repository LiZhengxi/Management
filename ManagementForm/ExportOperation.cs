using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementForm
{
    public static class ExportOperation
    {
        //TODO: Add more parameter, change to a generic model
        private static DataTable GetDataTableFromDataGrid(DataGridView dataGridView, List<string> columsNameList, List<int> columsNumberList)
        {
            DataTable dt = new DataTable();
            try
            {
                dt.TableName = "data-table";
                //  把DataGridView控件数据，转成DataTable
                if (columsNameList.Count == columsNameList.Count && columsNumberList.Count <= dataGridView.Columns.Count)
                {
                    // Set title
                    for (int count = 0; count < columsNameList.Count; count++)
                    {
                        DataColumn dc = new DataColumn(columsNameList[count]);
                        dt.Columns.Add(dc);
                    }

                    // Attach data
                    for (int count = 0; count < dataGridView.Rows.Count; count++)
                    {
                        DataRow dr = dt.NewRow();
                        int index = 0;
                        foreach (int countsub in columsNumberList)
                        {
                            dr[index] = Convert.ToString(dataGridView.Rows[count].Cells[countsub].Value);
                            index++;
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // TODO : Param: send file address  
        // Apply NPOI library 
        private static string ExportExcelOperation(DataTable dt, string filePath)
        {
            string savePath = "";
            if (dt != null)
            {
                try
                {
                    //创建一个工作簿
                    IWorkbook workbook = new HSSFWorkbook();

                    //创建一个 sheet 表
                    ISheet sheet = workbook.CreateSheet(dt.TableName);

                    //创建一行
                    IRow rowH = sheet.CreateRow(0);

                    //创建一个单元格
                    ICell cell = null;

                    //创建单元格样式
                    ICellStyle cellStyle = workbook.CreateCellStyle();

                    //创建格式
                    IDataFormat dataFormat = workbook.CreateDataFormat();

                    //设置为文本格式，也可以为 text，即 dataFormat.GetFormat("text");
                    cellStyle.DataFormat = dataFormat.GetFormat("@");

                    //设置列名
                    foreach (DataColumn col in dt.Columns)
                    {
                        //创建单元格并设置单元格内容
                        rowH.CreateCell(col.Ordinal).SetCellValue(col.Caption);

                        //设置单元格格式
                        rowH.Cells[col.Ordinal].CellStyle = cellStyle;
                    }

                    //写入数据
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //跳过第一行，第一行为列名
                        IRow row = sheet.CreateRow(i + 1);

                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            cell = row.CreateCell(j);
                            cell.SetCellValue(dt.Rows[i][j].ToString());
                            cell.CellStyle = cellStyle;
                        }
                    }
                    //设置当前路径
                    // string path = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

                    //设置新建文件路径及名称
                    //savePath = filePath + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";

                    //创建文件
                    FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write);

                    //创建一个 IO 流
                    MemoryStream ms = new MemoryStream();

                    //写入到流
                    workbook.Write(ms);

                    //转换为字节数组
                    byte[] bytes = ms.ToArray();

                    file.Write(bytes, 0, bytes.Length);
                    file.Flush();

                    //释放资源
                    bytes = null;

                    ms.Close();
                    ms.Dispose();

                    file.Close();
                    file.Dispose();

                    workbook.Close();
                    sheet = null;
                    workbook = null;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return savePath;
        }

        public static SaveFileDialog saveFileDialogSetting(string title, string fomat, string fileName, SaveFileDialog saveFileDialog)
        {
            saveFileDialog.Title = title;
            saveFileDialog.Filter = fomat;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = fileName;

            return saveFileDialog;
        }

        // Apply two functions
        public static void ExportExcel(string filePath, DataGridView dataGridView, List<string> columsNameList, List<int> columsNumberList)
        {
            DataTable dataTable = GetDataTableFromDataGrid(dataGridView, columsNameList, columsNumberList);
            ExportExcelOperation(dataTable, filePath);
        }
    }
}
