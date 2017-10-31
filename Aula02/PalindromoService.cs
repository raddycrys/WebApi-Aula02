using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula02
{
    public class PalindromoService
    {
        /// <summary>
        /// teste do rodrigão
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public bool IsPalindromo(string texto)
        {
            return texto == texto.Reverter();
        }

        public List<string> ListarPalindromo(List<string> listaTexto)
        {
            var retorno = new List<string>();

            foreach (var item in listaTexto)
            {
               if (IsPalindromo(item.Reverter()))
                  retorno.Add(item);
            }

            return retorno;
        }
    }
}