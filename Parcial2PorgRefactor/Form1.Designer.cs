namespace Parcial2PorgRefactor
{
    partial class Form1
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
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtObrasPublicas = new System.Windows.Forms.TextBox();
            this.btnObrasPublicas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCodPostal = new System.Windows.Forms.TextBox();
            this.btnBuscarCodPost = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBuscarIntendente = new System.Windows.Forms.TextBox();
            this.btnBuscarIntendente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.Modificaciones = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Modificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.AllowUserToAddRows = false;
            this.dgvLocalidades.AllowUserToDeleteRows = false;
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(12, 324);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidades.Size = new System.Drawing.Size(906, 170);
            this.dgvLocalidades.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarTodos);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(122, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 227);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busquedas";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(286, 169);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarTodos.TabIndex = 10;
            this.btnBuscarTodos.Text = "Buscar todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtObrasPublicas);
            this.groupBox6.Controls.Add(this.btnObrasPublicas);
            this.groupBox6.Location = new System.Drawing.Point(352, 98);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(268, 54);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Buscar obras publicas";
            // 
            // txtObrasPublicas
            // 
            this.txtObrasPublicas.Location = new System.Drawing.Point(17, 19);
            this.txtObrasPublicas.Name = "txtObrasPublicas";
            this.txtObrasPublicas.Size = new System.Drawing.Size(155, 20);
            this.txtObrasPublicas.TabIndex = 0;
            // 
            // btnObrasPublicas
            // 
            this.btnObrasPublicas.Location = new System.Drawing.Point(178, 19);
            this.btnObrasPublicas.Name = "btnObrasPublicas";
            this.btnObrasPublicas.Size = new System.Drawing.Size(75, 23);
            this.btnObrasPublicas.TabIndex = 1;
            this.btnObrasPublicas.Text = "Buscar";
            this.btnObrasPublicas.UseVisualStyleBackColor = true;
            this.btnObrasPublicas.Click += new System.EventHandler(this.btnObrasPublicas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBuscarCodPostal);
            this.groupBox4.Controls.Add(this.btnBuscarCodPost);
            this.groupBox4.Location = new System.Drawing.Point(42, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 54);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por codigo postal";
            // 
            // txtBuscarCodPostal
            // 
            this.txtBuscarCodPostal.Location = new System.Drawing.Point(17, 19);
            this.txtBuscarCodPostal.Name = "txtBuscarCodPostal";
            this.txtBuscarCodPostal.Size = new System.Drawing.Size(155, 20);
            this.txtBuscarCodPostal.TabIndex = 0;
            // 
            // btnBuscarCodPost
            // 
            this.btnBuscarCodPost.Location = new System.Drawing.Point(178, 19);
            this.btnBuscarCodPost.Name = "btnBuscarCodPost";
            this.btnBuscarCodPost.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCodPost.TabIndex = 1;
            this.btnBuscarCodPost.Text = "Buscar";
            this.btnBuscarCodPost.UseVisualStyleBackColor = true;
            this.btnBuscarCodPost.Click += new System.EventHandler(this.btnBuscarCodPost_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBuscarIntendente);
            this.groupBox7.Controls.Add(this.btnBuscarIntendente);
            this.groupBox7.Location = new System.Drawing.Point(353, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(268, 54);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buscar por intendente";
            // 
            // txtBuscarIntendente
            // 
            this.txtBuscarIntendente.Location = new System.Drawing.Point(17, 19);
            this.txtBuscarIntendente.Name = "txtBuscarIntendente";
            this.txtBuscarIntendente.Size = new System.Drawing.Size(155, 20);
            this.txtBuscarIntendente.TabIndex = 0;
            // 
            // btnBuscarIntendente
            // 
            this.btnBuscarIntendente.Location = new System.Drawing.Point(178, 19);
            this.btnBuscarIntendente.Name = "btnBuscarIntendente";
            this.btnBuscarIntendente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarIntendente.TabIndex = 1;
            this.btnBuscarIntendente.Text = "Buscar";
            this.btnBuscarIntendente.UseVisualStyleBackColor = true;
            this.btnBuscarIntendente.Click += new System.EventHandler(this.btnBuscarIntendente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.btnBuscarId);
            this.groupBox3.Location = new System.Drawing.Point(43, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(17, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 20);
            this.txtId.TabIndex = 0;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(178, 19);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarId.TabIndex = 1;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // Modificaciones
            // 
            this.Modificaciones.Controls.Add(this.button3);
            this.Modificaciones.Controls.Add(this.btnModificar);
            this.Modificaciones.Controls.Add(this.btnAgregar);
            this.Modificaciones.Location = new System.Drawing.Point(180, 13);
            this.Modificaciones.Name = "Modificaciones";
            this.Modificaciones.Size = new System.Drawing.Size(524, 60);
            this.Modificaciones.TabIndex = 3;
            this.Modificaciones.TabStop = false;
            this.Modificaciones.Text = "Modificaciones";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar localidad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(204, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar localidad";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar localidad";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 506);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Modificaciones);
            this.Name = "Form1";
            this.Text = "Inicio administracion publica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Modificaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtObrasPublicas;
        private System.Windows.Forms.Button btnObrasPublicas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBuscarCodPostal;
        private System.Windows.Forms.Button btnBuscarCodPost;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBuscarIntendente;
        private System.Windows.Forms.Button btnBuscarIntendente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.GroupBox Modificaciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

