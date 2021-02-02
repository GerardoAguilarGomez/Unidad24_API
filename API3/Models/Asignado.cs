using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3.Models
{
    public class Asignado
    {
        private int id;
        private string proyecto;
        private int cientifico;

        public int Id { get => id; set => id = value; }
        public string Proyecto { get => proyecto; set => proyecto = value; }
        public int Cientifico { get => cientifico; set => cientifico = value; }
    }
}
