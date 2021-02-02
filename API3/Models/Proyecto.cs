using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3.Models
{
    public class Proyecto
    {
        private int id;
        private string nombre;
        private int horas;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Horas { get => horas; set => horas = value; }
    }
}
