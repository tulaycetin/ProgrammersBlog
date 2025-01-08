using AutoMapper;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.AutoMapper.Profiles
{
    public class CategoryProfiles : Profile
    {
        public CategoryProfiles()
        {
            CreateMap<CategoryAddDto,Category>().ForMember(d => d.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<CategoryUpdateDto, Category>().ForMember(d => d.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));

        }
    }
}
