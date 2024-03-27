using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivoss
{
    public partial class Secuencial : Form
    {
        string archivo = "datos.txt";

        public Secuencial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string edad = textBoxEdad.Text;
            string carrera = textBoxCarrera.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(edad) && !string.IsNullOrEmpty(carrera))
            {
                using (StreamWriter sw = File.AppendText(archivo))
                {
                    sw.WriteLine($"{nombre},{edad},{carrera}");
                }

                textBoxNombre.Clear();
                textBoxEdad.Clear();
                textBoxCarrera.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();


            if (File.Exists(archivo))
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        dataGridView1.Rows.Add(datos);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar.");
            }
        }
    }
}
