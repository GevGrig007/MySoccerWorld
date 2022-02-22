﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models.Entities
{
    public class Player
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Text must be less than 50 characters")]
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<PlayerTeam> PlayerTeams { get; set; }
        public PlayerTeam CurentTeamPlayer
        {
            get 
            {
                var currentTeam = PlayerTeams.OrderBy(p=>p.Season).Last();
                return currentTeam;
            }         
        }
    }
}
