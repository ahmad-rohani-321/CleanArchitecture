using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArcheticture.Application.DTO
{
    public class LeaveAllocationDto : Common.BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypesDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}