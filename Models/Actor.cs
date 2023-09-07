﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string FullName { get; set; } = null!;
        public string? Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
