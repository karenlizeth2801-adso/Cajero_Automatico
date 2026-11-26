namespace CajeroAutomatico2
{
    partial class frmRetiro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblRapidos = new System.Windows.Forms.Label();
            this.btnMonto50 = new System.Windows.Forms.Button();
            this.btnMonto100 = new System.Windows.Forms.Button();
            this.btnMonto200 = new System.Windows.Forms.Button();
            this.btnMonto500 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(42, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Retirar Dinero";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSaldo.Location = new System.Drawing.Point(45, 73);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(700, 30);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo Disponible ";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(46, 147);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(400, 28);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "¿Cuánto deseas retirar?";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(51, 178);
            this.txtMonto.MaxLength = 8;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(427, 38);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblRapidos
            // 
            this.lblRapidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapidos.Location = new System.Drawing.Point(46, 251);
            this.lblRapidos.Name = "lblRapidos";
            this.lblRapidos.Size = new System.Drawing.Size(400, 28);
            this.lblRapidos.TabIndex = 4;
            this.lblRapidos.Text = "O elige un monto rápido";
            this.lblRapidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMonto50
            // 
            this.btnMonto50.BackColor = System.Drawing.Color.White;
            this.btnMonto50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonto50.FlatAppearance.BorderSize = 0;
            this.btnMonto50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMonto50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnMonto50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonto50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonto50.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMonto50.Location = new System.Drawing.Point(51, 297);
            this.btnMonto50.Name = "btnMonto50";
            this.btnMonto50.Size = new System.Drawing.Size(178, 65);
            this.btnMonto50.TabIndex = 5;
            this.btnMonto50.Text = "$50.000";
            this.btnMonto50.UseVisualStyleBackColor = false;
            this.btnMonto50.Click += new System.EventHandler(this.btnMonto50_Click);
            // 
            // btnMonto100
            // 
            this.btnMonto100.BackColor = System.Drawing.Color.White;
            this.btnMonto100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonto100.FlatAppearance.BorderSize = 0;
            this.btnMonto100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMonto100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnMonto100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonto100.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonto100.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMonto100.Location = new System.Drawing.Point(251, 297);
            this.btnMonto100.Name = "btnMonto100";
            this.btnMonto100.Size = new System.Drawing.Size(178, 65);
            this.btnMonto100.TabIndex = 6;
            this.btnMonto100.Text = "$100.000";
            this.btnMonto100.UseVisualStyleBackColor = false;
            this.btnMonto100.Click += new System.EventHandler(this.btnMonto100_Click);
            // 
            // btnMonto200
            // 
            this.btnMonto200.BackColor = System.Drawing.Color.White;
            this.btnMonto200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonto200.FlatAppearance.BorderSize = 0;
            this.btnMonto200.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMonto200.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnMonto200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonto200.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonto200.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMonto200.Location = new System.Drawing.Point(449, 297);
            this.btnMonto200.Name = "btnMonto200";
            this.btnMonto200.Size = new System.Drawing.Size(178, 65);
            this.btnMonto200.TabIndex = 7;
            this.btnMonto200.Text = "$200.000";
            this.btnMonto200.UseVisualStyleBackColor = false;
            this.btnMonto200.Click += new System.EventHandler(this.btnMonto200_Click);
            // 
            // btnMonto500
            // 
            this.btnMonto500.BackColor = System.Drawing.Color.White;
            this.btnMonto500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonto500.FlatAppearance.BorderSize = 0;
            this.btnMonto500.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMonto500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnMonto500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonto500.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonto500.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMonto500.Location = new System.Drawing.Point(648, 297);
            this.btnMonto500.Name = "btnMonto500";
            this.btnMonto500.Size = new System.Drawing.Size(178, 65);
            this.btnMonto500.TabIndex = 8;
            this.btnMonto500.Text = "$500.000";
            this.btnMonto500.UseVisualStyleBackColor = false;
            this.btnMonto500.Click += new System.EventHandler(this.btnMonto500_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMensaje.Location = new System.Drawing.Point(68, 393);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(690, 30);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(73, 441);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(441, 50);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "CONFIRMAR RETIRO ";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(529, 441);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(297, 50);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(880, 530);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMonto500);
            this.Controls.Add(this.btnMonto200);
            this.Controls.Add(this.btnMonto100);
            this.Controls.Add(this.btnMonto50);
            this.Controls.Add(this.lblRapidos);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(50, 25);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmRetiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\tCajero Automático - Retiro";
            this.Load += new System.EventHandler(this.frmRetiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblRapidos;
        private System.Windows.Forms.Button btnMonto50;
        private System.Windows.Forms.Button btnMonto100;
        private System.Windows.Forms.Button btnMonto200;
        private System.Windows.Forms.Button btnMonto500;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolver;
    }
}