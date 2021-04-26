using AutoMapper;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CommentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.AutoMapper.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentInsertDto, Comment>().ForMember(dest =>
                dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
