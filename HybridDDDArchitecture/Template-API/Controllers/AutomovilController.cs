﻿using Application.UseCases.Automovil.Commands.CreateAutomovil;
using Application.UseCases.Automovil.Queries.GetAllAutomovil;
using Controllers;
using Core.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Template_API.Controllers
{
    [ApiController]
    public class AutomovilController(ICommandQueryBus commandQueryBus) : BaseController
    {
        private readonly ICommandQueryBus _commandQueryBus = commandQueryBus ?? throw new ArgumentNullException(nameof(commandQueryBus));

        [HttpGet("api/v1/[Controller]")]
        public async Task<IActionResult> GetAll(uint pageIndex = 1, uint pageSize = 10)
        {
            var entities = await _commandQueryBus.Send(new GetAllAutomovilQuery() { PageIndex = pageIndex, PageSize = pageSize });

            return Ok(entities);
        }

        //[HttpGet("api/v1/[Controller]/{id}")]
        //public async Task<IActionResult> GetById(string id)
        //{
        //    if (string.IsNullOrEmpty(id)) return BadRequest();

        //    var entity = await _commandQueryBus.Send(new GetDummyEntityByQuery { DummyIdProperty = id });

        //    return Ok(entity);
        //}

        [HttpPost("api/v1/[Controller]")]
        public async Task<IActionResult> Create(CreateAutomovilCommand command)
        {
            if (command is null) return BadRequest();

            var id = await _commandQueryBus.Send(command);

            return Created($"api/[Controller]/{id}", new { Id = id });
        }

        //[HttpPut("api/v1/[Controller]")]
        //public async Task<IActionResult> Update(UpdateDummyEntityCommand command)
        //{
        //    if (command is null) return BadRequest();

        //    await _commandQueryBus.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete("api/v1/[Controller]/{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    if (id <= 0) return BadRequest();

        //    await _commandQueryBus.Send(new DeleteDummyEntityCommand { DummyIdProperty = id });

        //    return NoContent();
        //}
    }
}
