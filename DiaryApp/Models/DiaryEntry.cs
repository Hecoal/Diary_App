﻿using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        //[Key]
        public int Id { get; set; }
        [Required]
        //The ? means empty
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public DateTime Created { get; set; }= DateTime.Now;
    }
}
