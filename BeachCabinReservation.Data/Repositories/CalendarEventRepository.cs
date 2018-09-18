using BeachCabinReservation.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeachCabinReservation.Data.Repositories
{
    public class CalendarEventRepository : RepositoryBase<CalendarEvent>
    {
        public CalendarEventRepository(AppDataContext context) : base(context)
        {
        }
    }
}
