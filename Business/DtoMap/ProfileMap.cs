using AutoMapper;
using Business.Dto;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DtoMap
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<Customer, CustomerRequest>(MemberList.None);
            CreateMap<CustomerRequest, Customer>(MemberList.None);
        }
    }
}
