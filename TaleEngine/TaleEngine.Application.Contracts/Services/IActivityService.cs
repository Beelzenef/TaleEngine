﻿using System.Collections.Generic;
using TaleEngine.Bussiness.Contracts.Dtos;

namespace TaleEngine.Application.Contracts.Services
{
    public interface IActivityService
    {
        List<ActivityDto> GetActivities(int editionId);
        List<ActivityDto> GetPendingActivities(int editionId);
        int DeleteActivity(int activityId);
        int CreateActivity(int editionId, ActivityDto activityDto);
        int UpdateActivity(ActivityDto activityDto);
    }
}
