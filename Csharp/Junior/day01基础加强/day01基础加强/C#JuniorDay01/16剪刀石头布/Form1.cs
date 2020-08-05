using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16剪刀石头布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fist = "石头";
            PlayGame(fist);
        }

        private void PlayGame(string fist)
        {
            Player p = new Player();//创建玩家对象
            int playerNumber = p.ChuQuan(fist);
            lblPlayer.Text =fist;

            //创建电脑对象
            Computer cpu = new Computer();
            int cpuNumber = cpu.ChuQuan();
            //将电脑出的拳头赋值给lblCpu
            lblCpu.Text = cpu.Fist;

            //创建裁判对象
            CaiPan cp = new CaiPan();
            Result res = cp.GetResult(playerNumber, cpuNumber);
            lblResult.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fist = "剪刀";
            PlayGame(fist);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fist = "布";
            PlayGame(fist);
        }
    }
}
