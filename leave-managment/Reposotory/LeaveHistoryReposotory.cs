using leave_managment.Contracts;
using leave_managment.Data;
using System.Collections.Generic;
using System;
using System.Linq;
using leave_managment.Models;

namespace leave_managment.Reposotory
{
    public class LeaveHistoryReposotory : ILeaveHistoryReposotory
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryReposotory(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var leaveHystorys = _db.LeaveHistories.ToList();
            return leaveHystorys;
        }

        public LeaveHistory FindById(int id)
        {
            var leaveHystory = _db.LeaveHistories.Find(id);
            return leaveHystory;
        }

        public bool IsExists(int id)
        {
            var exists = _db.LeaveHistories.Any(e => e.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
    