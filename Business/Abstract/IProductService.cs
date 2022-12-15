using Core.Utilities.Results;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetProductsByTerm(string term);
        IDataResult<List<OrderDetailDto>> GetOrderDetailDtos();
        IDataResult<List<Product>> GetProductsByUnitPrice();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);



    }
}
