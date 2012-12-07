using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FKArch.Repository.Interfaces;
using FKArch.IoC;
using FKArch.Domain;

namespace FKArch.Core
{
    public class ProductCore
    {
        public IList<Product> GetAll()
        {
            IRepository repository = RepositoryFactory.GetRepository<IRepository>();
            try
            {
                IList<Product>  products = repository.GetAll<Product>();
                return products;
            }
            catch (Exception ex) { throw; }
            finally { repository.Dispose(); }
        }
        public IList<Product> GetProductByStatus(bool status)
        {
            IRepository repository = RepositoryFactory.GetRepository<IRepository>();
            try
            {
                IList<Product> criteriaProducts = repository.Find<Product>(p => p.Status == status);
                return criteriaProducts;
            }
            catch (Exception ex) { throw; }
            finally { repository.Dispose(); }
        }
    }
}
