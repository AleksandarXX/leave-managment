using leave_managment.Data;
using System.Collections;
using System.Collections.Generic;

namespace leave_managment.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeeByTypeId(int id);
    }
}
