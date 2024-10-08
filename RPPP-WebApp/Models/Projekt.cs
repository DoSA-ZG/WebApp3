﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPPP_WebApp.Models;

public partial class Projekt
{

    public Projekt(int id, string naziv, string opis, DateTime datumPocetka, DateTime datumZavrsetka, int oibNarucitelja, int idVrsteProjekta){
        IdProjekta = id;
        Naziv = naziv;
        Opis = opis;
        DatumPocetka = datumPocetka;
        DatumZavrsetka = datumZavrsetka;
        Oibnarucitelj = oibNarucitelja;
        IdVrsteProjekta = idVrsteProjekta;
    }

    public Projekt(string naziv, string opis, DateTime datumPocetka, DateTime datumZavrsetka, int oibNarucitelja, int idVrsteProjekta){
        Naziv = naziv;
        Opis = opis;
        DatumPocetka = datumPocetka;
        DatumZavrsetka = datumZavrsetka;
        Oibnarucitelj = oibNarucitelja;
        IdVrsteProjekta = idVrsteProjekta;
    }

    public Projekt()
    {
        Dokuments = new HashSet<Dokument>();
    }

    public int IdProjekta { get; set; }

    public string Naziv { get; set; }

    public string Opis { get; set; }

    public DateTime DatumPocetka { get; set; }

    public DateTime DatumZavrsetka { get; set; }

    public int Oibnarucitelj { get; set; }

    public int IdVrsteProjekta { get; set; }

    public virtual ICollection<Dokument> Dokuments { get; set; } = new List<Dokument>();

    public virtual ICollection<EvidencijaUloga> EvidencijaUlogas { get; set; } = new List<EvidencijaUloga>();

    public virtual VrstaProjekta IdVrsteProjektaNavigation { get; set; }

    public virtual Narucitelj OibnaruciteljNavigation { get; set; }

    public virtual ICollection<ProjektnaKartica> ProjektnaKarticas { get; set; } = new List<ProjektnaKartica>();

    public virtual ICollection<Zahtjev> Zahtjevs { get; set; } = new List<Zahtjev>();
}