using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public List<Product> GetAllByCategoryId(int id);
        public List<Product> GetByUnitPrice(decimal min, decimal max);
        public Product GetById(int id);

        
    }
}
