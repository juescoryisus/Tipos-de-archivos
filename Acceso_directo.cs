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
    public partial class Acceso_directo : Form
    {
        private Dictionary<int, Registro> registros; 
       
        public Acceso_directo()
        {
            InitializeComponent();
            registros = new Dictionary<int, Registro>();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatosDesdeFuenteExterna();

            MostrarDatosEnDataGridView();
        }

        private void CargarDatosDesdeFuenteExterna()
        {
            
            registros.Clear();
            registros.Add(1, new Registro("Jesus", 19, "Informatica"));
            registros.Add(2, new Registro("Jose", 19, "Gestion"));
            registros.Add(3, new Registro("Sofia", 20, "Industrial"));
        }

        private void MostrarDatosEnDataGridView()
        {
           
            dataGridView1.Rows.Clear();

            
            foreach (var registro in registros.Values)
            {
                dataGridView1.Rows.Add(registro.Nombre, registro.Edad, registro.Carrera);
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

        }
    }
}
