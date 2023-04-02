using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo1w2
{
    public partial class frnTriangulo : Form
    {
        public frnTriangulo()
        {
            InitializeComponent();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            Triangulo A;
            A = new Triangulo();
            A.pLadoA = Convert.ToInt32(txtLadoA.Text);
            A.pLadoB = Convert.ToInt32(txtLadoB.Text);
            A.pLadoC = Convert.ToInt32(txtLadoC.Text);
            txtPromedio.Text = Convert.ToString(A.calcularPerimetro());
            txtTipo.Text = A.calcularTipo();


        }
    }
}
