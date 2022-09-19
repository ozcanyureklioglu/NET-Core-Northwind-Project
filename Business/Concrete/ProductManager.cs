using System;
using System.Collections.Generic;
using Business.Abstract;
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

        public List<ProductDetailDto> GetProductDetail()
        {
            return _ProductDal.getProductDetails();
        }
    }
}

