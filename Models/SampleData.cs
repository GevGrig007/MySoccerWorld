using MySoccerWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySoccerWorld.Models
{
    public static class SampleData
    {
        public static void Initialize(SoccerContext context)
        {
            if (!context.Leagues.Any())
            {
                context.Leagues.AddRange(
                    new League {Id=1, Name= "GB Premier League", Region= "GreatBritain", Type= "Regional", Logo = "/images/Gb.png"},
                    new League {Id = 2, Name = "Championat SNG",Region = "SNG", Type = "Regional", Logo = "/images/Sng.png" },
                    new League { Id = 3, Name = "SuperLiga Alpys", Region = "Alpys", Type = "Regional", Logo = "/images/Alpys.png" },
                    new League { Id = 4, Name = "Balkans Superliga", Region = "Balkans", Type = "Regional", Logo = "/images/Balkans.png" },
                    new League { Id = 5, Name = "Seria A", Region = "Italy", Type = "Regional", Logo = "/images/SeriaA.png" },
                    new League { Id = 6, Name = "La Liga Pyreneeys", Region = "Pyreneeys", Type = "Regional", Logo = "/images/Pireneys.png" },
                    new League { Id = 7, Name = "Ligue 1", Region = "France", Type = "Regional", Logo = "/images/Ligue12.png" },
                    new League { Id = 8, Name = "BeNeLux", Region = "Benelux", Type = "Regional", Logo = "/images/Benelux.png" },
                    new League { Id = 9, Name = "Scandinavs Serien", Region = "Scandinavs", Type = "Regional", Logo = "/images/Scandinav.png" },
                    new League { Id = 10, Name = "CentralLiga", Region = "CentralEurope", Type = "Regional", Logo = "/images/Central.png" },
                    new League { Id = 11, Name = "League Champions",  Type = "EuroCup", Logo = "/images/Lch.png" },
                    new League { Id = 12, Name = "EuroLeague", Type = "EuroCup", Logo = "/images/euroliga.png" },
                    new League { Id = 13, Name = "Conferentions Cup", Type = "EuroCup", Logo = "/images/conferention.png" },
                    new League { Id = 14, Name = "Cup of Cups", Type = "EuroCup", Logo = "/images/cupcups.jpg" },
                    new League { Id = 15, Name = "SuperCup PES", Type = "EuroCup", Logo = "/images/supercup.jpg" },
                    new League { Id = 16, Name = "World Cup", Type = "National", Logo = "/images/worldcup.png" },
                    new League { Id = 17, Name = "UEFA EURO CUP", Type = "National", Logo = "/images/eurocup.png" },
                    new League { Id = 18, Name = "Cup of AFRICAN Nations", Type = "National", Logo = "/images/africacup.png" },
                    new League { Id = 19, Name = "Copa de AMERICA", Type = "National", Logo = "/images/copaamerica.png" }
                );
                context.SaveChanges();
            }
        }
    }
}
