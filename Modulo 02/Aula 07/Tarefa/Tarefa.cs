using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa
{
    public class Tarefa
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string DataPrevista { get; set; }

        public int StatusTarefa { get; set; }
    }
}
