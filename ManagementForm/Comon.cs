using ManagementForm.Model;
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
    public static class Comon
    {
        public static int? Authority { get; set; }
        public static long UserId { get; set; }
        public static int DatabaseStaus { get; set; }
        public static List<Altelier> AltelierToAdd{get; set;}

        public static string GetAuthority(int? Authority)
        {
            string retour = "";
            switch (Authority)
            {
                case 0: retour = "管理员";
                        break;
                case 1:
                    retour = "财务";
                    break;
                case 2:
                    retour = "文员";
                    break;
                default:
                    break;
            }
            return retour;
        }

        public class list
        {
            public int value
            {
                get;
                set;
            }
            public string label
            {
                get;
                set;
            }
            public list(int value, string label)
            {
                this.value = value;
                this.label = label;
            }
        }

        public static list[] GetMonths()
        {
            list[] months = new list[]
            {
                new list(1,"一月"),
                new list(2,"二月"),
                new list(3,"三月"),
                new list(4,"四月"),
                new list(5,"五月"),
                new list(6,"六月"),
                new list(7,"七月"),
                new list(8,"八月"),
                new list(9,"九月"),
                new list(10,"十月"),
                new list(11,"十一月"),
                new list(12,"十二月")
            };
            return months;
        }

        public static list[] GetYears()
        {
            list[] years = new list[]
            {
                new list(2019,"2019"),
                new list(2020,"2020"),
                new list(2021,"2021"),
                new list(2022,"2022"),
            };
            return years;
        }

        public  static object GetPropertyValue(object obj,string propertyName)
        {
            //returns value of property Name
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        public static string GetEncryptText(string text)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] EncryptString = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(EncryptString).Replace("-", "");
        }

        //TODO: Add more parameter, change to a generic model
        public static DataTable GetDataTableFromDataGrid(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            dt.TableName = "test";
            //  把DataGridView控件数据，转成DataTable
            for (int count = 0; count < dataGridView.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dataGridView.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dataGridView.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dataGridView.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dataGridView.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        // TODO : Param: send file address  
        // Apply NPOI library 
        public static void ExportExcel(DataTable dt)
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
                string path = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

                //设置新建文件路径及名称
                string savePath = path + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".xls";

                //创建文件
                FileStream file = new FileStream(savePath, FileMode.CreateNew, FileAccess.Write);

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

                // 打开生成的excel
                System.Diagnostics.Process.Start(savePath);
            }
            catch (Exception ex)
            {

            }
        }
    }

}
