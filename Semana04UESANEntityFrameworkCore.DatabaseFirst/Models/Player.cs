using System;
using System.Collections.Generic;

namespace Semana04UESANEntityFrameworkCore.DatabaseFirst.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Dorsal { get; set; }
        public bool Active { get; set; }
    }
}
