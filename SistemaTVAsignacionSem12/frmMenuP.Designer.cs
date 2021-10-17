
namespace SistemaTVAsignacionSem12
{
    partial class frmMenuP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSubmitData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(0, 35);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(202, 32);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Mostrar Registros";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSubmitData
            // 
            this.btnSubmitData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitData.FlatAppearance.BorderSize = 2;
            this.btnSubmitData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitData.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitData.Location = new System.Drawing.Point(0, 84);
            this.btnSubmitData.Name = "btnSubmitData";
            this.btnSubmitData.Size = new System.Drawing.Size(202, 32);
            this.btnSubmitData.TabIndex = 2;
            this.btnSubmitData.Text = "Ingresar Registros";
            this.btnSubmitData.UseVisualStyleBackColor = true;
            this.btnSubmitData.Click += new System.EventHandler(this.btnSubmitData_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(147)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 547);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(167)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.btnDeleteData);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Controls.Add(this.btnSubmitData);
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 177);
            this.panel3.TabIndex = 5;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteData.FlatAppearance.BorderSize = 2;
            this.btnDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteData.Location = new System.Drawing.Point(0, 128);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(202, 32);
            this.btnDeleteData.TabIndex = 3;
            this.btnDeleteData.Text = "Eliminar un registro";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenu.Location = new System.Drawing.Point(45, 204);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 41);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(143)))), ((int)(((byte)(247)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 149);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(199, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(637, 547);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // frmMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(835, 547);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMenuP_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSubmitData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Panel panel4;
    }
}

