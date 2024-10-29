﻿using Game.Application.Rooms.Commands;
using Game.Application.Rooms.Queries;
using Game.Shared.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Game.WebUI.Controllers
{
    [ApiController]
    [Route("rooms")]
    public class RoomController : ControllerBase
    {
        private readonly ISender _sender;

        public RoomController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomDto>>> SearchRooms([FromQuery] SearchRooms query)
        {
            return Ok( await _sender.Send(query));
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Guid>> CreateRoom(CreateRoom command)
        {
            return Ok(await _sender.Send(command));
        }

        [HttpDelete]
        [Authorize]
        [Route("{roomId:guid}")]
        public async Task<IActionResult> CloseRoom([FromRoute] CloseRoom command)
        {
            await _sender.Send(command);
            return Ok();
        }

        [HttpDelete]
        [Authorize]
        [Route("{roomId:guid}/member")]
        public async Task<IActionResult> LeaveRoom([FromRoute] LeaveRoom command)
        {
            await _sender.Send(command);
            return Ok();
        }

        [HttpPost]
        [Authorize]
        [Route("{roomId:guid}/member")]
        public async Task<ActionResult<Guid>> JoinRoom([FromRoute] Guid roomId, [FromQuery] string? roomCode)
        {
            await _sender.Send(new JoinRoom(roomId, roomCode));
            return Ok();
        }

        [HttpDelete]
        [Authorize]
        [Route("{roomId:guid}/members/{memberId:guid}")]
        public async Task<IActionResult> KickMember()
        {
            return Ok();
        }

    }
}
