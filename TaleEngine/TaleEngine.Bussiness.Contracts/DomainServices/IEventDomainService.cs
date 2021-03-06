﻿using System.Collections.Generic;
using TaleEngine.Bussiness.Contracts.Models;

namespace TaleEngine.Bussiness.Contracts.DomainServices
{
    public interface IEventDomainService
    {
        List<EventModel> GetEventsNoFilter();

        EventModel GetEvent(int eventId);
    }
}
