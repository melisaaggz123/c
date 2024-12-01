using Birİşlem;
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
    public partial class OyunGirişEkranı : Form
    {
        Form1 birislem = new Form1();
        public OyunGirişEkranı()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           birislem.Show();
        }
    }
}
