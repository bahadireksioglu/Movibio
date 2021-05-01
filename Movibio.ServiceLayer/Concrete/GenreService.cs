using AutoMapper;
using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
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
    public class GenreService : IGenreService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GenreService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<Genre>> Get(int genreId)
        {
            var genre = await _unitOfWork.Genres.GetAsync(
                g => g.Id == genreId);

            if (genre != null)
                return new DataResult<Genre>(ResultStatus.Success, genre);
            return new DataResult<Genre>(ResultStatus.Error);
        }

        public async Task<IDataResult<IList<Genre>>> GetAll()
        {
            var genres = await _unitOfWork.Genres.GetAllAsync(null);

            if (genres.Count > 0)
                return new DataResult<IList<Genre>>(ResultStatus.Success, genres);
            return new DataResult<IList<Genre>>(ResultStatus.Error);
        }
    }
}
