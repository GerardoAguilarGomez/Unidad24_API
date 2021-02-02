using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Models
{
    public class Video
    {
        private int id;
        private string titulo;
        private string director;
        private int cliente_id;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
    }
}
