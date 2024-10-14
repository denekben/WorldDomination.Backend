﻿using User.Shared.DTOs;
using MediatR;
using System;
using Microsoft.AspNetCore.Http;

namespace User.Application.Users.Commands
{
    public sealed record ChangeProfileImage(string UserId, IFormFile FormFile) : IRequest;
}
