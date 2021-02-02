using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API3.Models
{
    public class Cientifico
    {
        private int id;
        private int dni;
        private string nomapels;

        public int Id { get => id; set => id = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nomapels { get => nomapels; set => nomapels = value; }
    }
}
