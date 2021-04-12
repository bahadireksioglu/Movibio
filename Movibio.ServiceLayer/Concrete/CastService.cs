using AutoMapper;
using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CastDtos;
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
    public class CastService : ICastService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CastService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<Cast>> Get(int castId)
        {
            var cast = await _unitOfWork.Casts.GetAsync(c =>
                 c.Id == castId);

            if (cast != null)
                return new DataResult<Cast>(ResultStatus.Success, cast);

            return new DataResult<Cast>(ResultStatus.Error);
        }

        public async Task<IDataResult<IList<Cast>>> GetAll()
        {
            var casts = await _unitOfWork.Casts.GetAllAsync(null);

            if (casts.Count>0)
                return new DataResult<IList<Cast>>(ResultStatus.Success, casts);

            return new DataResult<IList<Cast>>(ResultStatus.Error);
        }

        public async Task<IDataResult<Cast>> Insert(CastInsertDto castInsertDto)
        {
            var cast = _mapper.Map<Cast>(castInsertDto);
            cast.ModifiedDate = cast.CreatedDate;
            
            var insertedCast = await _unitOfWork.Casts.InsertAsync(cast);
            await _unitOfWork.SaveAsync();
            
            if(insertedCast != null)
                return new DataResult<Cast>(ResultStatus.Success, cast);

            return new DataResult<Cast>(ResultStatus.Error, cast);
        }

        public async Task<IDataResult<Cast>> Update(CastUpdateDto castUpdateDto)
        {
            var oldCast = await _unitOfWork.Casts.GetAsync(c => c.Id == castUpdateDto.Id);
            var cast = _mapper.Map<CastUpdateDto, Cast>(castUpdateDto, oldCast);

            var updatedCast = await _unitOfWork.Casts.UpdateAsync(cast);

            await _unitOfWork.SaveAsync();
            if (updatedCast != null)
                return new DataResult<Cast>(ResultStatus.Success, updatedCast);
            return new DataResult<Cast>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<Cast>> Delete(int castId)
        {
            var cast = await _unitOfWork.Casts.GetAsync(c => c.Id == castId,
                c=>c.MovieCasts);
            await _unitOfWork.Casts.DeleteAsync(cast);
            await _unitOfWork.SaveAsync();
            return new DataResult<Cast>(ResultStatus.Success, cast);
        }
    }
}
