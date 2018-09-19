using System;
using System.Collections.Generic;
using System.Text;
using BeachCabinReservation.Data;

namespace BeachCabinReservation.Business.Services
{
    public interface ICalendarService
    {

    }
    public class CalendarService : ServiceBase, ICalendarService
    {
        public CalendarService(IUnitOfWork uow) : base(uow)
        {
        }


    }
}
