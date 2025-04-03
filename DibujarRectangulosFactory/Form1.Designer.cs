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
            label4 = new Label();
            txtContador = new TextBox();
            btnDibujar = new Button();
            picColor = new PictureBox();
            picLienzo = new PictureBox();
            label5 = new Label();
            cmbFigura = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLienzo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 12);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Dibujar Rectángulos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Coordenada X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 131);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Coordenada Y";
            // 
            // txtCoordenadaX
            // 
            txtCoordenadaX.Location = new Point(121, 67);
            txtCoordenadaX.Margin = new Padding(3, 4, 3, 4);
            txtCoordenadaX.Name = "txtCoordenadaX";
            txtCoordenadaX.Size = new Size(215, 27);
            txtCoordenadaX.TabIndex = 3;
            // 
            // txtCoordenadaY
            // 
            txtCoordenadaY.Location = new Point(121, 132);
            txtCoordenadaY.Margin = new Padding(3, 4, 3, 4);
            txtCoordenadaY.Name = "txtCoordenadaY";
            txtCoordenadaY.Size = new Size(220, 27);
            txtCoordenadaY.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.AutoSize = true;
            textBox6.Location = new Point(14, 204);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(45, 20);
            textBox6.TabIndex = 5;
            textBox6.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 271);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Contador";
            // 
            // txtContador
            // 
            txtContador.Location = new Point(121, 268);
            txtContador.Margin = new Padding(3, 4, 3, 4);
            txtContador.Name = "txtContador";
            txtContador.ReadOnly = true;
            txtContador.Size = new Size(110, 27);
            txtContador.TabIndex = 7;
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(14, 417);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(138, 46);
            btnDibujar.TabIndex = 8;
            btnDibujar.Text = "Dibujar";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // picColor
            // 
            picColor.BackColor = SystemColors.ControlLightLight;
            picColor.Location = new Point(121, 187);
            picColor.Name = "picColor";
            picColor.Size = new Size(122, 59);
            picColor.TabIndex = 9;
            picColor.TabStop = false;
            picColor.Click += pictureBox1_Click;
            // 
            // picLienzo
            // 
            picLienzo.BackColor = Color.White;
            picLienzo.BorderStyle = BorderStyle.FixedSingle;
            picLienzo.Location = new Point(385, 73);
            picLienzo.Name = "picLienzo";
            picLienzo.Size = new Size(504, 390);
            picLienzo.TabIndex = 10;
            picLienzo.TabStop = false;
            picLienzo.Paint += picLienzo_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 329);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Figura";
            // 
            // cmbFigura
            // 
            cmbFigura.FormattingEnabled = true;
            cmbFigura.Location = new Point(116, 325);
            cmbFigura.Name = "cmbFigura";
            cmbFigura.Size = new Size(151, 28);
            cmbFigura.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cmbFigura);
            Controls.Add(label5);
            Controls.Add(picLienzo);
            Controls.Add(picColor);
            Controls.Add(btnDibujar);
            Controls.Add(txtContador);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(txtCoordenadaY);
            Controls.Add(txtCoordenadaX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLienzo).EndInit();
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
        private Label label4;
        private TextBox txtContador;
        private Button btnDibujar;
        private PictureBox picColor;
        private PictureBox picLienzo;
        private Label label5;
        private ComboBox cmbFigura;
    }
}
