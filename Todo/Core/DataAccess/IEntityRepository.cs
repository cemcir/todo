using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
     // aşağıdaki kodun php kodu
    //interface IEloquentRepository {
        // public function GetAll() :array;
        // public function Get($id) :array;
        // public function Add($arr):void;
        // public function Update($arr):void;
        // public function Delete($id):void;
    //}
    public interface IEntityRepository<T> where T : class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T? Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        //Task AddAsync(T entity);
        void Update(T entity);
        void AddRange(List<T> entities);
        void Delete(Expression<Func<T, bool>> filter);
        int TotalRecord(Expression<Func<T, bool>> filter = null);
    }
}
