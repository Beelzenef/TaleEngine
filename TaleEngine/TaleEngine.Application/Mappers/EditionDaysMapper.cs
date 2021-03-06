﻿using TaleEngine.Application.Contracts.Dtos;
using TaleEngine.Bussiness.Contracts.Models;

namespace TaleEngine.Application.Mappers
{
    public static class EditionDaysMapper
    {
        public static EditionDaysDto Map(EditionDaysModel editionDays)
        {
            if (editionDays == null) return null;

            var dto = new EditionDaysDto();
            dto.EditionDays = editionDays.EditionDays;

            return dto;
        }
    }
}
