using AutoMapper;
using Business.Abstract;
using Business.Constants.Abstract;
using Business.ValidationRules.FluentValidation.Category;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Categories;
using Entities.DTOs.Customers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    /*
    public class CategoryManager : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IMessage _message;
        private readonly ICategoryDal _categoryDal;
        //private readonly IServiceProvider _serviceProvider;
        private IProductService _productService;

        public CategoryManager(IServiceProvider serviceProvider,IProductService productService,
            IMapper mapper,ICategoryDal categoryDal,IMessage message)
        {
            _mapper = mapper;
            _message = message;
            _categoryDal = categoryDal;
            //_serviceProvider = serviceProvider;
            _productService = productService;
        }

        [ValidationAspect(typeof(CategoryAddValidator))]
        public IResult Add(CategoryAddDto categoryAddDto)
        {
            var result = BusinessRules.Run(this.CheckIfCategoryNameExist(categoryAddDto.CategoryName));
            if (!result.Success) {
                return result;
            }

            try {
                Category category = _mapper.Map<Category>(categoryAddDto);
                _categoryDal.Add(category);
                return new SuccessResult(_message.CategoryAdded);
            }
            catch (Exception) {
                return new ErrorResult(_message.CategoryNotAdded);
            }
        }

        [ValidationAspect(typeof(CategoryDeleteValidator))]
        public IResult Delete(CategoryDeleteDto categoryDeleteDto)
        {
            try {
                Category? category = _categoryDal.Get(c => c.CategoryId == categoryDeleteDto.CategoryId);
                if (category != null) {
                    // Kategoriye Ait Ürün Kaydı Var mı Kontrol Et
                    var result = BusinessRules.Run(this.CheckIfProductExistForCategory(categoryDeleteDto.CategoryId));
                    if (!result.Success)
                    {
                        return result;
                    }
                    _categoryDal.Delete(c => c.CategoryId == categoryDeleteDto.CategoryId);
                    return new SuccessResult(_message.CategoryDeleted);
                }
                return new ErrorResult(_message.CategoryNotFound);
            }
            catch (Exception) {
                return new ErrorResult();
            }
        }

        public IDataResult<List<Category>> GetAll()
        {
            List<Category> categories = _categoryDal.GetAll();
            if (categories.Count > 0)
            {
                return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
            }
            return new ErrorDataResult<List<Category>>(categories);
        }

        [ValidationAspect(typeof(CategoryUpdateValidator))]
        public IResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            try {
                Category? category = _categoryDal.Get(c => c.CategoryId == categoryUpdateDto.CategoryId);
                if (category != null) {
                    var result = BusinessRules.Run(this.CheckIfCategoryNameExist(categoryUpdateDto.CategoryName, categoryUpdateDto.CategoryId));
                    if (!result.Success)
                    {
                        return result;
                    }
                    _mapper.Map(categoryUpdateDto,category);
                    _categoryDal.Update(category);
                    return new SuccessResult(_message.CategoryUpdated);
                }
                return new ErrorResult(_message.CategoryNotFound);
            }
            catch (Exception) {
                return new ErrorResult(_message.CategoryNotUpdated);
            }
        }

        public IDataResult<Category> GetById(long categoryId)
        {
            Category? category = _categoryDal.Get(c => c.CategoryId == categoryId);
            if (category!=null) {
                return new SuccessDataResult<Category>(category);
            }
            return new ErrorDataResult<Category>();
        }

        private IResult CheckIfProductExistForCategory(long categoryId)
        {
            // $this->productService = App(IProductService::class);
            //_productService = _serviceProvider.GetRequiredService<IProductService>(); // setter enjeksiyon
            var result = _productService.GetByCategoryId(categoryId);
            if (result.Success) {
                return new ErrorResult(_message.ProductExistForCategory);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCategoryNameExist(string categoryName,long categoryId=0)
        {
            Category? category = _categoryDal.Get(c => c.CategoryName == categoryName && c.CategoryId != categoryId);
            if (category!=null) {
                return new ErrorResult(_message.CategoryNameAlreadyExist);
            }
            return new SuccessResult();
        }

    }
    */
}
