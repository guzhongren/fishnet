using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fishnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path=@"G:\RZPU\20141118fishnet\总表.csv";
              outPutAll.generateTable.OutAllFilds(path);
              MessageBox.Show("完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outPutAll.generateTable.outCenterPointofBigTable();
            MessageBox.Show("成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outPutAll.generateTable.getSmallFramPoint();
            MessageBox.Show("输出第三级完毕");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outPutAll.generateTable.getSmallFramCenterPoint();
            MessageBox.Show("输出小方格中心点完毕！");
        }
    }
}
