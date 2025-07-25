using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Todos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITodoService
    {
        public IResult Add(TodoAddDto todoAddDto);
        public IDataResult<Todo> Get(int taskId);
        public IResult Update(int taskId,TodoUpdateDto todoUpdateDto);
        public IDataResult<List<Todo>> GetAll();
        public IResult Delete(int taskId);
    }
}
