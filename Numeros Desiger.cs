using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Operaciones operaciones = new Operaciones();
        static string Operacion;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
	     txtCalculadora.Text = txtCalculadora.Text + "2";

        }

	 private void btnTres_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
	     txtCalculadora.Text = txtCalculadora.Text + "4";

        }
	 private void btnCinco_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
	     txtCalculadora.Text = txtCalculadora.Text + "6";

        }
	 private void btnSiete_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
	     txtCalculadora.Text = txtCalculadora.Text + "8";

        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
	     txtCalculadora.Text = txtCalculadora.Text + "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
