using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecalculator
{
    public partial class FormTopla : Form
    {
        public FormTopla()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int birinciSayi, ikinciSayi, toplam;
            birinciSayi = int.Parse(txtBirinciSayi.Text);
            ikinciSayi = int.Parse(txtIkinciSayi.Text);
            toplam = birinciSayi + ikinciSayi;
            MessageBox.Show("Toplam: " + toplam);

        }
    }
}
