
namespace SistemaTVAsignacionSem12
{
    partial class frmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTablaData = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, aquí puede visualizar los datos de los modelos diponibles ";
            // 
            // dgvTablaData
            // 
            this.dgvTablaData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.dgvTablaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaData.Location = new System.Drawing.Point(27, 107);
            this.dgvTablaData.Name = "dgvTablaData";
            this.dgvTablaData.Size = new System.Drawing.Size(629, 207);
            this.dgvTablaData.TabIndex = 1;
            // 
            // btnShowData
            // 
            this.btnShowData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowData.FlatAppearance.BorderSize = 2;
            this.btnShowData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.Location = new System.Drawing.Point(73, 354);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(149, 45);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.Text = "Mostrar";
            this.btnShowData.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(310, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar un registro";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(682, 443);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dgvTablaData);
            this.Controls.Add(this.label1);
            this.Name = "frmMostrar";
            this.Text = "Mostrar Registros";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTablaData;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnDelete;
    }
}