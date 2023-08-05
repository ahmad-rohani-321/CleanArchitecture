using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArcheticture.Domain;
namespace CleanArcheticture.Application.Persistance.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequests>
    {
        //
    }
}