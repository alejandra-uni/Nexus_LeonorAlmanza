namespace Nexus.UI
{
    partial class FrmPrincipal
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
            this.btnExplorar = new System.Windows.Forms.Button();
            this.btlAnalizar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lnlTitulo = new System.Windows.Forms.Label();
            this.btnEnergia = new System.Windows.Forms.Button();
            this.btnDesconexion = new System.Windows.Forms.Button();
            this.btnMapas = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnCadetes = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(38, 109);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(187, 22);
            this.btnExplorar.TabIndex = 0;
            this.btnExplorar.Text = "EXPLORAR REALIDAD";
            this.btnExplorar.UseVisualStyleBackColor = true;
            // 
            // btlAnalizar
            // 
            this.btlAnalizar.Location = new System.Drawing.Point(38, 142);
            this.btlAnalizar.Name = "btlAnalizar";
            this.btlAnalizar.Size = new System.Drawing.Size(187, 23);
            this.btlAnalizar.TabIndex = 1;
            this.btlAnalizar.Text = "ANALIZAR ANOMALIA";
            this.btlAnalizar.UseVisualStyleBackColor = true;
            this.btlAnalizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(38, 180);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(187, 23);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "CONSULTAR ESTADO";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlEncabezado.Controls.Add(this.lnlTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1060, 89);
            this.pnlEncabezado.TabIndex = 5;
            this.pnlEncabezado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEncabezado_Paint);
            // 
            // lnlTitulo
            // 
            this.lnlTitulo.AutoSize = true;
            this.lnlTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTitulo.Location = new System.Drawing.Point(35, 15);
            this.lnlTitulo.Name = "lnlTitulo";
            this.lnlTitulo.Size = new System.Drawing.Size(60, 18);
            this.lnlTitulo.TabIndex = 0;
            this.lnlTitulo.Text = "NEXUS";
            // 
            // btnEnergia
            // 
            this.btnEnergia.Location = new System.Drawing.Point(38, 219);
            this.btnEnergia.Name = "btnEnergia";
            this.btnEnergia.Size = new System.Drawing.Size(187, 23);
            this.btnEnergia.TabIndex = 6;
            this.btnEnergia.Text = "RECUPERAR ENERGIA";
            this.btnEnergia.UseVisualStyleBackColor = true;
            // 
            // btnDesconexion
            // 
            this.btnDesconexion.Location = new System.Drawing.Point(38, 257);
            this.btnDesconexion.Name = "btnDesconexion";
            this.btnDesconexion.Size = new System.Drawing.Size(187, 23);
            this.btnDesconexion.TabIndex = 7;
            this.btnDesconexion.Text = "DESCONECTAR NEXUS";
            this.btnDesconexion.UseVisualStyleBackColor = true;
            // 
            // btnMapas
            // 
            this.btnMapas.Location = new System.Drawing.Point(38, 295);
            this.btnMapas.Name = "btnMapas";
            this.btnMapas.Size = new System.Drawing.Size(187, 23);
            this.btnMapas.TabIndex = 8;
            this.btnMapas.Text = "MAPAS DE REALIDADES";
            this.btnMapas.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(38, 333);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(187, 23);
            this.btnRed.TabIndex = 9;
            this.btnRed.Text = "CONEXION EN RED";
            this.btnRed.UseVisualStyleBackColor = true;
            // 
            // btnCadetes
            // 
            this.btnCadetes.Location = new System.Drawing.Point(38, 371);
            this.btnCadetes.Name = "btnCadetes";
            this.btnCadetes.Size = new System.Drawing.Size(187, 23);
            this.btnCadetes.TabIndex = 10;
            this.btnCadetes.Text = "CONSULTAR CADETES";
            this.btnCadetes.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnCadetes);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnMapas);
            this.Controls.Add(this.btnDesconexion);
            this.Controls.Add(this.btnEnergia);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btlAnalizar);
            this.Controls.Add(this.btnExplorar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEXUS TRAINING SYSTEM";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.Button btlAnalizar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lnlTitulo;
        private System.Windows.Forms.Button btnEnergia;
        private System.Windows.Forms.Button btnDesconexion;
        private System.Windows.Forms.Button btnMapas;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnCadetes;
    }
}

