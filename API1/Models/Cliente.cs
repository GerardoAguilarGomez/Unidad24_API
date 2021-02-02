using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1.Models
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private int dni;
        private DateTime fecha;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
