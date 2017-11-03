using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string adres = Environment.CurrentDirectory + "/resim/";
        Random resim = new Random();
        int resim1, resim2, resim3;
        int hak = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            
            resim1 = resim.Next(1, 8);
            resim2 = resim.Next(1, 8);
            resim3 = resim.Next(1, 8);
            pictureBox1.Load(resimBelirleme(resim1));
            pictureBox2.Load(resimBelirleme(resim2));
            pictureBox3.Load(resimBelirleme(resim3));

            

            if (resim1 == resim2 || resim1 == resim3 || resim2 == resim3)
                hak++;
            else if (resim1 == resim2 && resim1 == resim3 && resim2 == resim3)
                hak += 5;
            else if (resim1 == 7 && resim2 == 7 && resim3 == 7)
                hak += 1000;
            else if (resim1 != resim2 && resim1 != resim3 && resim2 != resim3)
                hak--;

            if (hak == 0)
            {
                MessageBox.Show("Hakkınız Bitti", "Çıkış", MessageBoxButtons.OK);
                Application.Exit();
            }
            textBox1.Text = hak.ToString();
        }

        public string resimBelirleme(int no)
        {
            switch (no)
            {
                case 1: return adres + "1.jpg";
                case 2: return adres + "2.jpg";
                case 3: return adres + "3.jpg";
                case 4: return adres + "4.jpg";
                case 5: return adres + "5.jpg";
                case 6: return adres + "6.jpg";
                case 7: return adres + "7.jpg";
                default: return null;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = hak.ToString();
            resim1 = resim.Next(1, 8);
            resim2 = resim.Next(1, 8);
            resim3 = resim.Next(1, 8);
            pictureBox1.Load(resimBelirleme(resim1));
            pictureBox2.Load(resimBelirleme(resim2));
            pictureBox3.Load(resimBelirleme(resim3));
        }
    }
}
