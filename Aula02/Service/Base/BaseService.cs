using Aula02.Model.Base;
using Aula02.Repository.Base;

namespace Aula02.Service.Base
{
    public abstract class BaseService<T> where T : BaseEntity
    {
        private readonly BaseRepository<T> _baseRepository;

        public BaseService(BaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T GetById(int Id)
        {
            return _baseRepository.GetById(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Inserir(T entity)
        {
            _baseRepository.Insert(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Alterar(T entity)
        {
            _baseRepository.Update(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Remover(int id)
        {
            _baseRepository.Delete(id);
        }
    }
}
