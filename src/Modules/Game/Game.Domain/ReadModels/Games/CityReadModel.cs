﻿namespace Game.Domain.DomainModels.ReadModels.Games
{
    public sealed class CityReadModel
    {
        public Guid Id { get; private set; }
        public string CityName { get; private set; }
        public string NormalizedName { get; private set; }
        public string CityImagePath { get; private set; }
        public bool IsAlive { get; private set; }
        public bool HaveShield { get; private set; }
        public int DevelopmentLevel { get; private set; }
        public int LivingLevel { get; private set; }

        public Guid CountryId { get; private set; }
        public CountryReadModel Country { get; private set; }
    }
}
