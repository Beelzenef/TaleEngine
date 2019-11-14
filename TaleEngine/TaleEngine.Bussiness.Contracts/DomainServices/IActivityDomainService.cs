﻿using System;
using System.Collections.Generic;
using System.Text;
using TaleEngine.Bussiness.Contracts.Dtos;

namespace TaleEngine.Bussiness.Contracts.DomainServices
{
    public interface IActivityDomainService
    {                                                         
        List<ActivityDto> GetActiveActivities(int editionId);
        List<ActivityDto> GetPendingActivities(int editionId);
        int DeleteActivity(int activityId);
        int CreateActivity(int editionId, ActivityDto activityDto);
        int UpdateActivity(ActivityDto activityDto);
    }
}
