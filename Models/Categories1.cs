﻿using System;
using System.Collections.Generic;

namespace CookiesSalesSystem.Models;

public partial class Categories1
{
    public int CategoryID { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }
}
