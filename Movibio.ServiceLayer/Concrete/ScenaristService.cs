using AutoMapper;
using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.ScenaristDtos;
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
    public class ScenaristService : IScenaristService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ScenaristService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<Scenarist>> Get(int scenaristId)
        {
            var scenarist = await _unitOfWork.Scenarists.GetAsync(
                s => s.Id == scenaristId);

            if (scenarist != null)
                return new DataResult<Scenarist>(ResultStatus.Success, scenarist);
            return new DataResult<Scenarist>(ResultStatus.Error);

        }

        public async Task<IDataResult<IList<Scenarist>>> GetAll()
        {
            var scenarists = await _unitOfWork.Scenarists.GetAllAsync(null);

            if (scenarists.Count > 0)
                return new DataResult<IList<Scenarist>>(ResultStatus.Success, scenarists);
            return new DataResult<IList<Scenarist>>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<Scenarist>> Insert(ScenaristInsertDto scenaristInsertDto)
        {
            var scenarist = _mapper.Map<Scenarist>(scenaristInsertDto);
            scenarist.ModifiedDate = scenarist.CreatedDate;

            var insertedScenarist = await _unitOfWork.Scenarists.InsertAsync(scenarist);
            await _unitOfWork.SaveAsync();

            if (scenarist != null)
                return new DataResult<Scenarist>(ResultStatus.Success, insertedScenarist);

            return new DataResult<Scenarist>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<Scenarist>> Update(ScenaristUpdateDto scenaristUpdateDto)
        {
            var oldScenarist = await _unitOfWork.Scenarists.GetAsync(s => s.Id == scenaristUpdateDto.Id);
            var scenarist = _mapper.Map<ScenaristUpdateDto, Scenarist>(scenaristUpdateDto, oldScenarist);

            var updatedScenarist = await _unitOfWork.Scenarists.UpdateAsync(scenarist);

            await _unitOfWork.SaveAsync();
            if (updatedScenarist != null)
                return new DataResult<Scenarist>(ResultStatus.Success, updatedScenarist);
            return new DataResult<Scenarist>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<Scenarist>> Delete(int scenaristId)
        {
            var scenarist = await _unitOfWork.Scenarists.GetAsync(s => s.Id == scenaristId,
                s => s.MovieScenarists);
            await _unitOfWork.Scenarists.DeleteAsync(scenarist);
            await _unitOfWork.SaveAsync();
            return new DataResult<Scenarist>(ResultStatus.Success, scenarist);
        }
    }
}
