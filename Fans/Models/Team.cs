using System;
using System.Collections.Generic;

namespace Fans.Models;

public partial class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Stadium { get; set; }

    public virtual ICollection<UserTeam> UserTeams { get; set; } = new List<UserTeam>();
}
