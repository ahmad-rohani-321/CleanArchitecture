using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArcheticture.Domain;
namespace CleanArcheticture.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequests, DTO.LeaveRequestsDto>().ReverseMap();
            CreateMap<LeaveAllocation, DTO.LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveTypes, DTO.LeaveTypesDto>().ReverseMap();
        }
    }
}