using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionTangenteyCotangente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool dibujar = false;
        private void picFondo_Paint(object sender, PaintEventArgs e)
        {
            if (dibujar)
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    try
                    {
                        //ancho = float.Parse(txtancho.Text.ToString()+"f");
                        Graphics g = e.Graphics;
                        int width = picFondo.Width;
                        int height = picFondo.Height;
                        float scale = float.Parse(txtescala.Text.ToString());

                        // Obtiene el valor del ancho de línea del TextBox y conviértelo a float
                        if (float.TryParse(txtancho.Text, out float lineWidth))
                        {
                            if (comboBox1.SelectedIndex==1)
                            DibujarGraficoTangente(g, width, height, scale, lineWidth);
                            else
                                DibujarCotangente(g, width, height, scale, lineWidth);
                        }
                    }
                    catch (Exception ne)
                    {
                        MessageBox.Show("Ingrese correcto los parametros: " + ne.Message);
                    }
                }
            }
        }
        private void DibujarGraficoTangente(Graphics g, int width, int height, float scale, float lineWidth)
        {
            Pen pen = new Pen(Color.Blue)
            {
                Width = lineWidth // Configura el ancho de la línea
            };

            for (int x = 0; x < width; x++)
            {
                float angle = (x - width / 2) / scale;
                float y = (float)Math.Tan(angle);

                int yCoord = height / 2 - (int)(y * scale);

                g.DrawLine(pen, x, yCoord, x + 1, yCoord);
            }
            pen.Dispose();
        }
        private void DibujarCotangente(Graphics g, int width, int height, float scale, float lineWidth)
        {
            Pen pen = new Pen(Color.Red)
            {
                Width = lineWidth // Configura el ancho de la línea
            };

            for (int x = 0; x < width; x++)
            {
                float angle = (x - width / 2) / scale;
                float cotangent = (float)Math.Cos(angle) / (float)Math.Sin(angle); // Calcula la cotangente

                // Evita que la cotangente se vuelva infinita (cotangente infinita en ángulos múltiplos de PI)
                if (!float.IsInfinity(cotangent))
                {
                    int yCoord = height / 2 - (int)(cotangent * scale);

                    g.DrawLine(pen, x, yCoord, x + 1, yCoord);
                }
            }

            pen.Dispose();
        }
        private void btnTangente_Click(object sender, EventArgs e)
        {
            dibujar = true;
            picFondo.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
