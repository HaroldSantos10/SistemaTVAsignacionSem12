using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaTVAsignacionSem12
{
    public partial class frmMenuP : Form
    {
        private string action = "";
        public frmMenuP()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmMenuP_Load(object sender, EventArgs e)
        {   //deja un tab
            tabs.TabPages.Remove(tabForm);
            //carga los datos en el datagridView
            //deshabilita controles
            fillDataGridView();
            controlsDisable();
        }

        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            Televisor tv = new Televisor();

            clearDataGridView();

            dtgTvs.Columns.Add("tvId", "TV ID");
            dtgTvs.Columns.Add("marca", "MARK");
            dtgTvs.Columns.Add("modelo", "MODEL");
            dtgTvs.Columns.Add("color", "COLOR");
            dtgTvs.Columns.Add("size", "SIZE");
            dtgTvs.Columns.Add("year", "YEAR");

            //llamado al medoto getAllTvs() de la clase Televisor
            MySqlDataReader dataReader = tv.getAllTvs();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dtgTvs.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4)
                       );
            }
        }

        public void clearDataGridView()
        {
            dtgTvs.Columns.Clear();
            dtgTvs.Rows.Clear();
        }
        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtTvId.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtColor.Enabled = false;
            txtSize.Enabled = false;
            txtYear.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtTvId.Enabled = false;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtColor.Enabled = true;
            txtSize.Enabled = true;
            txtYear.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        //limpiar el contenido de los controles
        public void clearControls()
        {
            txtTvId.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtSize.Text = "";
            txtYear.Text = "";
        }

        private void dtgBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabs.TabPages.Remove(tabData);//ocultar el tab de el datagridview
            tabs.TabPages.Add(tabForm); //mostrar el formulario para los datos
            tabs.TabPages[0].Text = "EDIT BOOK";

            action = "edit";
            controlsEnable();

            txtTvId.Visible = true;
            txtTvId.ReadOnly = true;
            lblId.Visible = true;

            //cargar datos en controles
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //mediante este boton se programará para guardar y editar
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //codigo del boton salir
            string mensaje = "¿Está seguró que desea salir?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lNew_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);//mostrar el formulario
            tabs.TabPages.Remove(tabData); //ocultar el  tab del dataagridview
            tabs.TabPages[0].Text = "NEW BOOK"; //agregar texto al tab

            txtTvId.Visible = false;
            lblId.Visible = false;
            txtMarca.Focus(); //enviar enfoque a la marca
            action = "new";
            controlsEnable();
            clearControls();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "BOOK LIST";
            }
        }
        
    }
}
