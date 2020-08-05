using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaterBll;
using CaterModel;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;

namespace CaterUI.test
{
    public partial class NPOITest : Form
    {
        public NPOITest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //查询数据，显示到表格上
            ManagerInfoBll miBll=new ManagerInfoBll();
            var list = miBll.GetList();
            dataGridView1.DataSource = list;

            //进行excel生成创建操作
            //1、创建workbook,不指定参数，表示创建一个新的工作本
            HSSFWorkbook workbook=new HSSFWorkbook();
            //2、创建sheet
            HSSFSheet sheet = workbook.CreateSheet("管理员");
            //3、创建row
            HSSFRow row = sheet.CreateRow(0);
            //4、创建cell
            HSSFCell cell0 = row.CreateCell(0);
            cell0.SetCellValue("管理员列表");
            //5、设置合并单元格
            sheet.AddMergedRegion(new NPOI.HSSF.Util.Region(0, 0, 0, 3));
            //6、设置单元格居中
            HSSFCellStyle styleTitle = workbook.CreateCellStyle();
            styleTitle.Alignment = 2;//居中
            cell0.CellStyle = styleTitle;
            //6.1设置字体
            HSSFFont fontTitle = workbook.CreateFont();
            fontTitle.FontHeightInPoints = 14;
            styleTitle.SetFont(fontTitle);


            //7、创建标题行
            //7.1创建行
            HSSFRow rowTitle = sheet.CreateRow(1);
            //7.2创建单元格
            HSSFCell cellTitle0 = rowTitle.CreateCell(0);
            cellTitle0.SetCellValue("编号");
            cellTitle0.CellStyle = styleTitle;
            
            HSSFCell cellTitle1 = rowTitle.CreateCell(1);
            cellTitle1.SetCellValue("姓名");
            cellTitle1.CellStyle = styleTitle;

            HSSFCell cellTitle2 = rowTitle.CreateCell(2);
            cellTitle2.SetCellValue("密码");
            cellTitle2.CellStyle = styleTitle;

            HSSFCell cellTitle3 = rowTitle.CreateCell(3);
            cellTitle3.SetCellValue("类型");
            cellTitle3.CellStyle = styleTitle;

            //8、遍历集合，创建正文数据
            //8.1遍历集合
            int rowIndex = 2;
            foreach (var mi in list)
            {
                //8.2创建行
                HSSFRow rowData = sheet.CreateRow(rowIndex++);
                //8.3创建数据单元格
                HSSFCell cellData0 = rowData.CreateCell(0);
                cellData0.SetCellValue(mi.MId);

                HSSFCell cellData1 = rowData.CreateCell(1);
                cellData1.SetCellValue(mi.MName);

                HSSFCell cellData2 = rowData.CreateCell(2);
                cellData2.SetCellValue(mi.MPwd);

                HSSFCell cellData3 = rowData.CreateCell(3);
                cellData3.SetCellValue(mi.MType==1?"经理":"店员");
            }

            //保存工作本
            FileStream stream = new FileStream(@"C:\Users\q1\Desktop\t1.xls",FileMode.Create);
            workbook.Write(stream);
            stream.Close();
            stream.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1、读取excel数据，存入list中
            List<ManagerInfo> list=new List<ManagerInfo>();
            //1.1读取文件
            using (FileStream stream = new FileStream(@"C:\Users\q1\Desktop\t1.xls",FileMode.Open))
            {
                //1.2创建workbook
                HSSFWorkbook workbook=new HSSFWorkbook(stream);
                //1.3读取sheet
                HSSFSheet sheet = workbook.GetSheetAt(0);
                //1.4读取正文数据，因为0、1行为标题，直接路过
                int rowIndex = 2;
                HSSFRow row = sheet.GetRow(rowIndex++);
                while (row!=null)
                {
                    //读到数据时返回行对象，如果没有读到则返回null
                    //1.5读取一行中的对象
                    ManagerInfo mi=new ManagerInfo();

                    mi.MId = (int) row.GetCell(0).NumericCellValue;
                    mi.MName = row.GetCell(1).StringCellValue;
                    mi.MPwd = row.GetCell(2).StringCellValue;
                    mi.MType = row.GetCell(3).StringCellValue=="经理"?1:0;

                    list.Add(mi);

                    row = sheet.GetRow(rowIndex++);
                }
            }


            //2、将list赋值给datagridview
            dataGridView1.DataSource = list;
        }
    }
}
