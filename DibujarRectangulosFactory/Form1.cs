namespace DibujarRectangulosFactory
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    picColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                int x; int y;
                if (!int.TryParse(txtCoordenadaX.Text, out x))
                {
                    MessageBox.Show("Ingrese valores numéricos válidos para X", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txtCoordenadaY.Text, out y))
                {
                    MessageBox.Show("Ingrese valores numéricos válidos para Y", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(x < 0 || y < 0)
                    {
                        throw new ArgumentOutOfRangeException("Las coordenadas no pueden ser negativas.");
                    }
                    else
                    {
                        x = Math.Max(0, Math.Min(x, picLienzo.Width - 50));  // Evita salir del ancho
                        y = Math.Max(0, Math.Min(y, picLienzo.Height - 50)); // Evita salir del alto

                        Color colorSeleccionado = picColor.BackColor;

                        Figura nuevoRectangulo = FiguraFactory.CrearRectangulo(colorSeleccionado, x, y);
                        figuras.Add(nuevoRectangulo);

                        txtContador.Text = figuras.Count().ToString();

                        LimpiarCampos();
                        picLienzo.Invalidate();
                    }
                    
                }


            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtCoordenadaX.Clear();
            txtCoordenadaY.Clear();
            picColor.BackColor = Color.White;
        }

        private void picLienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var figura in figuras)
            {
                figura.Dibujar(g);
            }
        }

    }
}

