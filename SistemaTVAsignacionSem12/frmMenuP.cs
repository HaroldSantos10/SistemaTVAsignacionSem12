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
            tabs.TabPages[0].Text = "NEW TV"; //agregar texto al tab

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
                tabs.TabPages[0].Text = "TV LIST";
            }
        }

        public Boolean comprobarInt(MetroFramework.Controls.MetroTextBox box)
        {

            Boolean valor;
            if ((Convert.ToInt32(box.Text)).GetType() == Type.GetType("System.Int32"))
            {

                valor = true;
            }
            else
            {
                valor = false;
            }
            return valor;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir la marca del TV", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus(); //enviamos el enfoque a la caja de texto

            }
            if (txtModelo.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el modelo del TV", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus(); //enviamos el enfoque a la caja de texto

            }
            if (txtColor.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el color del TV", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtColor.Focus(); //enviamos el enfoque a la caja de texto

            }


            if (comprobarInt(txtSize) == true || txtSize.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el tamaño del TV", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSize.Focus(); //enviamos el enfoque a la caja de texto

            }
            if (txtYear.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el año del TV", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Focus(); //enviamos el enfoque a la caja de texto

            }
            else
            {

                Televisor tv = new Televisor(); //instancia de la clase Televisor
                                                //evaluar la accion
                if (action == "edit")
                {
                    tv._idTv = Convert.ToInt32(txtTvId.Text);
                }

                tv._marca = txtMarca.Text;
                tv._modelo = txtModelo.Text;
                tv._color = txtColor.Text;
                tv._size = Convert.ToInt32(txtSize.Text);
                tv._year = txtYear.Text;


                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (tv.newEditTV(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();
                    tabs.TabPages.Remove(tabForm);
                    tabs.TabPages.Add(tabData);
                    tabs.TabPages[0].Text = "TVs LIST";
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Remove(tabData);
            tabs.TabPages.Add(tabForm);
            tabs.TabPages[0].Text = "EDIT TV";
            controlsEnable();

            txtTvId.Visible = true;
            txtTvId.ReadOnly = true;
            lblId.Visible = true;

            //pasar los valores del datagridview hacia los texbox
            txtTvId.Text = dtgTvs.CurrentRow.Cells[0].Value.ToString();
            txtMarca.Text = dtgTvs.CurrentRow.Cells[1].Value.ToString();
            txtModelo.Text = dtgTvs.CurrentRow.Cells[2].Value.ToString();
            txtColor.Text = dtgTvs.CurrentRow.Cells[3].Value.ToString();
            txtSize.Text = dtgTvs.CurrentRow.Cells[4].Value.ToString();
            txtYear.Text = dtgTvs.CurrentRow.Cells[5].Value.ToString();

            //enviar accion
            action = "edit";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Televisor tv = new Televisor();
                tv._idTv = Convert.ToInt32(dtgTvs.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteBook() de la clase Book
                if (tv.deleteTV())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
