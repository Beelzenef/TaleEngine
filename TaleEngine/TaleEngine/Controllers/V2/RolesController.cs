﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TaleEngine.Application.Contracts.Services;

namespace TaleEngine.Controllers.V2
{
    /// <summary>
    /// Roles management
    /// </summary>
    [ApiController]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ControllerName("Management roles and permissions associated")]
    [Route("api/v2/[controller]")]
    public class RolesController : Controller
    {
        private IRoleService _roleService;

        /// <summary>
        /// Constructor for roles controller
        /// </summary>
        /// <param name="roleService">Role service</param>
        public RolesController(IRoleService roleService)
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
        }

        /// <summary>
        /// Gets all the roles in the app
        /// </summary>
        /// <returns>All the roles</returns>
        [HttpGet("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAllRoles()
        {
            var result = _roleService.GetAllRoles();

            if (result == null || result.Count == 0)
            {
                return NoContent();
            }

            return Ok(result);
        }

        /// <summary>
        /// Gets a single role with permissions
        /// </summary>
        /// <param name="roleId">Role identifier</param>
        /// <returns>The selected role with permissions</returns>
        [HttpGet("[action]/{roleId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetRole(int roleId)
        {
            return Ok();
        }

    }
}
