using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            IResult results = BusinessRules.Run(ProductNameAlreadyExist(product.ProductName));

            if (results != null)
            {
                return results;
            }

            _productDal.Add(product);
            return new SuccessResult("Ürün eklendi");

        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Ürün silindi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.ProductPrice >= min && p.ProductPrice <= max));
        }

        public IDataResult<List<OrderDetailDto>> GetOrderDetailDtos()
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_productDal.GetOrderDetailDtos());
        }

        public IDataResult<List<Product>> GetProductsByTerm(string term)
        {
            var result = _productDal.GetAll(p=>p.ProductName.Contains(term) || p.ProductBrand.Contains(term));
            return new SuccessDataResult<List<Product>>(result);
        }

        public IDataResult<List<Product>> GetProductsByUnitPrice()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün güncellendi");
        }

        private IResult ProductNameAlreadyExist(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult("Bu ürün isminde başka bir ürün var");
            }
            return new SuccessResult("Ürün eklendi");
        }
    }
}
