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
                                
                cfg.CreateMap<BalanceScoreCard, BalanceScoreCardViewModel> ();
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<Company, CompanyViewModel>();
                cfg.CreateMap<Metric, MetricViewModel>();
                cfg.CreateMap<Objective, ObjectiveViewModel>();
                cfg.CreateMap<Perspective, PerspectiveViewModel>();
                cfg.CreateMap<User, UserViewModel>();

            });

            config.AssertConfigurationIsValid();
            Mapper = config.CreateMapper();
        }
    }
}