using BeachCabinReservation.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeachCabinReservation.Data
{
    public interface IUnitOfWork
    {
        ILogEntryRepository LogEntryRepository { get; }
        ICalendarEventRepository CalendarEventRepository { get; }

        int Save();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private AppDataContext context;
        private ILogEntryRepository logEntryRepository;
        private ICalendarEventRepository calendarEventRepository;

        public UnitOfWork(AppDataContext context, ILogEntryRepository logEntryRepository, ICalendarEventRepository calendarEventRepository)
        {
            this.context = context;
            this.logEntryRepository = logEntryRepository;
            this.calendarEventRepository = calendarEventRepository;
        }

        public ILogEntryRepository LogEntryRepository
        {
            get
            {
                return logEntryRepository;
            }
        }

        public ICalendarEventRepository CalendarEventRepository
        {
            get
            {
                return calendarEventRepository;
            }
        }
        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
