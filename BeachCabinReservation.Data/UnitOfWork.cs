using BeachCabinReservation.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeachCabinReservation.Data
{
    public interface IUnitOfWork
    {
        ILogEntryRepository LogEntryRepository { get; }

        int Save();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private AppDataContext context;
        private ILogEntryRepository logEntryRepository;

        public UnitOfWork(AppDataContext context)
        {
            this.context = context;
        }

        public ILogEntryRepository LogEntryRepository
        {
            get
            {
                if (logEntryRepository == null)
                    logEntryRepository = new LogEntryRepository(context);
                return logEntryRepository;
            }
        }


        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
