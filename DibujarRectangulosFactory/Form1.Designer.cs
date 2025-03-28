namespace DibujarRectangulosFactory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCoordenadaX = new TextBox();
            txtCoordenadaY = new TextBox();
            textBox6 = new Label();
            iptColor = new ColorDialog();
            label4 = new Label();
            txtContador = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Dibujar Rectángulos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Coordenada X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Coordenada Y";
            // 
            // txtCoordenadaX
            // 
            txtCoordenadaX.Location = new Point(106, 50);
            txtCoordenadaX.Name = "txtCoordenadaX";
            txtCoordenadaX.Size = new Size(189, 23);
            txtCoordenadaX.TabIndex = 3;
            // 
            // txtCoordenadaY
            // 
            txtCoordenadaY.Location = new Point(106, 99);
            txtCoordenadaY.Name = "txtCoordenadaY";
            txtCoordenadaY.Size = new Size(193, 23);
            txtCoordenadaY.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.AutoSize = true;
            textBox6.Location = new Point(12, 153);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(36, 15);
            textBox6.TabIndex = 5;
            textBox6.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 206);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Contador";
            // 
            // txtContador
            // 
            txtContador.Location = new Point(106, 198);
            txtContador.Name = "txtContador";
            txtContador.ReadOnly = true;
            txtContador.Size = new Size(97, 23);
            txtContador.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContador);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(txtCoordenadaY);
            Controls.Add(txtCoordenadaX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCoordenadaX;
        private TextBox txtCoordenadaY;
        private Label textBox6;
        private ColorDialog iptColor;
        private Label label4;
        private TextBox txtContador;
    }
}
