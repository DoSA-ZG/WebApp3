﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RPPP_WebApp.Models;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dokument> Dokumenti { get; set; }

    public virtual DbSet<EvidencijaRada> EvidencijaRada { get; set; }

    public virtual DbSet<EvidencijaUloga> EvidencijaUloga { get; set; }

    public virtual DbSet<Narucitelj> Narucitelji { get; set; }

    public virtual DbSet<Organizacija> Organizacije { get; set; }

    public virtual DbSet<Osoba> Osobe { get; set; }

    public virtual DbSet<Prioritet> Prioriteti { get; set; }

    public virtual DbSet<Projekt> Projekti { get; set; }

    public virtual DbSet<ProjektnaKartica> ProjektneKartice { get; set; }

    public virtual DbSet<Status> Statusi { get; set; }

    public virtual DbSet<Transakcija> Transakcije { get; set; }

    public virtual DbSet<Uloga> Uloge { get; set; }

    public virtual DbSet<VrstaDokumenta> VrsteDokumenta { get; set; }

    public virtual DbSet<VrstaPosla> VrstePosla { get; set; }

    public virtual DbSet<VrstaProjekta> VrsteProjekta { get; set; }

    public virtual DbSet<VrstaTransakcije> VrsteTransakcije { get; set; }

    public virtual DbSet<VrstaZahtjeva> VrsteZahtjeva { get; set; }

    public virtual DbSet<Zadatak> Zadatci { get; set; }

    public virtual DbSet<Zahtjev> Zahtjevi { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dokument>(entity =>
        {
            entity.HasKey(e => e.IdDokumenta).HasName("PK__DOKUMENT__4EF6C2576FD33BD4");

            entity.ToTable("DOKUMENT");

            entity.Property(e => e.IdDokumenta).HasColumnName("idDokumenta");
            entity.Property(e => e.DatumNastanka)
                .HasColumnType("date")
                .HasColumnName("datumNastanka");
            entity.Property(e => e.Format)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("format");
            entity.Property(e => e.IdProjekta).HasColumnName("idProjekta");
            entity.Property(e => e.IdVrsteDokumenta).HasColumnName("idVrsteDokumenta");
            entity.Property(e => e.Stavka)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("stavka");

            entity.HasOne(d => d.IdProjektaNavigation).WithMany(p => p.Dokuments)
                .HasForeignKey(d => d.IdProjekta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DOKUMENT__idProj__4F47C5E3");

            entity.HasOne(d => d.IdVrsteDokumentaNavigation).WithMany(p => p.Dokuments)
                .HasForeignKey(d => d.IdVrsteDokumenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DOKUMENT__idVrst__4E53A1AA");
        });

        modelBuilder.Entity<EvidencijaRada>(entity =>
        {
            entity.HasKey(e => e.IdEvidencijaRad).HasName("PK__EVIDENCI__5574244064E15667");

            entity.ToTable("EVIDENCIJA_RADA");

            entity.Property(e => e.IdEvidencijaRad).HasColumnName("idEvidencijaRad");
            entity.Property(e => e.DatumRada)
                .HasColumnType("date")
                .HasColumnName("datumRada");
            entity.Property(e => e.IdVrstePosla).HasColumnName("idVrstePosla");
            entity.Property(e => e.IdZadatka).HasColumnName("idZadatka");
            entity.Property(e => e.Oibosoba).HasColumnName("OIBosoba");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");
            entity.Property(e => e.VrijemeRada).HasColumnName("vrijemeRada");

            entity.HasOne(d => d.IdVrstePoslaNavigation).WithMany(p => p.EvidencijaRada)
                .HasForeignKey(d => d.IdVrstePosla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EVIDENCIJ__idVrs__6166761E");

            entity.HasOne(d => d.IdZadatkaNavigation).WithMany(p => p.EvidencijaRada)
                .HasForeignKey(d => d.IdZadatka)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EVIDENCIJ__idZad__607251E5");

            entity.HasOne(d => d.OibosobaNavigation).WithMany(p => p.EvidencijaRada)
                .HasForeignKey(d => d.Oibosoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EVIDENCIJ__OIBos__5F7E2DAC");
        });

        modelBuilder.Entity<EvidencijaUloga>(entity =>
        {
            entity.HasKey(e => e.IdEvidencijaUloga).HasName("PK__EVIDENCI__12788BEC4F3155EB");

            entity.ToTable("EVIDENCIJA_ULOGA");

            entity.Property(e => e.IdEvidencijaUloga).HasColumnName("idEvidencijaUloga");
            entity.Property(e => e.DatumPocetka)
                .HasColumnType("date")
                .HasColumnName("datumPocetka");
            entity.Property(e => e.DatumZavrsetka)
                .HasColumnType("date")
                .HasColumnName("datumZavrsetka");
            entity.Property(e => e.IdProjekta).HasColumnName("idProjekta");
            entity.Property(e => e.IdUloge).HasColumnName("idUloge");
            entity.Property(e => e.Oibosoba).HasColumnName("OIBosoba");

            entity.HasOne(d => d.IdProjektaNavigation).WithMany(p => p.EvidencijaUlogas)
                .HasForeignKey(d => d.IdProjekta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EVIDENCIJ__idPro__498EEC8D");

            entity.HasOne(d => d.IdUlogeNavigation).WithMany(p => p.EvidencijaUlogas)
                .HasForeignKey(d => d.IdUloge)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EVIDENCIJ__idUlo__4A8310C6");

            entity.HasOne(d => d.OibosobaNavigation).WithMany(p => p.EvidencijaUlogas)
                .HasForeignKey(d => d.Oibosoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EVIDENCIJ__OIBos__4B7734FF");
        });

        modelBuilder.Entity<Narucitelj>(entity =>
        {
            entity.HasKey(e => e.Oibnarucitelj).HasName("PK__NARUCITE__4770D09D30CED15A");

            entity.ToTable("NARUCITELJ");

            entity.Property(e => e.Oibnarucitelj)
                .ValueGeneratedNever()
                .HasColumnName("OIBnarucitelj");
            entity.Property(e => e.Iban).HasColumnName("IBAN");
            entity.Property(e => e.Kontakt).HasColumnName("kontakt");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
        });

        modelBuilder.Entity<Organizacija>(entity =>
        {
            entity.HasKey(e => e.IdOrganizacije).HasName("PK__ORGANIZA__E3128A7D72173E66");

            entity.ToTable("ORGANIZACIJA");

            entity.Property(e => e.IdOrganizacije).HasColumnName("idOrganizacije");
            entity.Property(e => e.Adresa)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adresa");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
        });

        modelBuilder.Entity<Osoba>(entity =>
        {
            entity.HasKey(e => e.Oibosoba).HasName("PK__OSOBA__92ECCAAD0DE633C9");

            entity.ToTable("OSOBA");

            entity.Property(e => e.Oibosoba)
                .ValueGeneratedNever()
                .HasColumnName("OIBosoba");
            entity.Property(e => e.BrTelefon).HasColumnName("br_telefon");
            entity.Property(e => e.IdOrganizacije).HasColumnName("idOrganizacije");
            entity.Property(e => e.Ime)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ime");
            entity.Property(e => e.Mail)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Prezime)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("prezime");

            entity.HasOne(d => d.IdOrganizacijeNavigation).WithMany(p => p.Osobas)
                .HasForeignKey(d => d.IdOrganizacije)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OSOBA__idOrganiz__46B27FE2");
        });

        modelBuilder.Entity<Prioritet>(entity =>
        {
            entity.HasKey(e => e.IdPrioriteta).HasName("PK__PRIORITE__5568DE584E52D9D9");

            entity.ToTable("PRIORITET");

            entity.Property(e => e.IdPrioriteta).HasColumnName("idPrioriteta");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
        });

        modelBuilder.Entity<Projekt>(entity =>
        {
            entity.HasKey(e => e.IdProjekta).HasName("PK__PROJEKT__0CE0C400E8D170C1");

            entity.ToTable("PROJEKT");

            entity.Property(e => e.IdProjekta).HasColumnName("idProjekta");
            entity.Property(e => e.DatumPocetka)
                .HasColumnType("date")
                .HasColumnName("datumPocetka");
            entity.Property(e => e.DatumZavrsetka)
                .HasColumnType("date")
                .HasColumnName("datumZavrsetka");
            entity.Property(e => e.IdVrsteProjekta).HasColumnName("idVrsteProjekta");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
            entity.Property(e => e.Oibnarucitelj).HasColumnName("OIBnarucitelj");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");

            entity.HasOne(d => d.IdVrsteProjektaNavigation).WithMany(p => p.Projekts)
                .HasForeignKey(d => d.IdVrsteProjekta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROJEKT__idVrste__3F115E1A");

            entity.HasOne(d => d.OibnaruciteljNavigation).WithMany(p => p.Projekts)
                .HasForeignKey(d => d.Oibnarucitelj)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROJEKT__OIBnaru__3E1D39E1");
        });

        modelBuilder.Entity<ProjektnaKartica>(entity =>
        {
            entity.HasKey(e => e.IdKartice).HasName("PK__PROJEKTN__5D14333612C8A2EF");

            entity.ToTable("PROJEKTNA_KARTICA");

            entity.Property(e => e.IdKartice).HasColumnName("idKartice");
            entity.Property(e => e.Ibankartice).HasColumnName("IBANkartice");
            entity.Property(e => e.IdProjekta).HasColumnName("idProjekta");
            entity.Property(e => e.Oibosoba).HasColumnName("OIBosoba");
            entity.Property(e => e.Stanje)
                .HasColumnType("numeric(19, 4)")
                .HasColumnName("stanje");

            entity.HasOne(d => d.IdProjektaNavigation).WithMany(p => p.ProjektnaKarticas)
                .HasForeignKey(d => d.IdProjekta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROJEKTNA__idPro__5224328E");

            entity.HasOne(d => d.OibosobaNavigation).WithMany(p => p.ProjektnaKarticas)
                .HasForeignKey(d => d.Oibosoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROJEKTNA__OIBos__531856C7");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__STATUS__01936F7477E566B1");

            entity.ToTable("STATUS");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
        });

        modelBuilder.Entity<Transakcija>(entity =>
        {
            entity.HasKey(e => e.IdTransakcije).HasName("PK__TRANSAKC__33A5BCE206D7865C");

            entity.ToTable("TRANSAKCIJA");

            entity.Property(e => e.IdTransakcije).HasColumnName("idTransakcije");
            entity.Property(e => e.Datum)
                .HasColumnType("date")
                .HasColumnName("datum");
            entity.Property(e => e.Iban2zaTransakciju).HasColumnName("IBAN2zaTransakciju");
            entity.Property(e => e.IdKartice).HasColumnName("idKartice");
            entity.Property(e => e.IdVrsteTransakcije).HasColumnName("idVrsteTransakcije");
            entity.Property(e => e.Iznos)
                .HasColumnType("numeric(19, 4)")
                .HasColumnName("iznos");
            entity.Property(e => e.Vrijeme).HasColumnName("vrijeme");

            entity.HasOne(d => d.IdKarticeNavigation).WithMany(p => p.Transakcijas)
                .HasForeignKey(d => d.IdKartice)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TRANSAKCI__idKar__56E8E7AB");

            entity.HasOne(d => d.IdVrsteTransakcijeNavigation).WithMany(p => p.Transakcijas)
                .HasForeignKey(d => d.IdVrsteTransakcije)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TRANSAKCI__idVrs__55F4C372");
        });

        modelBuilder.Entity<Uloga>(entity =>
        {
            entity.HasKey(e => e.IdUloge).HasName("PK__ULOGA__8EAAF5CC42812542");

            entity.ToTable("ULOGA");

            entity.Property(e => e.IdUloge).HasColumnName("idUloge");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
        });

        modelBuilder.Entity<VrstaDokumenta>(entity =>
        {
            entity.HasKey(e => e.IdVrsteDokumenta).HasName("PK__VRSTA_DO__DB5237D2909A00D0");

            entity.ToTable("VRSTA_DOKUMENTA");

            entity.Property(e => e.IdVrsteDokumenta).HasColumnName("idVrsteDokumenta");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<VrstaPosla>(entity =>
        {
            entity.HasKey(e => e.IdVrstePosla).HasName("PK__VRSTA_PO__1918DFF92B1DAB73");

            entity.ToTable("VRSTA_POSLA");

            entity.Property(e => e.IdVrstePosla).HasColumnName("idVrstePosla");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
        });

        modelBuilder.Entity<VrstaProjekta>(entity =>
        {
            entity.HasKey(e => e.IdVrsteProjekta).HasName("PK__VRSTA_PR__E5C915C09D85E9AB");

            entity.ToTable("VRSTA_PROJEKTA");

            entity.Property(e => e.IdVrsteProjekta).HasColumnName("idVrsteProjekta");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<VrstaTransakcije>(entity =>
        {
            entity.HasKey(e => e.IdVrsteTransakcije).HasName("PK__VRSTA_TR__0DADCF4E25EF4D36");

            entity.ToTable("VRSTA_TRANSAKCIJE");

            entity.Property(e => e.IdVrsteTransakcije).HasColumnName("idVrsteTransakcije");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<VrstaZahtjeva>(entity =>
        {
            entity.HasKey(e => e.IdVrsteZahtjeva).HasName("PK__VRSTA_ZA__195EF103A772BEA6");

            entity.ToTable("VRSTA_ZAHTJEVA");

            entity.Property(e => e.IdVrsteZahtjeva).HasColumnName("idVrsteZahtjeva");
            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naziv");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<Zadatak>(entity =>
        {
            entity.HasKey(e => e.IdZadatka).HasName("PK__ZADATAK__05C4D6B137F0ACA6");

            entity.ToTable("ZADATAK");

            entity.Property(e => e.IdZadatka).HasColumnName("idZadatka");
            
            entity.Property(e => e.ImeZadatka)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("imeZadatka");
            
            entity.Property(e => e.IdPrioriteta).HasColumnName("idPrioriteta");
            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.IdZahtjeva).HasColumnName("idZahtjeva");
            entity.Property(e => e.Oibosoba).HasColumnName("OIBosoba");
            entity.Property(e => e.PlaniraniPocetak)
                .HasColumnType("date")
                .HasColumnName("planiraniPocetak");
            entity.Property(e => e.PlaniraniZavrsetak)
                .HasColumnType("date")
                .HasColumnName("planiraniZavrsetak");
            entity.Property(e => e.StvarniPocetak)
                .HasColumnType("date")
                .HasColumnName("stvarniPocetak");
            entity.Property(e => e.StvarniZavrsetak)
                .HasColumnType("date")
                .HasColumnName("stvarniZavrsetak");

            entity.HasOne(d => d.IdPrioritetaNavigation).WithMany(p => p.Zadataks)
                .HasForeignKey(d => d.IdPrioriteta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZADATAK__idPrior__5CA1C101");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Zadataks)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZADATAK__idStatu__5AB9788F");

            entity.HasOne(d => d.IdZahtjevaNavigation).WithMany(p => p.Zadataks)
                .HasForeignKey(d => d.IdZahtjeva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZADATAK__idZahtj__59C55456");

            entity.HasOne(d => d.OibosobaNavigation).WithMany(p => p.Zadataks)
                .HasForeignKey(d => d.Oibosoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZADATAK__OIBosob__5BAD9CC8");
        });

        modelBuilder.Entity<Zahtjev>(entity =>
        {
            entity.HasKey(e => e.IdZahtjeva).HasName("PK__ZAHTJEV__77C21E52AE9DD755");

            entity.ToTable("ZAHTJEV");

            entity.Property(e => e.IdZahtjeva).HasColumnName("idZahtjeva");
            entity.Property(e => e.IdPrioriteta).HasColumnName("idPrioriteta");
            entity.Property(e => e.IdProjekta).HasColumnName("idProjekta");
            entity.Property(e => e.IdVrsteZahtjeva).HasColumnName("idVrsteZahtjeva");
            entity.Property(e => e.Naslov)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("naslov");
            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("opis");

            entity.HasOne(d => d.IdPrioritetaNavigation).WithMany(p => p.Zahtjevs)
                .HasForeignKey(d => d.IdPrioriteta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZAHTJEV__idPrior__42E1EEFE");

            entity.HasOne(d => d.IdProjektaNavigation).WithMany(p => p.Zahtjevs)
                .HasForeignKey(d => d.IdProjekta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZAHTJEV__idProje__43D61337");

            entity.HasOne(d => d.IdVrsteZahtjevaNavigation).WithMany(p => p.Zahtjevs)
                .HasForeignKey(d => d.IdVrsteZahtjeva)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ZAHTJEV__idVrste__41EDCAC5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}