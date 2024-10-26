﻿using Game.Domain.CountryAggregate.Entities;
using Game.Domain.GameAggregate.ValueObjects;
using Game.Domain.RoomAggregate.Entities;
using Game.Domain.RoomAggregate.ValueObjects;
using WorldDomination.Shared.Domain;

namespace Game.Domain.GameAggregate.Entities
{
    public sealed class Game
    {
        public IdValueObject Id { get; private set; }
        public GameType GameType { get; private set; }
        public CurrentRound CurrentRound { get; private set; }
        public EcologyLevel EcologyLevel { get; private set; }

        public List<Country> Countries { get; private set; }
        public IdValueObject RoomId { get; private set; }
        public Room Room { get; private set; }

        //EF
        private Game() { }

        private Game(GameType gameType, Guid roomId, List<Country> countries)
        {
            Id = Guid.NewGuid();
            GameType = gameType;
            CurrentRound = CurrentRound.Create();
            EcologyLevel = EcologyLevel.Create();
            Countries = countries;
            RoomId = roomId;
        }

        public static Game Create(GameType gameType, Guid roomId, List<Country> countries)
        {
            return new Game(gameType, roomId, countries);
        }
    }
}
