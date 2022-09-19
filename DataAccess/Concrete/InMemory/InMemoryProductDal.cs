using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal: IProductDal
    {
        List<Product> _products;

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> getProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        //public InMemoryProductDal()
        //{
        //    _products = new List<Product> {
        //        new Product{ProductId=1,CategoryId=1, ProductName="Bardak",UnitsInStock=45,UnitPrice=50 },
        //        new Product{ProductId=2,CategoryId=1, ProductName="Kalem",UnitsInStock=45,UnitPrice=5 },
        //        new Product{ProductId=3,CategoryId=2, ProductName="Fare",UnitsInStock=45,UnitPrice=50 },
        //        new Product{ProductId=4,CategoryId=2, ProductName="Klavye",UnitsInStock=50,UnitPrice=200 },
        //        new Product{ProductId=5,CategoryId=3, ProductName="Kamera",UnitsInStock=60,UnitPrice=500 },
        //    };
        //}

        //public void Add(Product product)
        //{
        //    _products.Add(product);
        //}

        //public void Delete(Product product)
        //{
        //    Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

        //    _products.Remove(productToDelete);

        //}

        //public List<Product> GetAllByCategory(int categoryId)
        //{
        //    return _products.Where(p => p.CategoryId == categoryId).ToList();
        //}

        //public List<Product> GetAll()
        //{
        //    return _products;
        //}

        //public void Update(Product product)
        //{
        //    Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

        //    productToUpdate.CategoryId = product.CategoryId;
        //    productToUpdate.ProductName = product.ProductName;
        //    productToUpdate.UnitsInStock = product.UnitsInStock;
        //    productToUpdate.UnitPrice = product.UnitPrice;

        //}

        //public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

