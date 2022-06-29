namespace CalcularArea
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAltura2 = new System.Windows.Forms.TextBox();
            this.txtBase1 = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblbase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura2
            // 
            this.txtAltura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura2.Location = new System.Drawing.Point(12, 194);
            this.txtAltura2.Multiline = true;
            this.txtAltura2.Name = "txtAltura2";
            this.txtAltura2.Size = new System.Drawing.Size(100, 39);
            this.txtAltura2.TabIndex = 0;
            // 
            // txtBase1
            // 
            this.txtBase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase1.Location = new System.Drawing.Point(490, 193);
            this.txtBase1.Multiline = true;
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(95, 39);
            this.txtBase1.TabIndex = 1;
            // 
            // btnResolver
            // 
            this.btnResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.Location = new System.Drawing.Point(195, 191);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(218, 41);
            this.btnResolver.TabIndex = 2;
            this.btnResolver.Text = "RESOLVER";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(218, 266);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(159, 29);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "RESULTADO";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(131, 206);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(50, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "ALTURA";
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(435, 205);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(35, 13);
            this.lblbase.TabIndex = 5;
            this.lblbase.Text = "BASE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.txtAltura2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura2;
        private System.Windows.Forms.TextBox txtBase1;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblbase;
    }
}

