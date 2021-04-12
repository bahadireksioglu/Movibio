using AutoMapper;
using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.DirectorDtos;
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
    public class DirectorService : IDirectorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DirectorService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<Director>> Get(int directorId)
        {
            var director = await _unitOfWork.Directors.GetAsync(
                d => d.Id == directorId);

            if (director != null)
                return new DataResult<Director>(ResultStatus.Success, director);
            return new DataResult<Director>(ResultStatus.Error);
        }

        public async Task<IDataResult<IList<Director>>> GetAll()
        {
            var directors = await _unitOfWork.Directors.GetAllAsync(null);

            if (directors.Count > 0)
                return new DataResult<IList<Director>>(ResultStatus.Success, directors);
            return new DataResult<IList<Director>>(ResultStatus.Error);
        }

        public async Task<IDataResult<Director>> Insert(DirectorInsertDto directorInsertDto)
        {
            var director = _mapper.Map<Director>(directorInsertDto);
            director.ModifiedDate = director.CreatedDate;

            var insertedDirector = await _unitOfWork.Directors.InsertAsync(director);
            await _unitOfWork.SaveAsync();

            if (insertedDirector != null)
                return new DataResult<Director>(ResultStatus.Success, insertedDirector);

            return new DataResult<Director>(ResultStatus.Error, null);
        }

        public async Task<IDataResult<Director>> Update(DirectorUpdateDto directorUpdateDto)
        {
            var oldDirector = await _unitOfWork.Directors.GetAsync(d => d.Id == directorUpdateDto.Id);
            var director = _mapper.Map<DirectorUpdateDto, Director>(directorUpdateDto, oldDirector);

            var updatedDirector = await _unitOfWork.Directors.UpdateAsync(director);

            await _unitOfWork.SaveAsync();
            if (updatedDirector != null)
                return new DataResult<Director>(ResultStatus.Success, updatedDirector);
            return new DataResult<Director>(ResultStatus.Error, null);
        }
        public async Task<IDataResult<Director>> Delete(int directorId)
        {
            var director = await _unitOfWork.Directors.GetAsync(d => d.Id == directorId,
                d => d.MovieDirectors);
            await _unitOfWork.Directors.DeleteAsync(director);
            await _unitOfWork.SaveAsync();
            return new DataResult<Director>(ResultStatus.Success, director);
        }
    }
}
