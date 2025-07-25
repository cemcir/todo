using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Categories;
using Entities.DTOs.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IResult Add(CategoryAddDto categoryAddDto);
        IResult Update(CategoryUpdateDto categoryUpdateDto);
        IResult Delete(CategoryDeleteDto categoryDeleteDto);
        IDataResult<Category> GetById(long categoryId);
    }
}
