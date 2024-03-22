namespace WindowsFormsApp1
{
    partial class frmFatura
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalFatura = new System.Windows.Forms.Label();
            this.lblPizzaEscolhida = new System.Windows.Forms.Label();
            this.lblBordaEscolhida = new System.Windows.Forms.Label();
            this.lblSucoEscolhido = new System.Windows.Forms.Label();
            this.lblBebidaEscolhida = new System.Windows.Forms.Label();
            this.lblValorSuco = new System.Windows.Forms.Label();
            this.lblValorBebida = new System.Windows.Forms.Label();
            this.lblValorBorda = new System.Windows.Forms.Label();
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(112, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(143, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nome do cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total da Fatura: ";
            // 
            // lblTotalFatura
            // 
            this.lblTotalFatura.AutoSize = true;
            this.lblTotalFatura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFatura.Location = new System.Drawing.Point(270, 244);
            this.lblTotalFatura.Name = "lblTotalFatura";
            this.lblTotalFatura.Size = new System.Drawing.Size(65, 18);
            this.lblTotalFatura.TabIndex = 6;
            this.lblTotalFatura.Text = "R$0,00";
            // 
            // lblPizzaEscolhida
            // 
            this.lblPizzaEscolhida.AutoSize = true;
            this.lblPizzaEscolhida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaEscolhida.Location = new System.Drawing.Point(12, 69);
            this.lblPizzaEscolhida.Name = "lblPizzaEscolhida";
            this.lblPizzaEscolhida.Size = new System.Drawing.Size(159, 18);
            this.lblPizzaEscolhida.TabIndex = 8;
            this.lblPizzaEscolhida.Text = "Pizza escolhida = ";
            this.lblPizzaEscolhida.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblBordaEscolhida
            // 
            this.lblBordaEscolhida.AutoSize = true;
            this.lblBordaEscolhida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBordaEscolhida.Location = new System.Drawing.Point(12, 110);
            this.lblBordaEscolhida.Name = "lblBordaEscolhida";
            this.lblBordaEscolhida.Size = new System.Drawing.Size(157, 18);
            this.lblBordaEscolhida.TabIndex = 9;
            this.lblBordaEscolhida.Text = "Borda escolhida =";
            // 
            // lblSucoEscolhido
            // 
            this.lblSucoEscolhido.AutoSize = true;
            this.lblSucoEscolhido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucoEscolhido.Location = new System.Drawing.Point(12, 198);
            this.lblSucoEscolhido.Name = "lblSucoEscolhido";
            this.lblSucoEscolhido.Size = new System.Drawing.Size(148, 18);
            this.lblSucoEscolhido.TabIndex = 10;
            this.lblSucoEscolhido.Text = "Suco escolhido =";
            // 
            // lblBebidaEscolhida
            // 
            this.lblBebidaEscolhida.AutoSize = true;
            this.lblBebidaEscolhida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaEscolhida.Location = new System.Drawing.Point(12, 153);
            this.lblBebidaEscolhida.Name = "lblBebidaEscolhida";
            this.lblBebidaEscolhida.Size = new System.Drawing.Size(166, 18);
            this.lblBebidaEscolhida.TabIndex = 11;
            this.lblBebidaEscolhida.Text = "Bebida escolhida =";
            // 
            // lblValorSuco
            // 
            this.lblValorSuco.AutoSize = true;
            this.lblValorSuco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSuco.Location = new System.Drawing.Point(270, 198);
            this.lblValorSuco.Name = "lblValorSuco";
            this.lblValorSuco.Size = new System.Drawing.Size(65, 18);
            this.lblValorSuco.TabIndex = 12;
            this.lblValorSuco.Text = "R$0,00";
            // 
            // lblValorBebida
            // 
            this.lblValorBebida.AutoSize = true;
            this.lblValorBebida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBebida.Location = new System.Drawing.Point(270, 153);
            this.lblValorBebida.Name = "lblValorBebida";
            this.lblValorBebida.Size = new System.Drawing.Size(65, 18);
            this.lblValorBebida.TabIndex = 13;
            this.lblValorBebida.Text = "R$0,00";
            // 
            // lblValorBorda
            // 
            this.lblValorBorda.AutoSize = true;
            this.lblValorBorda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBorda.Location = new System.Drawing.Point(270, 110);
            this.lblValorBorda.Name = "lblValorBorda";
            this.lblValorBorda.Size = new System.Drawing.Size(65, 18);
            this.lblValorBorda.TabIndex = 14;
            this.lblValorBorda.Text = "R$0,00";
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPizza.Location = new System.Drawing.Point(270, 69);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(65, 18);
            this.lblValorPizza.TabIndex = 15;
            this.lblValorPizza.Text = "R$0,00";
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 313);
            this.Controls.Add(this.lblValorPizza);
            this.Controls.Add(this.lblValorBorda);
            this.Controls.Add(this.lblValorBebida);
            this.Controls.Add(this.lblValorSuco);
            this.Controls.Add(this.lblBebidaEscolhida);
            this.Controls.Add(this.lblSucoEscolhido);
            this.Controls.Add(this.lblBordaEscolhida);
            this.Controls.Add(this.lblPizzaEscolhida);
            this.Controls.Add(this.lblTotalFatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.frmFatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalFatura;
        private System.Windows.Forms.Label lblPizzaEscolhida;
        private System.Windows.Forms.Label lblBordaEscolhida;
        private System.Windows.Forms.Label lblSucoEscolhido;
        private System.Windows.Forms.Label lblBebidaEscolhida;
        private System.Windows.Forms.Label lblValorSuco;
        private System.Windows.Forms.Label lblValorBebida;
        private System.Windows.Forms.Label lblValorBorda;
        private System.Windows.Forms.Label lblValorPizza;
    }
}