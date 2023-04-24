using System;
using System.Collections.Generic;

namespace Fans.Models;

public partial class UserTeam
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public int? IdTeam { get; set; }

    public virtual Team? IdTeamNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
