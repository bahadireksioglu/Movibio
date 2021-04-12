using AutoMapper;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CastDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.AutoMapper.Profiles
{
    public class CastProfile : Profile
    {
        public CastProfile()
        {

            CreateMap<CastInsertDto, Cast>().ForMember(dest =>
                dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<CastUpdateDto, Cast>().ForMember(dest =>
                dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<Cast, CastUpdateDto>();
        }
    }
}
