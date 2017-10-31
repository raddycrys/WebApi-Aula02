using System.Collections.Generic;
using System.Web.Http;

namespace Aula02
{
    [RoutePrefix("api/palindromo")]
    public class PalindromoController : ApiController
    {
        /// <summary>
        /// teste do controler do rodrigão
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
        /// teste
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