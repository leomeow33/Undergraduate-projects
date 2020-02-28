using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{

    public partial class Form1 : Form
    {
        int a=1, b=1, c=1, d=1,flag = 0;
        int[,] node = new int[9,4];
        int group = 1;
        int[] limition = new int[4];
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            node[group,1] = Convert.ToInt32(textBox1.Text);
            node[group,2] = Convert.ToInt32(textBox2.Text);
            node[group,3] = Convert.ToInt32(textBox3.Text);
            switch(group)
            {
                case 1:
                    textBox4.Text = Convert.ToString(node[group, 1]);
                    textBox5.Text = Convert.ToString(node[group, 2]);
                    textBox6.Text = Convert.ToString(node[group, 3]);
                    break;
                case 2:
                    textBox7.Text = Convert.ToString(node[group, 1]);
                    textBox8.Text = Convert.ToString(node[group, 2]);
                    textBox9.Text = Convert.ToString(node[group, 3]);
                    break;
                case 3:
                    textBox10.Text = Convert.ToString(node[group, 1]);
                    textBox11.Text = Convert.ToString(node[group, 2]);
                    textBox12.Text = Convert.ToString(node[group, 3]);
                    break;
                case 4:
                    textBox13.Text = Convert.ToString(node[group, 1]);
                    textBox14.Text = Convert.ToString(node[group, 2]);
                    textBox15.Text = Convert.ToString(node[group, 3]);
                    break;
                case 5:
                    textBox16.Text = Convert.ToString(node[group, 1]);
                    textBox17.Text = Convert.ToString(node[group, 2]);
                    textBox18.Text = Convert.ToString(node[group, 3]);
                    break;
                case 6:
                    textBox19.Text = Convert.ToString(node[group, 1]);
                    textBox20.Text = Convert.ToString(node[group, 2]);
                    textBox21.Text = Convert.ToString(node[group, 3]);
                    break;
                case 7:
                    textBox22.Text = Convert.ToString(node[group, 1]);
                    textBox23.Text = Convert.ToString(node[group, 2]);
                    textBox24.Text = Convert.ToString(node[group, 3]);
                    break;
                case 8:
                    textBox25.Text = Convert.ToString(node[group, 1]);
                    textBox26.Text = Convert.ToString(node[group, 2]);
                    textBox27.Text = Convert.ToString(node[group, 3]);
                    break;
            }
            当前数据组.Text = "当前数据为第" + group + "组";
            group++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limition[1] = Convert.ToInt32(textBox1.Text);
            limition[2] = Convert.ToInt32(textBox2.Text);
            limition[3] = Convert.ToInt32(textBox3.Text);
            textBox28.Text = Convert.ToString(limition[1]);
            textBox29.Text = Convert.ToString(limition[2]);
            textBox30.Text = Convert.ToString(limition[3]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            flag = 0;
            for(;a<=8;a++)
            {
                for (b=1; b <= 8; b++)
                {
                    for (c=1; c <= 8; c++)
                    {
                        for (d=1; d <= 8; d++)
                        {
                            if (flag == 1) break;
                            flag = check(node, a, b, c, d, limition);
                        }
                        if (flag == 1) break;
                    }
                    if (flag == 1) break;
                }
                if (flag == 1) break;
            }
            if(a ==9)
            {
                textBox31.Text = "无符合条件的组合";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        private int check(int[,] node, int a, int b, int c, int d, int[] limition)
        {
            if (node[a, 1] + node[b, 1] + node[c, 1] + node[d, 1] >= limition[1])
            {
                if (node[a, 2] + node[b, 2] + node[c, 2] + node[d, 2] >= limition[2])
                {
                    if (node[a, 3] + node[b, 3] + node[c, 3] + node[d, 3] >= limition[3])
                    {
                        textBox31.Text = Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d);
                        return 1;
                    }
                    else return 0;
                }
                else return 0;
            }
            else return 0;
        }
    }

}
