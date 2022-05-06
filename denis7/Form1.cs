using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denis7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Z = new int[35];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < Z.Length; i++)
            {
                Z[i] = rand.Next(-10, 10);
                listBox1.Items.Add("Z[" + i.ToString() +"] = " + Z[i].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int S = 0, P = 0, R = 1;
            listBox2.Items.Clear();
            for (int i = 0; i < Z.Length; i++)
            {
                if (((Z[i] % 2) == 0) && (Z[i] < 3))
                        S += Z[i];
            }
            for (int i = 0; i < Z.Length; i++)
            {
                if (((Z[i] % 2) != 0) && (Z[i] > 1))
                        R *= Z[i];
                P = R + S;
            }
            listBox2.Items.Add("Сумма = " + P.ToString());
        }
    }
}
