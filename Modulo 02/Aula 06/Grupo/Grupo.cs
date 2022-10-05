using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo
{
    public class Grupo
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Grupo CadastrarGrupo(string nome, string desc)
        {
            Grupo grp = new Grupo();

            grp.Nome = nome;
            grp.Descricao = desc;

            return grp;
        }
    }
}
