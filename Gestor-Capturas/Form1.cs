using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestor_Capturas
{
    public partial class Form1 : Form
    {
        private Control focusedControl;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (focusedControl is PictureBox pictureBox && pictureBox.Enabled)
            {
                if (Clipboard.ContainsImage())
                {
                    Image img = Clipboard.GetImage();
                    pictureBox.Image = img;
                }
                else
                {
                    MessageBox.Show("No hay imagen en el portapapeles.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un PictureBox activo.");
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (focusedControl is PictureBox pictureBox && pictureBox.Enabled && pictureBox.Image != null)
            {
                Clipboard.SetImage(pictureBox.Image);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un PictureBox activo con una imagen.");
            }
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            focusedControl = clickedPictureBox;

        }
    }
}
