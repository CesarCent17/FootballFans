﻿using System;
using System.Collections.Generic;

namespace Fans.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();
}
