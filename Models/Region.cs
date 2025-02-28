﻿using System;
using System.Collections.Generic;

namespace CookiesSalesSystem.Models;

public partial class Region
{
    public int RegionID { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territories> Territories { get; set; } = new List<Territories>();
}
