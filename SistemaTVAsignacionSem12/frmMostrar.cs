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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmEliminarRegs frm = new frmEliminarRegs();
            frm.Show();

        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
