namespace EjemploDepuracionCodigoCSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lvnumeros = new System.Windows.Forms.ListView();
            this.btnrellenar = new System.Windows.Forms.Button();
            this.lbvalores = new System.Windows.Forms.ListBox();
            this.btnfibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo con uso del ciclo Mientras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un valor:";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(136, 114);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(72, 47);
            this.txtnumero.TabIndex = 2;
            // 
            // lvnumeros
            // 
            this.lvnumeros.Location = new System.Drawing.Point(351, 114);
            this.lvnumeros.Name = "lvnumeros";
            this.lvnumeros.Size = new System.Drawing.Size(82, 324);
            this.lvnumeros.TabIndex = 3;
            this.lvnumeros.UseCompatibleStateImageBehavior = false;
            // 
            // btnrellenar
            // 
            this.btnrellenar.Location = new System.Drawing.Point(224, 114);
            this.btnrellenar.Name = "btnrellenar";
            this.btnrellenar.Size = new System.Drawing.Size(103, 47);
            this.btnrellenar.TabIndex = 4;
            this.btnrellenar.Text = "Rellenar";
            this.btnrellenar.UseVisualStyleBackColor = true;
            this.btnrellenar.Click += new System.EventHandler(this.btnrellenar_Click);
            // 
            // lbvalores
            // 
            this.lbvalores.FormattingEnabled = true;
            this.lbvalores.Location = new System.Drawing.Point(449, 114);
            this.lbvalores.Name = "lbvalores";
            this.lbvalores.Size = new System.Drawing.Size(99, 316);
            this.lbvalores.TabIndex = 5;
            // 
            // btnfibonacci
            // 
            this.btnfibonacci.Location = new System.Drawing.Point(225, 176);
            this.btnfibonacci.Name = "btnfibonacci";
            this.btnfibonacci.Size = new System.Drawing.Size(103, 47);
            this.btnfibonacci.TabIndex = 6;
            this.btnfibonacci.Text = "Fibonacci";
            this.btnfibonacci.UseVisualStyleBackColor = true;
            this.btnfibonacci.Click += new System.EventHandler(this.btnfibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnfibonacci);
            this.Controls.Add(this.lbvalores);
            this.Controls.Add(this.btnrellenar);
            this.Controls.Add(this.lvnumeros);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ListView lvnumeros;
        private System.Windows.Forms.Button btnrellenar;
        private System.Windows.Forms.ListBox lbvalores;
        private System.Windows.Forms.Button btnfibonacci;
    }
}

