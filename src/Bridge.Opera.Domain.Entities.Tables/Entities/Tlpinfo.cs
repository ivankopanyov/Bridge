namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tlpinfo
{
    public string? Hotelcode { get; set; }
    public string? Groupid { get; set; }
    public string? Workstatid { get; set; }
    public string? Groupname { get; set; }
    public string? Grpabbrev { get; set; }
    public string? Eventname { get; set; }
    public string? Acctcode { get; set; }
    public string? Status { get; set; }
    public string? Salesmgr { get; set; }
    public DateTime? Earlyarrdt { get; set; }
    public DateTime? Arrdate { get; set; }
    public DateTime? Depdate { get; set; }
    public DateTime? Latedepdt { get; set; }
    public string? Mktseg { get; set; }
    public byte? Sglocc { get; set; }
    public byte? Dblocc { get; set; }
    public byte? Tplocc { get; set; }
    public byte? Quadocc { get; set; }
    public byte? Extraocc { get; set; }
    public string? Rohflag { get; set; }
    public decimal? Fbperson { get; set; }
    public int? Localguest { get; set; }
    public decimal? Fbbooking { get; set; }
    public decimal? Netothrrev { get; set; }
    public decimal? Netothrcst { get; set; }
    public decimal? Rebatebkg { get; set; }
    public decimal? Rebatern { get; set; }
    public decimal? Commpct { get; set; }
    public int? Compbkg { get; set; }
    public int? Comprn { get; set; }
    public DateTime? Firstarrdt { get; set; }
    public DateTime? Lastarrdt { get; set; }
    public string? Sunarrflag { get; set; }
    public string? Monarrflag { get; set; }
    public string? Tuearrflag { get; set; }
    public string? Wedarrflag { get; set; }
    public string? Thuarrflag { get; set; }
    public string? Friarrflag { get; set; }
    public string? Satarrflag { get; set; }
    public string? Resgrpid { get; set; }
    public string? Cutofftype { get; set; }
    public int? Cutoffdays { get; set; }
    public string? Grouptype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tlpinfo>(entity =>
        {
            entity.HasKey(e => new { e.Hotelcode, e.Groupid, e.Workstatid })
                .HasName("TLPI_PK");

            entity.ToTable("TLPINFO");

            entity.Property(e => e.Hotelcode)
                .HasColumnName("HOTELCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Groupid)
                .HasColumnName("GROUPID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Workstatid)
                .HasColumnName("WORKSTATID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Acctcode)
                .HasColumnName("ACCTCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Arrdate)
                .HasColumnName("ARRDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Commpct)
                .HasColumnName("COMMPCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Compbkg)
                .HasColumnName("COMPBKG")
                .HasColumnType("NUMBER(6)");

            entity.Property(e => e.Comprn)
                .HasColumnName("COMPRN")
                .HasColumnType("NUMBER(6)");

            entity.Property(e => e.Cutoffdays)
                .HasColumnName("CUTOFFDAYS")
                .HasColumnType("NUMBER(6)");

            entity.Property(e => e.Cutofftype)
                .HasColumnName("CUTOFFTYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Dblocc).HasColumnName("DBLOCC");

            entity.Property(e => e.Depdate)
                .HasColumnName("DEPDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Earlyarrdt)
                .HasColumnName("EARLYARRDT")
                .HasColumnType("DATE");

            entity.Property(e => e.Eventname)
                .IsRequired()
                .HasColumnName("EVENTNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Extraocc).HasColumnName("EXTRAOCC");

            entity.Property(e => e.Fbbooking)
                .HasColumnName("FBBOOKING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fbperson)
                .HasColumnName("FBPERSON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Firstarrdt)
                .HasColumnName("FIRSTARRDT")
                .HasColumnType("DATE");

            entity.Property(e => e.Friarrflag)
                .HasColumnName("FRIARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");

            entity.Property(e => e.Groupname)
                .IsRequired()
                .HasColumnName("GROUPNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Grouptype)
                .IsRequired()
                .HasColumnName("GROUPTYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'G'");

            entity.Property(e => e.Grpabbrev)
                .HasColumnName("GRPABBREV")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Lastarrdt)
                .HasColumnName("LASTARRDT")
                .HasColumnType("DATE");

            entity.Property(e => e.Latedepdt)
                .HasColumnName("LATEDEPDT")
                .HasColumnType("DATE");

            entity.Property(e => e.Localguest)
                .HasColumnName("LOCALGUEST")
                .HasColumnType("NUMBER(6)");

            entity.Property(e => e.Mktseg)
                .IsRequired()
                .HasColumnName("MKTSEG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Monarrflag)
                .HasColumnName("MONARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");

            entity.Property(e => e.Netothrcst)
                .HasColumnName("NETOTHRCST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Netothrrev)
                .HasColumnName("NETOTHRREV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quadocc).HasColumnName("QUADOCC");

            entity.Property(e => e.Rebatebkg)
                .HasColumnName("REBATEBKG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rebatern)
                .HasColumnName("REBATERN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resgrpid)
                .HasColumnName("RESGRPID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rohflag)
                .HasColumnName("ROHFLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Salesmgr)
                .IsRequired()
                .HasColumnName("SALESMGR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Satarrflag)
                .HasColumnName("SATARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");

            entity.Property(e => e.Sglocc).HasColumnName("SGLOCC");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sunarrflag)
                .HasColumnName("SUNARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");

            entity.Property(e => e.Thuarrflag)
                .HasColumnName("THUARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");

            entity.Property(e => e.Tplocc).HasColumnName("TPLOCC");

            entity.Property(e => e.Tuearrflag)
                .HasColumnName("TUEARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");

            entity.Property(e => e.Wedarrflag)
                .HasColumnName("WEDARRFLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'F'");
        });
	}
}
