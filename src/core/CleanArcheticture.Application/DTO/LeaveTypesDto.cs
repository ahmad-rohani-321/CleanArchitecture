using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArcheticture.Application.DTO
{
    public class LeaveTypesDto : Common.BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}