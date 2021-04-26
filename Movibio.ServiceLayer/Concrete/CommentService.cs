using AutoMapper;
using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CommentDtos;
using Movibio.ServiceLayer.Abstract;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using Movibio.SharedLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CommentService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<IList<Comment>>> GetAll()
        {
            var comments = await _unitOfWork.Comments.GetAllAsync(null);

            if (comments.Count > 0)
                return new DataResult<IList<Comment>>(ResultStatus.Success, comments);

            return new DataResult<IList<Comment>>(ResultStatus.Error);
        }

        public async Task<IDataResult<Comment>> Insert(CommentInsertDto commentInsertDto)
        {
            var comment = _mapper.Map<Comment>(commentInsertDto);
            comment.ModifiedDate = comment.CreatedDate;

            var insertedCast = await _unitOfWork.Comments.InsertAsync(comment);
            await _unitOfWork.SaveAsync();

            if (insertedCast != null)
                return new DataResult<Comment>(ResultStatus.Success, comment);

            return new DataResult<Comment>(ResultStatus.Error, comment);
        }
        public async Task<IDataResult<Comment>> Delete(int commentId)
        {
            var comment = await _unitOfWork.Comments.GetAsync(c => c.Id == commentId);
            await _unitOfWork.Comments.DeleteAsync(comment);
            await _unitOfWork.SaveAsync();
            return new DataResult<Comment>(ResultStatus.Success, comment);
        }
    }
}
