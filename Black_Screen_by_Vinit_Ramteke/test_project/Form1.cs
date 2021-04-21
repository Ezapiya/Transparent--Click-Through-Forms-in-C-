using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Black_Screen_by_Vinit_Ramteke;

namespace test_project
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Black_Screen black_scree = new Black_Screen();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    pictureBox1.Image = black_scree.get_image(f2);
                    break;
                case 2:
                    pictureBox2.Image = black_scree.get_image(f2);
                    break;
                case 3:
                    pictureBox3.Image = black_scree.get_image(f2);
                    break;
                case 4:
                    pictureBox4.Image = black_scree.get_image(f2);
                    break;
                case 5:
                    pictureBox5.Image = black_scree.get_image(f2);
                    break;
                case 6:
                    pictureBox6.Image = black_scree.get_image(f2);
                    break;
                case 7:
                    pictureBox7.Image = black_scree.get_image(f2);
                    break;
                case 8:
                    pictureBox8.Image = black_scree.get_image(f2);
                    break;
                case 9:
                    pictureBox9.Image = black_scree.get_image(f2);
                    break;
                case 10:
                    pictureBox10.Image = black_scree.get_image(f2);
                    break;
                case 11:
                    pictureBox11.Image = black_scree.get_image(f2);
                    break;
                case 12:
                    pictureBox12.Image = black_scree.get_image(f2);
                    break;
                case 13:
                    pictureBox13.Image = black_scree.get_image(f2);
                    break;
                case 14:
                    pictureBox14.Image = black_scree.get_image(f2);
                    break;
            }
            i++;
            if (i > 14)
            {
                f2.Hide();
                timer2.Stop();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f2.TopMost = true;
            black_scree.Form1_Load(f2, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.WindowState = FormWindowState.Minimized;

            i = 1;
            timer2.Start();

        }
    }
}
