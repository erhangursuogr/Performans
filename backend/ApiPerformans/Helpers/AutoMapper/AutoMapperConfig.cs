using ApiPerformans.Models.DataModels;
using AutoMapper;
using EntityLayer.Concrete;

namespace ApiPerformans.Helper.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<PerfDonem, DonemDataModel>().ReverseMap();
        }
    }
}