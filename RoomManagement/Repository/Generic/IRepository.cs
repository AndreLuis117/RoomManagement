using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {

        #region Métodos genéricos sincronos

        public IEnumerable<T> GetAll();
        public T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        #endregion

        #region Métodos genéricos assincronos

        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);

        #endregion


    }
}
