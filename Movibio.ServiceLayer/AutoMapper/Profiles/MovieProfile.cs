using AutoMapper;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.MovieDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.AutoMapper.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {

            CreateMap<MovieInsertDto, Movie>().ForMember(dest =>
                dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
