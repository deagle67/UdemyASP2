using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using UdemyASP2.Dtos;
using UdemyASP2.Models;

namespace UdemyASP2.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Customer

            //CreateMap<Customer, CustomerDto>().ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<Customer, CustomerDto>();

            CreateMap<CustomerDto, Customer>();

            // Movie

            CreateMap<Movie, MovieDto>();

            CreateMap<MovieDto, Movie>();

            // MembershipType

            CreateMap<MemberShipType, MembershipTypeDto>();
        }
    }
}