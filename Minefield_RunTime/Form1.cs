using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minefield_RunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int mine_number = 0;
            for (int a = 1; a <= 36; a++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.BackColor = Color.Gray;
                int selected = rnd.Next(1, 37);
                if (selected % 6 == 0)
                {
                    btn.Tag = "M";
                    mine_number++;
                }
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
                label2.Text = mine_number.ToString();
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender) as Button;
            if ((string)btn.Tag == "M")
            {
                foreach (Control items in flowLayoutPanel1.Controls)
                {
                    if ((string)items.Tag == "M")
                    {
                        items.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                btn.BackColor = Color.Green;
            }

        }
    }
}
