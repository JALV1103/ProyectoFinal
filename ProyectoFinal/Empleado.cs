using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerreteriaLib;
using System.Xml.Serialization;

namespace ProyectoFinal
{
    public partial class Empleado : Form
    {
        private FerreteriaLib.Empleado Empleado1;
        private FerreteriaLib.Empleado Empleado2;
        public List<FerreteriaLib.Empleado> Empleados;
        public Empleado()
        {
            InitializeComponent();
            
            Empleados = new List<FerreteriaLib.Empleado>();

            Empleado1 = new FerreteriaLib.Empleado( "1 ", "Jose Castro ", " correo@uncorreo.com ", " 96969696 ", "Construccion ");
            Empleado2 = new FerreteriaLib.Empleado( " 2 ", "Maria Moncada ", " correo@uncorreo.com ", " 15151515 ", " Electricidad ");


            Empleados.Add(Empleado1);
            Empleados.Add(Empleado2);

            lblTexto.Text = Empleado1.obtenerPerfil();
            lblEmpleado2.Text = Empleado2.obtenerPerfil();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(Empleados, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }

    }
}
