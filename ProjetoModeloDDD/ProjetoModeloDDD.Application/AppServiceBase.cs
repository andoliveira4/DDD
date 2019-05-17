using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _servicebase;

        public AppServiceBase(IServiceBase<TEntity> servicebase)
        {
            _servicebase = servicebase;
        }

        public void Add(TEntity obj)
        {
            _servicebase.Add(obj);
        }        

        public IEnumerable<TEntity> GetAll()
        {
            return _servicebase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _servicebase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _servicebase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _servicebase.Update(obj);
        }

        public void Dispose()
        {
            _servicebase.Dispose();
        }

    }
}
