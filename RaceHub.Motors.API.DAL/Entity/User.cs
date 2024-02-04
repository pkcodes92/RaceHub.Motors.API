// <copyright file="User.cs" company="RaceHub">
// Copyright (c) RaceHub. All rights reserved.
// </copyright>

#nullable disable

namespace RaceHub.Motors.API.DAL.Entity
{
    /// <summary>
    /// This class represents the User db entity.
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TypeId { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpd { get; set; }

        public string LastUpdBy { get; set; }

        public string LastUpdApp { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}
