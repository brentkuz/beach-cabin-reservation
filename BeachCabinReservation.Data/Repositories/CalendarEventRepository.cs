using BeachCabinReservation.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeachCabinReservation.Data.Repositories
{
    public interface ICalendarEventRepository
    {
        IQueryable<CalendarEvent> Get();
        void Insert(CalendarEvent project);
        void Delete(int id);
        void Update(CalendarEvent newValues);
    }
    public class CalendarEventRepository : RepositoryBase<CalendarEvent>, ICalendarEventRepository
    {
        public CalendarEventRepository(AppDataContext context) : base(context)
        {
        }
    }
}
