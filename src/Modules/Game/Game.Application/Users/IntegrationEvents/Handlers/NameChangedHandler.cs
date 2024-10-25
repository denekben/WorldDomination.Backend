﻿using Game.Domain.UserAggregate.Entities;
using Microsoft.Extensions.Logging;
using Shared.Events;
using User.Shared.IntegrationEvents;
using WorldDomination.Shared.Domain;
using WorldDomination.Shared.Exceptions.CustomExceptions;

namespace Game.Application.Users.IntegrationEvents.Handlers
{
    internal sealed class NameChangedHandler : IEventHandler<NameChanged>
    {
        private readonly IRepository<GameUser> _userRepository;
        private readonly ILogger<NameChangedHandler> _logger;

        public NameChangedHandler(IRepository<GameUser> userRepository, ILogger<NameChangedHandler> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task HandleAsync(NameChanged @event, CancellationToken cancellationToken = default)
        {
            var (userId, name) = @event;

            var user = await _userRepository.GetAsync(userId)
                ?? throw new BadRequestException($"Cannot find GameUser {@event.UserId}");

            user.ChangeName(name);
            await _userRepository.UpdateAsync(user);
            _logger.LogInformation($"GameUser {@event.Name} changed name");
        }
    }
}
