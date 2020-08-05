using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02ProvinceCitySelect
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //加载数据库中的所有的省的数据
            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

            //创建链接对象
            using (SqlConnection conn =new SqlConnection(connStr))
            {
                using (SqlCommand cmd =conn.CreateCommand())
                {
                    conn.Open();//***********8
                    cmd.CommandText =@"select AreaId, AreaName, AreaPid from [dbo].[AreaFull] where AreaPId=0";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while ( reader.Read())
                        {
                            //int AreadId = int.Parse(reader["AreaId"].ToString());
                            //把表格的数据转换成 对象数据
                            AreaInfo areaInfo = new AreaInfo();
                            areaInfo.AreaId = int.Parse(reader["AreaId"].ToString());
                            areaInfo.AreaName = reader["AreaName"].ToString();
                            areaInfo.AreaPId = int.Parse(reader["AreaPId"].ToString());
                            //把省的信息放到 ComboBox中。ComboBox显示信息是 Item对象的ToString（）
                            this.cbxProvince.Items.Add(areaInfo);
                        }
                    }//end useing  reader
                }//end  useing cmd
            }//end  using conn

            this.cbxProvince.SelectedIndex = 0;
        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            AreaInfo provinceAreaInfo= this.cbxProvince.SelectedItem as AreaInfo;
            //判断是否 拿到的城市为空
            if (provinceAreaInfo == null)
            {
                return;
            }
            //根据省的Id获取所有的城市信息

            //加载数据库中的所有的省的数据
            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

            //创建链接对象
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();//***********8
                    cmd.CommandText = @"select AreaId, AreaName, AreaPid from [dbo].[AreaFull] where AreaPId="+provinceAreaInfo.AreaId;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        this.cbxCity.Items.Clear();
                        while (reader.Read())
                        {
                            //int AreadId = int.Parse(reader["AreaId"].ToString());
                            //把表格的数据转换成 对象数据
                            AreaInfo areaInfo = new AreaInfo();
                            areaInfo.AreaId = int.Parse(reader["AreaId"].ToString());
                            areaInfo.AreaName = reader["AreaName"].ToString();
                            areaInfo.AreaPId = int.Parse(reader["AreaPId"].ToString());
                            //把省的信息放到 ComboBox中。ComboBox显示信息是 Item对象的ToString（）
                            this.cbxCity.Items.Add(areaInfo);
                        }
                    }//end useing  reader
                }//end  useing cmd
            }//en
            this.cbxCity.SelectedIndex = 0;

        }

        private void btbExport_Click(object sender, EventArgs e)
        {
            #region 选择保存文件
            string fileName = string.Empty;// 保存的文件名
            //让用户选择 要保存的文件路径
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                fileName = sfd.FileName;
            } 
            #endregion

            // 查询数据数据，写入数据
            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

            using (SqlConnection conn =new SqlConnection(connStr))
            {
                using (SqlCommand cmd =conn.CreateCommand())
                {
                    conn.Open();

                    cmd.CommandText = "select AreaId, AreaName, AreaPid from [dbo].[AreaFull]";

                    using (SqlDataReader reader =cmd.ExecuteReader())
                    {
                        string tempLine = string.Empty;
                        using (StreamWriter writer =new StreamWriter(fileName))
                        {
                            while (reader.Read())
                            {
                                tempLine = reader["AreaId"] + "," +
                                           reader["AreaName"] + "," +
                                           reader["AreaPId"];
                                writer.WriteLine(tempLine);//写入文本文件
                            }
                        }
                      
                    }
                }
            }
        }
    }
}
