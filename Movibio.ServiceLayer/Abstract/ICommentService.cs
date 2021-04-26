using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CommentDtos;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface ICommentService
    {
        //Task<IDataResult<Comment>> Get(int commentId);
        Task<IDataResult<IList<Comment>>> GetAll();
        Task<IDataResult<Comment>> Insert(CommentInsertDto commentInsertDto);
        //Task<IDataResult<Comment>> Update();
        Task<IDataResult<Comment>> Delete(int commentId);
    }
}
