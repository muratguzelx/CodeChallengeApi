﻿using System.ComponentModel.DataAnnotations;

namespace CodeChallengeApi.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
