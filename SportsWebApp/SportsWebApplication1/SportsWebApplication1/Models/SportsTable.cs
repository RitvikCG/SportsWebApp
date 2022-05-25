using System;
using System.Collections.Generic;

namespace SportsWebApplication1.Models
{
    public partial class SportsTable
    {
        public int Id { get; set; }
        public string SportsName { get; set; }
        public string SportsType { get; set; }
        public int MaxMembers { get; set; }
    }
}
