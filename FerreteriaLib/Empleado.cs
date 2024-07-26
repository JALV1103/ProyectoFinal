using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaLib
{
    public class Empleado : Personas
    {
        private string _area;

        public string Area { get => _area; set => _area = value; }

        public Empleado():base()
        {
            _area = "";
        }

        public Empleado(
            string id,
            string nombre,
            string correo,
            string telefono,
            string area
            ): base(id, nombre, correo, telefono){

            _area = area;
        }

        public string obtenerPerfil()
        {
            return "Nombre: " + Nombre + "Area: " + Area + "Id: " + Id;
        }
    }
}
