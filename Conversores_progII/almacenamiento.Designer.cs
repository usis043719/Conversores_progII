namespace Conversores_progII
{
    partial class almacenamiento
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
            this.lblcant = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.lblA = new System.Windows.Forms.Label();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcant.Location = new System.Drawing.Point(134, 45);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(138, 18);
            this.lblcant.TabIndex = 23;
            this.lblcant.Text = "Ingrese cantidad :\r\n";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(37, 246);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(105, 26);
            this.cboTipo.TabIndex = 22;
            this.cboTipo.Visible = false;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboA
            // 
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(378, 88);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(110, 21);
            this.cboA.TabIndex = 21;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(341, 88);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(31, 21);
            this.lblA.TabIndex = 20;
            this.lblA.Text = "A:";
            // 
            // cboDe
            // 
            this.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDe.FormattingEnabled = true;
            this.cboDe.Location = new System.Drawing.Point(148, 88);
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(108, 21);
            this.cboDe.TabIndex = 19;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ForeColor = System.Drawing.Color.Black;
            this.lblDe.Location = new System.Drawing.Point(98, 88);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(44, 21);
            this.lblDe.TabIndex = 18;
            this.lblDe.Text = "De:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(278, 45);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(104, 20);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblRespuesta.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRespuesta.Location = new System.Drawing.Point(123, 176);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(19, 25);
            this.lblRespuesta.TabIndex = 16;
            this.lblRespuesta.Text = "!";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConvertir.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.Black;
            this.btnConvertir.Location = new System.Drawing.Point(185, 234);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(197, 38);
            this.btnConvertir.TabIndex = 15;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // almacenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 340);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cboDe);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnConvertir);
            this.Name = "almacenamiento";
            this.Text = "almacenamiento";
            this.Load += new System.EventHandler(this.almacenamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnConvertir;
    }
}