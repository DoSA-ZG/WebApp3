﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RPPP_WebApp.Models;

public partial class Uloga
{
    public int IdUloge { get; set; }

    public string Naziv { get; set; }

    public virtual ICollection<EvidencijaUloga> EvidencijaUlogas { get; set; } = new List<EvidencijaUloga>();
}