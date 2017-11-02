using Aula02.Model.Base;
using System;

namespace Aula02.Model
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public TipoSexo Sexo { get; set; }
        public bool Ativo { get; set; }
    }

    public enum TipoSexo
    {
        Feminino = 1,
        Masculino = 2
    }       
}