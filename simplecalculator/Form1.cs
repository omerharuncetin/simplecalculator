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

        private int Topla(int birinciSayi, int ikinciSayi)
        {
            return birinciSayi + ikinciSayi;
        }
        
        private bool Dogrula()
        {
            try
            {
                int.Parse(txtBirinciSayi.Text);
                int.Parse(txtIkinciSayi.Text);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                int toplam = Topla(int.Parse(txtBirinciSayi.Text), int.Parse(txtIkinciSayi.Text));
                MessageBox.Show("Toplam: " + toplam);
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerler hatalı!");
            }

        }
    }
}
