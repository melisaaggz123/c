using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class Anasayfa : Form
    {
        private OyunGirişEkranı OyunGirişEkranıformu;
        public Anasayfa()
        {
            InitializeComponent();
            OyunGirişEkranıformu = new OyunGirişEkranı();
        }
        int x, y;
        private void button1_Click(object sender, EventArgs e)
        {
            OyunGirişEkranıformu.Show();
        }

        private void Anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            return;
            this.Left += e.X;
            this.Top += e.Y;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
