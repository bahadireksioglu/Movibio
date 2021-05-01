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
    public class LanguageService : ILanguageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LanguageService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<Language>> Get(int languageId)
        {
            var language = await _unitOfWork.Languages.GetAsync(
                l => l.Id == languageId);

            if (language != null)
                return new DataResult<Language>(ResultStatus.Success, language);
            return new DataResult<Language>(ResultStatus.Error);
        }

        public async Task<IDataResult<IList<Language>>> GetAll()
        {
            var languages = await _unitOfWork.Languages.GetAllAsync(null);

            if (languages.Count > 0)
                return new DataResult<IList<Language>>(ResultStatus.Success, languages);
            return new DataResult<IList<Language>>(ResultStatus.Error);
        }
    }
}
