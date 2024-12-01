using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OYUN.Oyunlar
{
    public partial class DusuktenYuksegeoyunu : Form
    {
        public DusuktenYuksegeoyunu()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sure = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            int sayı1, sayı2, sayı3;

            sayı1 = rastgele.Next(0, 50);
            sayı2 = rastgele.Next(0, 50);
            sayı3 = rastgele.Next(0, 50);

            label3.Text = sayı1.ToString();
            label4.Text = sayı2.ToString();
            label5.Text = sayı3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == textBox1.Text && label4.Text == textBox2.Text && label5.Text == textBox3.Text)
            {
                MessageBox.Show("Tebrikler oyunu kazandınız :) ");
            }
            else
            {
                MessageBox.Show("Üzgünüm oyunu kaybettiniz :( ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            //label6_Click.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                panel1.Visible = false;
                label6.Text = "5"; // kaldırabılırsın 
                sure = 5;
            }
        }
    }
}
