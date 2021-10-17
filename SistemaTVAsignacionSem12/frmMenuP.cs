using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTVAsignacionSem12
{
    public partial class frmMenuP : Form
    {
        public frmMenuP()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenuP_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            frmEliminarRegs forma = new frmEliminarRegs();
            forma.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmMostrar forma = new frmMostrar();
            forma.Show();
        }

        private void btnSubmitData_Click(object sender, EventArgs e)
        {
            frmEnviarDatos forma = new frmEnviarDatos();
            forma.Show();
        }
    }
}
