using AutoMapper;
using Business.Abstract;
using Business.Constants.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Todos;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TodoManager : ITodoService
    {
        private IMapper _mapper;
        private IMessage _message;
        private ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal,IMapper mapper,IMessage message)
        {
            _mapper = mapper;
            _message = message;
            _todoDal = todoDal;
        }

        public IResult Add(TodoAddDto todoAddDto)
        {
            Todo todo = _mapper.Map<Todo>(todoAddDto);
            try
            {
               _todoDal.Add(todo);
                return new SuccessResult(_message.TodoAdded);
            }
            catch (Exception) {
                return new ErrorResult(_message.TodoNotAdded);
            }
        }

        public IResult Delete(int taskId)
        {
            Todo? todo = _todoDal.Get(t=>t.TitleId == taskId);
            if (todo != null)
            {
                _todoDal.Delete(t => t.TitleId == taskId);
                return new SuccessResult(_message.TodoDeleted);
            }
            return new ErrorResult(_message.TodoNotFound);
        }

        public IDataResult<Todo> Get(int taskId)
        {
            Todo? todo = _todoDal.Get(t => t.TitleId == taskId);
            if (todo!=null)
            {
                return new SuccessDataResult<Todo>(todo);
            }
            return new ErrorDataResult<Todo>();
        }

        public IDataResult<List<Todo>> GetAll()
        {
            List<Todo> todos = _todoDal.GetAll();
            if (todos.Count > 0)
            {
                return new SuccessDataResult<List<Todo>>(todos);
            }
            return new ErrorDataResult<List<Todo>>(todos);
        }

        public IResult Update(int taskId,TodoUpdateDto todoUpdateDto)
        {
            try
            {
                Todo? todo = _todoDal.Get(t => t.TitleId == taskId);
                if (todo != null)
                {
                    _mapper.Map(todoUpdateDto, todo);
                    _todoDal.Update(todo);

                    return new SuccessResult(_message.TodoUpdated);
                }
                return new ErrorResult(_message.TodoNotFound);
            }
            catch (Exception ex) {
                return new ErrorResult(ex.Message);
            }
            
        }

    }
}
