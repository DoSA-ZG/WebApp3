﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RPPP_WebApp.Models;

public partial class ProjektnaKartica
{
    public int IdKartice { get; set; }

    public int Ibankartice { get; set; }

    public decimal Stanje { get; set; }

    public int IdProjekta { get; set; }

    public int Oibosoba { get; set; }

    public virtual Projekt IdProjektaNavigation { get; set; }

    public virtual Osoba OibosobaNavigation { get; set; }

    public virtual ICollection<Transakcija> Transakcijas { get; set; } = new List<Transakcija>();
}