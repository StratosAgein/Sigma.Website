using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sigma.Website.Models.Entities;
using Sigma.Website.ViewModels;

namespace Sigma.Website.Infraestructure
{
    public class AutoMapperConfiguration
    {
        public static IMapper Mapper;

        public static void ConfigureMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                                
                cfg.CreateMap<Company, CompanyViewModel> ();
                
            });

            config.AssertConfigurationIsValid();
            Mapper = config.CreateMapper();
        }
    }
}