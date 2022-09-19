using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllByCategoryId(int id);

        List<Product> GetAllByUnitPrice(int min, int max);

        List<ProductDetailDto> GetProductDetail();

        Product GetById(int productId);

        IResults Add(Product product);

    }
}

