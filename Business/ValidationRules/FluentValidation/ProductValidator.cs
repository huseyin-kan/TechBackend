using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz");
            RuleFor(p => p.ProductBrand).NotEmpty().WithMessage("Ürün markası boş olamaz");
            RuleFor(p => p.ProductPrice).GreaterThan(0).NotEmpty().WithMessage("Ürün ücreti sıfırdan büyük olmalı ve boş olmamalı");
            RuleFor(p => p.CategoryId).NotEmpty().GreaterThan(0).LessThan(11).WithMessage("Kategoriyi boş bırakmayın ya da uygun bir kategori girin");

        }
    }
}
