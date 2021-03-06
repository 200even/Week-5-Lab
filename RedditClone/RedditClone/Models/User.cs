﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RedditClone.Models;

namespace RedditClone.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string UserName { get; set; }

        public virtual List<Post> Posts { get; set; }

    }
}