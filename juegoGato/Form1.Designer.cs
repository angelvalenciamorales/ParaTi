namespace juegoGato
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
            this.btnLimp = new System.Windows.Forms.Button();
            this.txtDat1 = new System.Windows.Forms.TextBox();
            this.txtDat6 = new System.Windows.Forms.TextBox();
            this.txtDat5 = new System.Windows.Forms.TextBox();
            this.txtDat4 = new System.Windows.Forms.TextBox();
            this.txtDat3 = new System.Windows.Forms.TextBox();
            this.txtDat2 = new System.Windows.Forms.TextBox();
            this.txtDat8 = new System.Windows.Forms.TextBox();
            this.txtDat9 = new System.Windows.Forms.TextBox();
            this.txtDat7 = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(528, 393);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(285, 64);
            this.btnLimp.TabIndex = 0;
            this.btnLimp.Text = "button1";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // txtDat1
            // 
            this.txtDat1.Location = new System.Drawing.Point(475, 142);
            this.txtDat1.Name = "txtDat1";
            this.txtDat1.Size = new System.Drawing.Size(100, 31);
            this.txtDat1.TabIndex = 1;
            this.txtDat1.TextChanged += new System.EventHandler(this.txtDat1_TextChanged);
            // 
            // txtDat6
            // 
            this.txtDat6.Location = new System.Drawing.Point(765, 210);
            this.txtDat6.Name = "txtDat6";
            this.txtDat6.Size = new System.Drawing.Size(100, 31);
            this.txtDat6.TabIndex = 2;
            this.txtDat6.TextChanged += new System.EventHandler(this.txtDat6_TextChanged);
            // 
            // txtDat5
            // 
            this.txtDat5.Location = new System.Drawing.Point(623, 210);
            this.txtDat5.Name = "txtDat5";
            this.txtDat5.Size = new System.Drawing.Size(100, 31);
            this.txtDat5.TabIndex = 3;
            // 
            // txtDat4
            // 
            this.txtDat4.Location = new System.Drawing.Point(475, 210);
            this.txtDat4.Name = "txtDat4";
            this.txtDat4.Size = new System.Drawing.Size(100, 31);
            this.txtDat4.TabIndex = 4;
            this.txtDat4.TextChanged += new System.EventHandler(this.txtDat4_TextChanged);
            // 
            // txtDat3
            // 
            this.txtDat3.Location = new System.Drawing.Point(765, 142);
            this.txtDat3.Name = "txtDat3";
            this.txtDat3.Size = new System.Drawing.Size(100, 31);
            this.txtDat3.TabIndex = 5;
            this.txtDat3.TextChanged += new System.EventHandler(this.txtDat3_TextChanged);
            // 
            // txtDat2
            // 
            this.txtDat2.Location = new System.Drawing.Point(623, 142);
            this.txtDat2.Name = "txtDat2";
            this.txtDat2.Size = new System.Drawing.Size(100, 31);
            this.txtDat2.TabIndex = 6;
            this.txtDat2.TextChanged += new System.EventHandler(this.txtDat2_TextChanged);
            // 
            // txtDat8
            // 
            this.txtDat8.Location = new System.Drawing.Point(623, 263);
            this.txtDat8.Name = "txtDat8";
            this.txtDat8.Size = new System.Drawing.Size(100, 31);
            this.txtDat8.TabIndex = 7;
            this.txtDat8.TextChanged += new System.EventHandler(this.txtDat8_TextChanged);
            // 
            // txtDat9
            // 
            this.txtDat9.Location = new System.Drawing.Point(765, 263);
            this.txtDat9.Name = "txtDat9";
            this.txtDat9.Size = new System.Drawing.Size(100, 31);
            this.txtDat9.TabIndex = 8;
            this.txtDat9.TextChanged += new System.EventHandler(this.txtDat9_TextChanged);
            // 
            // txtDat7
            // 
            this.txtDat7.Location = new System.Drawing.Point(475, 263);
            this.txtDat7.Name = "txtDat7";
            this.txtDat7.Size = new System.Drawing.Size(100, 31);
            this.txtDat7.TabIndex = 9;
            this.txtDat7.TextChanged += new System.EventHandler(this.txtDat7_TextChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(1052, 197);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(18, 25);
            this.lblFinal.TabIndex = 10;
            this.lblFinal.Text = "f";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 557);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.txtDat7);
            this.Controls.Add(this.txtDat9);
            this.Controls.Add(this.txtDat8);
            this.Controls.Add(this.txtDat2);
            this.Controls.Add(this.txtDat3);
            this.Controls.Add(this.txtDat4);
            this.Controls.Add(this.txtDat5);
            this.Controls.Add(this.txtDat6);
            this.Controls.Add(this.txtDat1);
            this.Controls.Add(this.btnLimp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.TextBox txtDat1;
        private System.Windows.Forms.TextBox txtDat6;
        private System.Windows.Forms.TextBox txtDat5;
        private System.Windows.Forms.TextBox txtDat4;
        private System.Windows.Forms.TextBox txtDat3;
        private System.Windows.Forms.TextBox txtDat2;
        private System.Windows.Forms.TextBox txtDat8;
        private System.Windows.Forms.TextBox txtDat9;
        private System.Windows.Forms.TextBox txtDat7;
        private System.Windows.Forms.Label lblFinal;
    }
}

