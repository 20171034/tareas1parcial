
namespace tarea1
{
    partial class par
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
            this.NumerotextBox1 = new System.Windows.Forms.TextBox();
            this.resultadotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadobutton = new System.Windows.Forms.Button();
            this.limpiarbutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.impartextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el Numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumerotextBox1
            // 
            this.NumerotextBox1.Location = new System.Drawing.Point(169, 38);
            this.NumerotextBox1.Name = "NumerotextBox1";
            this.NumerotextBox1.Size = new System.Drawing.Size(142, 20);
            this.NumerotextBox1.TabIndex = 1;
            // 
            // resultadotextBox
            // 
            this.resultadotextBox.Location = new System.Drawing.Point(148, 96);
            this.resultadotextBox.Name = "resultadotextBox";
            this.resultadotextBox.Size = new System.Drawing.Size(142, 20);
            this.resultadotextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "el Numero es: ";
            // 
            // resultadobutton
            // 
            this.resultadobutton.Location = new System.Drawing.Point(73, 155);
            this.resultadobutton.Name = "resultadobutton";
            this.resultadobutton.Size = new System.Drawing.Size(150, 58);
            this.resultadobutton.TabIndex = 4;
            this.resultadobutton.Text = "iniciar";
            this.resultadobutton.UseVisualStyleBackColor = true;
            this.resultadobutton.Click += new System.EventHandler(this.resultadobutton_Click);
            // 
            // limpiarbutton1
            // 
            this.limpiarbutton1.Location = new System.Drawing.Point(258, 155);
            this.limpiarbutton1.Name = "limpiarbutton1";
            this.limpiarbutton1.Size = new System.Drawing.Size(99, 58);
            this.limpiarbutton1.TabIndex = 5;
            this.limpiarbutton1.Text = "Limpiar";
            this.limpiarbutton1.UseVisualStyleBackColor = true;
            this.limpiarbutton1.Click += new System.EventHandler(this.limpiarbutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Par/Impar";
            // 
            // impartextBox1
            // 
            this.impartextBox1.Location = new System.Drawing.Point(390, 103);
            this.impartextBox1.Name = "impartextBox1";
            this.impartextBox1.Size = new System.Drawing.Size(142, 20);
            this.impartextBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Impar / Par";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // par
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.impartextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limpiarbutton1);
            this.Controls.Add(this.resultadobutton);
            this.Controls.Add(this.resultadotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumerotextBox1);
            this.Controls.Add(this.label1);
            this.Name = "par";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerotextBox1;
        private System.Windows.Forms.TextBox resultadotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resultadobutton;
        private System.Windows.Forms.Button limpiarbutton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox impartextBox1;
        private System.Windows.Forms.Button button1;
    }
}

