﻿using System.Collections.Generic;
using TaleEngine.Bussiness.Contracts.Dtos;

namespace TaleEngine.Application.Contracts.Services
{
    public interface IActivityTypeService
    {
        List<ActivityTypeDto> GetActivityTypes();
    }
}
