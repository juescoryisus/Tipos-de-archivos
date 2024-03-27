using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void secuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secuencial ventanaDiseño = new Secuencial();
            ventanaDiseño.Text = "Archivo Secuencial";

            ventanaDiseño.ShowDialog();
        }

        private void secuencialIndexadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secuencial_indexado ventanaDiseño = new Secuencial_indexado();
            ventanaDiseño.Text = "Archivo Secuencial indexado";

            ventanaDiseño.ShowDialog();
        }

        private void accesoDirectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acceso_directo ventanaDiseño = new Acceso_directo();
            ventanaDiseño.Text = "Archivo Secuencial indexado";

            ventanaDiseño.ShowDialog();
        }
    }
}
