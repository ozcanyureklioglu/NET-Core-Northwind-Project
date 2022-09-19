using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public IResults Add(Product product)
        {
            _ProductDal.Add(product);

            return new Result(true,"Ürün eklendi.");

        }

        public List<Product> GetAll()
        {
            return _ProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(p => p.category_id == id);
        }

        public List<Product> GetAllByUnitPrice(int min, int max)
        {
            return _ProductDal.GetAll(p => p.unit_price >= min && p.unit_price <= max);
        }

        public Product GetById(int productId)
        {
            return _ProductDal.Get(p => p.product_id == productId);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            return _ProductDal.getProductDetails();
        }
    }
}

