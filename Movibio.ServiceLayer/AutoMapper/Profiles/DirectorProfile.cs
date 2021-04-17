using AutoMapper;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.DirectorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.AutoMapper.Profiles
{
    public class DirectorProfile : Profile
    {
        public DirectorProfile()
        {

            CreateMap<DirectorInsertDto, Director>().ForMember(dest =>
                dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<DirectorUpdateDto, Director>().ForMember(dest =>
                dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));

            CreateMap<Director, DirectorUpdateDto>();
        }
    }
}
