using AutoMapper;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.ScenaristDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.AutoMapper.Profiles
{
    public class ScenaristProfile : Profile
    {
        public ScenaristProfile()
        {
            
            CreateMap<ScenaristInsertDto, Scenarist>().ForMember(dest =>
                dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<ScenaristUpdateDto, Scenarist>().ForMember(dest =>
                dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<Scenarist, ScenaristUpdateDto>();
        }
    }
}
