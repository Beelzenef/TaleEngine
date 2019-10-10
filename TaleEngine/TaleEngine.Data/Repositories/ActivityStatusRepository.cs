﻿using System.Collections.Generic;
using System.Linq;
using TaleEngine.Data.Contracts;
using TaleEngine.Data.Contracts.Entities;
using TaleEngine.Data.Contracts.Repositories;

namespace TaleEngine.Data.Repositories
{
    public class ActivityStatusRepository : IActivityStatusRepository
    {
        private readonly IDatabaseContext _context;

        public ActivityStatusRepository(IDatabaseContext context)
        {
            _context = context;
        }

        public void Delete(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ActivityStatus> GetAll()
        {
            return _context.ActivityStatuses.ToList();
        }

        public ActivityStatus GetById(int entityId)
        {
            return _context.ActivityStatuses
                .FirstOrDefault(aS => aS.Id == entityId);
        }

        public void Insert(ActivityStatus entity)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ActivityStatus entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
