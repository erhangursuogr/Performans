using System;
using System.Collections.Generic;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EntityLayer.Context;

public partial class OraContext : DbContext
{
    public OraContext()
    {
    }

    public OraContext(DbContextOptions<OraContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PerfCalisanAmir> PerfCalisanAmir { get; set; }

    public virtual DbSet<PerfCalisanAmirListe> PerfCalisanAmirListe { get; set; }

    public virtual DbSet<PerfDegerlendirme> PerfDegerlendirme { get; set; }

    public virtual DbSet<PerfDonem> PerfDonem { get; set; }

    public virtual DbSet<PerfKariyer> PerfKariyer { get; set; }

    public virtual DbSet<PerfKodAciklama> PerfKodAciklama { get; set; }

    public virtual DbSet<PerfKodAmir> PerfKodAmir { get; set; }

    public virtual DbSet<PerfKodKariyer> PerfKodKariyer { get; set; }

    public virtual DbSet<PerfKonular> PerfKonular { get; set; }

    public virtual DbSet<PerfSorular> PerfSorular { get; set; }

    public virtual DbSet<PerfTmpAmir> PerfTmpAmir { get; set; }

    public virtual DbSet<PerfTmpCalisan> PerfTmpCalisan { get; set; }

    public virtual DbSet<VPerfCalisanAmir> VPerfCalisanAmir { get; set; }

    public virtual DbSet<VPerfCalisanAmirListe> VPerfCalisanAmirListe { get; set; }

    public virtual DbSet<VPerfListe> VPerfListes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseOracle("User Id=XXSICIL;Password=9_CILL10X;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=deudbmc-scan.isx.deu.edu.tr)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=RACDEU)))")
            .UseOracle(x => x.UseOracleSQLCompatibility("11"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("XXSICIL");

        modelBuilder.Entity<PerfCalisanAmir>(entity =>
        {
            entity.HasKey(e => new { e.DonemId, e.TcKimlikNo, e.GorevYeri, e.IdariGorevKodu, e.GorevBirimKodu, e.OrgBirimKodu, e.OrgUstBirimKodu, e.SicilBirimkodu });

            entity.ToTable("PERF_CALISAN_AMIR");

            entity.Property(e => e.DonemId)
                .HasColumnType("NUMBER")
                .HasColumnName("DONEM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("IDARI_GOREV_KODU");
            entity.Property(e => e.GorevBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_BIRIM_KODU");
            entity.Property(e => e.OrgBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_BIRIM_KODU");
            entity.Property(e => e.OrgUstBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_UST_BIRIM_KODU");
            entity.Property(e => e.SicilBirimkodu)
                .HasColumnType("NUMBER")
                .HasColumnName("SICIL_BIRIMKODU");
            entity.Property(e => e.A1IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("A1_IDARI_GOREV_KODU");
            entity.Property(e => e.A1TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("A1_TC_KIMLIK_NO");
            entity.Property(e => e.A2IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("A2_IDARI_GOREV_KODU");
            entity.Property(e => e.A2TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("A2_TC_KIMLIK_NO");
            entity.Property(e => e.Aktar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'H'")
                .IsFixedLength()
                .HasColumnName("AKTAR");
            entity.Property(e => e.BirimAdi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BIRIM_ADI");
            entity.Property(e => e.Onay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'H'")
                .IsFixedLength()
                .HasColumnName("ONAY");
            entity.Property(e => e.OnayBilgi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ONAY_BILGI");
            entity.Property(e => e.UpdateBilgi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UPDATE_BILGI");
        });

        modelBuilder.Entity<PerfCalisanAmirListe>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.FDonemId });

            entity.ToTable("PERF_CALISAN_AMIR_LISTE");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.A1Debisid)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A1_DEBISID");
            entity.Property(e => e.A1IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A1_IDARI_GOREV_KODU");
            entity.Property(e => e.A1TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A1_TC_KIMLIK_NO");
            entity.Property(e => e.A1Update)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("A1_UPDATE");
            entity.Property(e => e.A2IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A2_IDARI_GOREV_KODU");
            entity.Property(e => e.A2TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A2_TC_KIMLIK_NO");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AdiSoyadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADI_SOYADI");
            entity.Property(e => e.AkdUnv1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKD_UNV1");
            entity.Property(e => e.AkdUnv2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKD_UNV2");
            entity.Property(e => e.AmirDebisid)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("AMIR_DEBISID");
            entity.Property(e => e.AmirGorus)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("AMIR_GORUS");
            entity.Property(e => e.AmirIdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("AMIR_IDARI_GOREV_KODU");
            entity.Property(e => e.AmirOnay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMIR_ONAY");
            entity.Property(e => e.AmirTcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMIR_TC_KIMLIK_NO");
            entity.Property(e => e.AmirUpdate)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AMIR_UPDATE");
            entity.Property(e => e.Amirmi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMIRMI");
            entity.Property(e => e.BasTar)
                .HasColumnType("DATE")
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.Degerlendirme)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEGERLENDIRME");
            entity.Property(e => e.GelistirmeAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("GELISTIRME_ACIKLAMA");
            entity.Property(e => e.GeriBildirim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GERI_BILDIRIM");
            entity.Property(e => e.GorevBirimKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("GOREV_BIRIM_KODU");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.GucluyonAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("GUCLUYON_ACIKLAMA");
            entity.Property(e => e.IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("IDARI_GOREV_KODU");
            entity.Property(e => e.IptalNedeni)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("IPTAL_NEDENI");
            entity.Property(e => e.Itiraz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ITIRAZ");
            entity.Property(e => e.ItirazAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ITIRAZ_ACIKLAMA");
            entity.Property(e => e.KadroUnv1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KADRO_UNV1");
            entity.Property(e => e.KadroUnv2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KADRO_UNV2");
            entity.Property(e => e.Kilit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KILIT");
            entity.Property(e => e.Komisyon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KOMISYON");
            entity.Property(e => e.KomisyonAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("KOMISYON_ACIKLAMA");
            entity.Property(e => e.PerformansPuani)
                .HasColumnType("NUMBER(5,2)")
                .HasColumnName("PERFORMANS_PUANI");
            entity.Property(e => e.SicilBirimkodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("SICIL_BIRIMKODU");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SICILNO");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TC_KIMLIK_NO");

            entity.HasOne(d => d.FDonem).WithMany(p => p.PerfCalisanAmirListes)
                .HasForeignKey(d => d.FDonemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_DONEM_CALISAN");
        });

        modelBuilder.Entity<PerfDegerlendirme>(entity =>
        {
            entity.HasKey(e => new { e.FCalisanId, e.FDonemId, e.FSoruId, e.FKonuId, e.FKonuTurId, e.FKonuSiraNo });

            entity.ToTable("PERF_DEGERLENDIRME");

            entity.Property(e => e.FCalisanId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_CALISAN_ID");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.FSoruId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_SORU_ID");
            entity.Property(e => e.FKonuId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KONU_ID");
            entity.Property(e => e.FKonuTurId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KONU_TUR_ID");
            entity.Property(e => e.FKonuSiraNo)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KONU_SIRA_NO");
            entity.Property(e => e.Amirmi)
                .HasColumnType("NUMBER")
                .HasColumnName("AMIRMI");
            entity.Property(e => e.Puan)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("PUAN");

            entity.HasOne(d => d.F).WithMany(p => p.PerfDegerlendirmes)
                .HasForeignKey(d => new { d.FCalisanId, d.FDonemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_CALISAN_DEGERLENDIRME");

            entity.HasOne(d => d.FNavigation).WithMany(p => p.PerfDegerlendirmes)
                .HasForeignKey(d => new { d.FSoruId, d.FKonuId, d.FKonuTurId, d.FKonuSiraNo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_SORU_DEGERLENDIRME");
        });

        modelBuilder.Entity<PerfDonem>(entity =>
        {
            entity.ToTable("PERF_DONEM");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Donem)
                .HasColumnType("NUMBER")
                .HasColumnName("DONEM");
            entity.Property(e => e.Durum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DURUM");
            entity.Property(e => e.Tarih)
                .HasColumnType("DATE")
                .HasColumnName("TARIH");
            entity.Property(e => e.Yil)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<PerfKariyer>(entity =>
        {
            entity.HasKey(e => new { e.FKariyerId, e.FCalisanId, e.FDonemId });

            entity.ToTable("PERF_KARIYER");

            entity.Property(e => e.FKariyerId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KARIYER_ID");
            entity.Property(e => e.FCalisanId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_CALISAN_ID");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.EvetHayir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EVET_HAYIR");
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KONU");
            entity.Property(e => e.SiraNo)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("SIRA_NO");

            entity.HasOne(d => d.FKariyer).WithMany(p => p.PerfKariyers)
                .HasForeignKey(d => d.FKariyerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_KODKARIYER_KARIYER");

            entity.HasOne(d => d.F).WithMany(p => p.PerfKariyers)
                .HasForeignKey(d => new { d.FCalisanId, d.FDonemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_CALISAN_KARIYER");
        });

        modelBuilder.Entity<PerfKodAciklama>(entity =>
        {
            entity.ToTable("PERF_KOD_ACIKLAMA");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.Puan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PUAN");
            entity.Property(e => e.TurId)
                .HasColumnType("NUMBER")
                .HasColumnName("TUR_ID");

            entity.HasOne(d => d.FDonem).WithMany(p => p.PerfKodAciklamas)
                .HasForeignKey(d => d.FDonemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_DONEM_ACIKLAMA");
        });

        modelBuilder.Entity<PerfKodAmir>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.KodIdrGrv });

            entity.ToTable("PERF_KOD_AMIR");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER")
                .HasColumnName("ID");
            entity.Property(e => e.KodIdrGrv)
                .HasColumnType("NUMBER")
                .HasColumnName("KOD_IDR_GRV");
            entity.Property(e => e.Amir1)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER")
                .HasColumnName("AMIR_1");
            entity.Property(e => e.Amir1V)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER")
                .HasColumnName("AMIR_1_V");
            entity.Property(e => e.Amir2)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER")
                .HasColumnName("AMIR_2");
            entity.Property(e => e.Amir2V)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMBER")
                .HasColumnName("AMIR_2_V");
            entity.Property(e => e.AmirUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AMIR_UNVAN");
            entity.Property(e => e.KurumTip)
                .HasColumnType("NUMBER")
                .HasColumnName("KURUM_TIP");
            entity.Property(e => e.Seviye)
                .HasDefaultValueSql("4\n")
                .HasColumnType("NUMBER")
                .HasColumnName("SEVIYE");
            entity.Property(e => e.Sinif)
                .HasColumnType("NUMBER")
                .HasColumnName("SINIF");
            entity.Property(e => e.Unvan)
                .HasColumnType("NUMBER")
                .HasColumnName("UNVAN");
        });

        modelBuilder.Entity<PerfKodKariyer>(entity =>
        {
            entity.ToTable("PERF_KOD_KARIYER");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.SiraNo)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("SIRA_NO");

            entity.HasOne(d => d.FDonem).WithMany(p => p.PerfKodKariyers)
                .HasForeignKey(d => d.FDonemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_DONEM_KODKARIYER");
        });

        modelBuilder.Entity<PerfKonular>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TurId, e.SiraNo, e.FDonemId });

            entity.ToTable("PERF_KONULAR");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.TurId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("TUR_ID");
            entity.Property(e => e.SiraNo)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("SIRA_NO");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.Konu)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("KONU");

            entity.HasOne(d => d.FDonem).WithMany(p => p.PerfKonulars)
                .HasForeignKey(d => d.FDonemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_DONEM_KONU");
        });

        modelBuilder.Entity<PerfSorular>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.FKonuId, e.FKonuTurId, e.FKonuSiraNo });

            entity.ToTable("PERF_SORULAR");

            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.FKonuId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KONU_ID");
            entity.Property(e => e.FKonuTurId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KONU_TUR_ID");
            entity.Property(e => e.FKonuSiraNo)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_KONU_SIRA_NO");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.SiraNo)
                .HasColumnType("NUMBER")
                .HasColumnName("SIRA_NO");
            entity.Property(e => e.Soru)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SORU");

            entity.HasOne(d => d.F).WithMany(p => p.PerfSorulars)
                .HasForeignKey(d => new { d.FKonuId, d.FKonuTurId, d.FKonuSiraNo, d.FDonemId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_KONU_SORU");
        });

        modelBuilder.Entity<PerfTmpAmir>(entity =>
        {
            entity.HasKey(e => new { e.DonemId, e.TcKimlikNo, e.IdariGorevKodu, e.GorevKurumYeri });

            entity.ToTable("PERF_TMP_AMIR");

            entity.Property(e => e.DonemId)
                .HasColumnType("NUMBER")
                .HasColumnName("DONEM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("IDARI_GOREV_KODU");
            entity.Property(e => e.GorevKurumYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_KURUM_YERI");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AkadUnv1)
                .HasColumnType("NUMBER")
                .HasColumnName("AKAD_UNV1");
            entity.Property(e => e.AkadUnv2)
                .HasColumnType("NUMBER")
                .HasColumnName("AKAD_UNV2");
            entity.Property(e => e.Aktif)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKTIF");
            entity.Property(e => e.AnabilimAdi)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ANABILIM_ADI");
            entity.Property(e => e.AnabilimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ANABILIM_KODU");
            entity.Property(e => e.ArsivNo)
                .HasColumnType("NUMBER")
                .HasColumnName("ARSIV_NO");
            entity.Property(e => e.ArsivYil)
                .HasColumnType("NUMBER")
                .HasColumnName("ARSIV_YIL");
            entity.Property(e => e.GorevBasTar)
                .HasColumnType("DATE")
                .HasColumnName("GOREV_BAS_TAR");
            entity.Property(e => e.GorevBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_BIRIM_KODU");
            entity.Property(e => e.GorevBitTar)
                .HasColumnType("DATE")
                .HasColumnName("GOREV_BIT_TAR");
            entity.Property(e => e.GorevNereden)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GOREV_NEREDEN");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.IdariGorev)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IDARI_GOREV");
            entity.Property(e => e.InsertBilgi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INSERT_BILGI");
            entity.Property(e => e.KAnabilimAdi)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("K_ANABILIM_ADI");
            entity.Property(e => e.KAnabilimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("K_ANABILIM_KODU");
            entity.Property(e => e.KOrgBirimAdi)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("K_ORG_BIRIM_ADI");
            entity.Property(e => e.KOrgBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("K_ORG_BIRIM_KODU");
            entity.Property(e => e.KadroDurumu)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_DURUMU");
            entity.Property(e => e.KadroUnv1)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_UNV1");
            entity.Property(e => e.KadroUnv2)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_UNV2");
            entity.Property(e => e.KadroYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_YERI");
            entity.Property(e => e.KurumTip)
                .HasColumnType("NUMBER")
                .HasColumnName("KURUM_TIP");
            entity.Property(e => e.OrgBirimAdi)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ORG_BIRIM_ADI");
            entity.Property(e => e.OrgBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_BIRIM_KODU");
            entity.Property(e => e.OrgEnustBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_ENUST_BIRIM_KODU");
            entity.Property(e => e.OrgSicilBirimkodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_SICIL_BIRIMKODU");
            entity.Property(e => e.OrgUstBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_UST_BIRIM_KODU");
            entity.Property(e => e.SicilNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SICIL_NO");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.UpdateBilgi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UPDATE_BILGI");
        });

        modelBuilder.Entity<PerfTmpCalisan>(entity =>
        {
            entity.HasKey(e => new { e.DonemId, e.TcKimlikNo, e.IdariGorevKodu, e.GorevYeri });

            entity.ToTable("PERF_TMP_CALISAN");

            entity.Property(e => e.DonemId)
                .HasColumnType("NUMBER")
                .HasColumnName("DONEM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("IDARI_GOREV_KODU");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADI");
            entity.Property(e => e.AkadUnv1)
                .HasColumnType("NUMBER")
                .HasColumnName("AKAD_UNV1");
            entity.Property(e => e.AkadUnv2)
                .HasColumnType("NUMBER")
                .HasColumnName("AKAD_UNV2");
            entity.Property(e => e.Amirmi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'H'")
                .IsFixedLength()
                .HasColumnName("AMIRMI");
            entity.Property(e => e.AnabilimAdi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ANABILIM_ADI");
            entity.Property(e => e.AnabilimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ANABILIM_KODU");
            entity.Property(e => e.ArsivNo)
                .HasColumnType("NUMBER")
                .HasColumnName("ARSIV_NO");
            entity.Property(e => e.ArsivYil)
                .HasColumnType("NUMBER")
                .HasColumnName("ARSIV_YIL");
            entity.Property(e => e.BirimBasTar)
                .HasColumnType("DATE")
                .HasColumnName("BIRIM_BAS_TAR");
            entity.Property(e => e.GorevBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_BIRIM_KODU");
            entity.Property(e => e.GorevNereden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GOREV_NEREDEN");
            entity.Property(e => e.InsertBilgi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INSERT_BILGI");
            entity.Property(e => e.KadroDurumu)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_DURUMU");
            entity.Property(e => e.KadroUnv1)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_UNV1");
            entity.Property(e => e.KadroUnv2)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_UNV2");
            entity.Property(e => e.KadroYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_YERI");
            entity.Property(e => e.KurumTip)
                .HasColumnType("NUMBER")
                .HasColumnName("KURUM_TIP");
            entity.Property(e => e.OrgBirimAdi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ORG_BIRIM_ADI");
            entity.Property(e => e.OrgBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_BIRIM_KODU");
            entity.Property(e => e.OrgEnustBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_ENUST_BIRIM_KODU");
            entity.Property(e => e.OrgSicilBirimkodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_SICIL_BIRIMKODU");
            entity.Property(e => e.OrgUstBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_UST_BIRIM_KODU");
            entity.Property(e => e.SicilNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SICIL_NO");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOYADI");
            entity.Property(e => e.UpdateBilgi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UPDATE_BILGI");
        });

        modelBuilder.Entity<VPerfCalisanAmir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PERF_CALISAN_AMIR");

            entity.Property(e => e.A1IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("A1_IDARI_GOREV_KODU");
            entity.Property(e => e.A1TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("A1_TC_KIMLIK_NO");
            entity.Property(e => e.A2IdariGorevKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("A2_IDARI_GOREV_KODU");
            entity.Property(e => e.A2TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("A2_TC_KIMLIK_NO");
            entity.Property(e => e.Adsoyad)
                .HasMaxLength(422)
                .IsUnicode(false)
                .HasColumnName("ADSOYAD");
            entity.Property(e => e.Aktar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKTAR");
            entity.Property(e => e.Amir1)
                .HasMaxLength(825)
                .IsUnicode(false)
                .HasColumnName("AMIR1");
            entity.Property(e => e.Amir2)
                .HasMaxLength(825)
                .IsUnicode(false)
                .HasColumnName("AMIR2");
            entity.Property(e => e.CalistigiBirim)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CALISTIGI_BIRIM");
            entity.Property(e => e.DonemId)
                .HasColumnType("NUMBER")
                .HasColumnName("DONEM_ID");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.GorevYeriAdi)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("GOREV_YERI_ADI");
            entity.Property(e => e.KadroUnv1)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_UNV1");
            entity.Property(e => e.KadroUnv2)
                .HasColumnType("NUMBER")
                .HasColumnName("KADRO_UNV2");
            entity.Property(e => e.Onay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ONAY");
            entity.Property(e => e.OrgBirimKodu)
                .HasColumnType("NUMBER")
                .HasColumnName("ORG_BIRIM_KODU");
            entity.Property(e => e.SicilBirimi)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("SICIL_BIRIMI");
            entity.Property(e => e.SicilBirimkodu)
                .HasColumnType("NUMBER")
                .HasColumnName("SICIL_BIRIMKODU");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TC_KIMLIK_NO");
        });

        modelBuilder.Entity<VPerfCalisanAmirListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PERF_CALISAN_AMIR_LISTE");

            entity.Property(e => e.A1IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A1_IDARI_GOREV_KODU");
            entity.Property(e => e.A1TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A1_TC_KIMLIK_NO");
            entity.Property(e => e.A2IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A2_IDARI_GOREV_KODU");
            entity.Property(e => e.A2TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A2_TC_KIMLIK_NO");
            entity.Property(e => e.Adsoyad)
                .HasMaxLength(421)
                .IsUnicode(false)
                .HasColumnName("ADSOYAD");
            entity.Property(e => e.Amir1)
                .HasMaxLength(825)
                .IsUnicode(false)
                .HasColumnName("AMIR_1");
            entity.Property(e => e.Amir2)
                .HasMaxLength(825)
                .IsUnicode(false)
                .HasColumnName("AMIR_2");
            entity.Property(e => e.CalistigiBirim)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CALISTIGI_BIRIM");
            entity.Property(e => e.CalistigiKurum)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("CALISTIGI_KURUM");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.GorevBirimKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("GOREV_BIRIM_KODU");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.SicilBirimkodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("SICIL_BIRIMKODU");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TC_KIMLIK_NO");
        });

        modelBuilder.Entity<VPerfListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PERF_LISTE");

            entity.Property(e => e.A1Debisid)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A1_DEBISID");
            entity.Property(e => e.A1IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A1_IDARI_GOREV_KODU");
            entity.Property(e => e.A1TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A1_TC_KIMLIK_NO");
            entity.Property(e => e.A1Update)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("A1_UPDATE");
            entity.Property(e => e.A2IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("A2_IDARI_GOREV_KODU");
            entity.Property(e => e.A2TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("A2_TC_KIMLIK_NO");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AdiSoyadi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADI_SOYADI");
            entity.Property(e => e.AkdUnv1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKD_UNV1");
            entity.Property(e => e.AkdUnv2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKD_UNV2");
            entity.Property(e => e.AmirDebisid)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("AMIR_DEBISID");
            entity.Property(e => e.AmirGorus)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("AMIR_GORUS");
            entity.Property(e => e.AmirIdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("AMIR_IDARI_GOREV_KODU");
            entity.Property(e => e.AmirOnay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMIR_ONAY");
            entity.Property(e => e.AmirTcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMIR_TC_KIMLIK_NO");
            entity.Property(e => e.AmirUpdate)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AMIR_UPDATE");
            entity.Property(e => e.Amirmi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AMIRMI");
            entity.Property(e => e.BasTar)
                .HasColumnType("DATE")
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.Degerlendirme)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DEGERLENDIRME");
            entity.Property(e => e.FDonemId)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("F_DONEM_ID");
            entity.Property(e => e.GelistirmeAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("GELISTIRME_ACIKLAMA");
            entity.Property(e => e.GeriBildirim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GERI_BILDIRIM");
            entity.Property(e => e.GorevBirimKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("GOREV_BIRIM_KODU");
            entity.Property(e => e.GorevYeri)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("GOREV_YERI");
            entity.Property(e => e.GucluyonAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("GUCLUYON_ACIKLAMA");
            entity.Property(e => e.Id)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.IdariGorevKodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("IDARI_GOREV_KODU");
            entity.Property(e => e.IptalNedeni)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("IPTAL_NEDENI");
            entity.Property(e => e.Itiraz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ITIRAZ");
            entity.Property(e => e.ItirazAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ITIRAZ_ACIKLAMA");
            entity.Property(e => e.KadroUnv1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KADRO_UNV1");
            entity.Property(e => e.KadroUnv2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KADRO_UNV2");
            entity.Property(e => e.Kilit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KILIT");
            entity.Property(e => e.Komisyon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KOMISYON");
            entity.Property(e => e.KomisyonAciklama)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("KOMISYON_ACIKLAMA");
            entity.Property(e => e.PerformansPuani)
                .HasColumnType("NUMBER(5,2)")
                .HasColumnName("PERFORMANS_PUANI");
            entity.Property(e => e.SicilBirimkodu)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("SICIL_BIRIMKODU");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SICILNO");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TC_KIMLIK_NO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}