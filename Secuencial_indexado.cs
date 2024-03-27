using Microsoft.Win32;
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
    public partial class Secuencial_indexado: Form
    {
        private Dictionary<string, Registro> registros;
        private string archivo = "datos_indexados.txt"; 

        public Secuencial_indexado()
        {
            InitializeComponent();
            registros = new Dictionary<string, Registro>();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombre = textBoxNombre.Text;
            int edad;
            string carrera = textBoxCarrera.Text;

            
            if (!string.IsNullOrEmpty(nombre) && int.TryParse(textBoxEdad.Text, out edad) && !string.IsNullOrEmpty(carrera))
            {
               
                Registro nuevoRegistro = new Registro(nombre, edad, carrera);

                
                if (!registros.ContainsKey(nombre))
                {
                    
                    registros.Add(nombre, nuevoRegistro);

                    
                    using (StreamWriter sw = File.AppendText(archivo))
                    {
                        sw.WriteLine(nuevoRegistro.ToString());
                    }

                    
                    textBoxNombre.Clear();
                    textBoxEdad.Clear();
                    textBoxCarrera.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente antes de guardar.");
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
                        if (datos.Length == 3)
                        {
                            string nombre = datos[0];
                            int edad;
                            if (int.TryParse(datos[1], out edad))
                            {
                                string carrera = datos[2];
                               
                                Registro registro = new Registro(nombre, edad, carrera);
                                registros[nombre] = registro;
                                dataGridView1.Rows.Add(registro.Nombre, registro.Edad, registro.Carrera);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar.");
            }
        }
            
        private class Registro
        {
            public string Nombre { get; }
            public int Edad { get; }
            public string Carrera { get; }

            public Registro(string nombre, int edad, string carrera)
            {
                Nombre = nombre;
                Edad = edad;
                Carrera = carrera;
            }

            public override string ToString()
            {
                return $"{Nombre},{Edad},{Carrera}";
            }
        }
    }
}
