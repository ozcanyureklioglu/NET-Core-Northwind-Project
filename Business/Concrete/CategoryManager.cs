using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {

        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _CategoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _CategoryDal.Get(c => c.category_id == id);
        }
    }
}

