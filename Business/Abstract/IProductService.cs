using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IDataResult<List<Product>> GetAllByUnitPrice(int min, int max);

        IDataResult<List<ProductDetailDto>> GetProductDetail();

        IDataResult<Product> GetById(int productId);

        IResults Add(Product product);

    }
}

