using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArcheticture.Domain
{
    public class LeaveAllocation : Common.BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveTypes LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}