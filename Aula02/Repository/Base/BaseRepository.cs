using Aula02.Model.Base;
using System.Collections.Generic;
using System.Linq;

namespace Aula02.Repository.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Lista que será usada como nosso banco de dados
        /// </summary>
        protected static List<T> _lista;

        /// <summary>
        /// Método construtor que irá popular a lista quando instanciado
        /// </summary>
        public BaseRepository()
        { 
            if (_lista == null)
                PopularLista();
        }

        /// <summary>
        /// Método responsável por popular a lista 
        /// </summary>
        /// <returns></returns>
        protected abstract List<T> PopularLista();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return _lista.Where(p => p.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _lista;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var p = GetById(id);

            if (p != null)
                _lista.Remove(p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            var p = GetById(entity.Id);

            if (p == null) return;

            var i = _lista.IndexOf(p);

            _lista[i] = p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            _lista.Add(entity);
        }
   
    }
}