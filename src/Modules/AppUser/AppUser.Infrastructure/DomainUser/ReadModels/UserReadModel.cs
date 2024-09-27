﻿namespace AppUser.Infrastructure.DomainUser.ReadModels
{
    internal class UserReadModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; } 
        public ActivityStatusReadModel ActivityStatus { get; set; }
        public ICollection<UserAchievmentReadModel> UserAchievments { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
