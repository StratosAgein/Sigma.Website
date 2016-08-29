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

                //cfg.CreateMap<BalanceScoreCard, BalanceScoreCardViewModel> ();
                //cfg.CreateMap<Client, ClientViewModel>();
                //cfg.CreateMap<Company, CompanyViewModel>();
                //cfg.CreateMap<Metric, MetricViewModel>();
                //cfg.CreateMap<Objective, ObjectiveViewModel>();
                //cfg.CreateMap<Perspective, PerspectiveViewModel>();
                //cfg.CreateMap<User, UserViewModel>();

                cfg.CreateMap<BalanceScoreCardViewModel, BalanceScoreCard>()
                    .ForMember(dest => dest._id, src => src.Ignore());
                cfg.CreateMap<ClientViewModel, Client>();
                cfg.CreateMap<CompanyViewModel, Company>();
                cfg.CreateMap<MetricViewModel, Metric>();
                cfg.CreateMap<ObjectiveViewModel, Objective>();
                cfg.CreateMap<PerspectiveViewModel, Perspective>();
                cfg.CreateMap<UserViewModel, User>();

            });

            config.AssertConfigurationIsValid();
            Mapper = config.CreateMapper();
        }
    }
}