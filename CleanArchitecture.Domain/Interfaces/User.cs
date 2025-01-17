﻿using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces;

public sealed class User : BaseEntity
{
    public string? Email { get; set; }
    public string? Name { get; set; }
}
