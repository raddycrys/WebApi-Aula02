using System.Collections.Generic;
using System.Web.Http;

namespace Aula02.Controller
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/palindromo")]
    public class PalindromoController : ApiController
    {
        /// <summary>
        /// Controller que verifica se a palavra passada é Palindromo
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("IsPalindromo/{texto}")]        
        public bool GetIsPalindromo(string texto)
        {
            var palindromoService = new PalindromoService();

            return palindromoService.IsPalindromo(texto);
        }

        /// <summary>
        /// Controller que verifica da lista de palavras passadas quais são palindromas e retorna uma lista somente com as palindromas
        /// </summary>
        /// <param name="listaTexto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetListarPalindromo")]
        public List<string> GetListarPalindromo([FromBody]List<string> listaTexto)
        {
            var palindromoService = new PalindromoService();

            return palindromoService.ListarPalindromo(listaTexto);
        }
    }
}