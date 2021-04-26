﻿using System;
using System.Collections.Generic;
using System.Linq;
using TaleEngine.Data.Contracts;
using TaleEngine.Data.Contracts.Entities;
using TaleEngine.Data.Contracts.Repositories;

namespace TaleEngine.Data.Repositories
{
    public class TimeSlotRepository : ITimeSlotRepository
    {
        private readonly DatabaseContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public TimeSlotRepository(DatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public List<TimeSlot> GetAll()
        {
            return _context.TimeSlot.ToList();
        }

        public TimeSlot GetById(int entityId)
        {
            return _context.TimeSlot
                .FirstOrDefault(a => a.Id == entityId);
        }

        public void Insert(TimeSlot entity)
        {
            _context.TimeSlot.Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TimeSlot entity)
        {
            _context.TimeSlot.Update(entity);
        }
    }
}