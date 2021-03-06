﻿using Microsoft.AspNetCore.Mvc;
using TaleEngine.Application.Contracts.Services;

namespace TaleEngine.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EditionController : Controller
    {
        private readonly IEditionService _editionService;

        public EditionController(IEditionService editionService)
        {
            _editionService = editionService;
        }

        [HttpGet("[action]/{editionId}")]
        public IActionResult GetEditionDays(int editionId)
        {
            var result = _editionService.GetEditionDays(editionId);

            if (result == null)
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}