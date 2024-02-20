namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tlpanal
{
    public string? Hotelcode { get; set; }
    public string? Groupid { get; set; }
    public string? Workstatid { get; set; }
    public string? Analystype { get; set; }
    public string? Groupchgd { get; set; }
    public DateTime? Arrdate { get; set; }
    public DateTime? Depdate { get; set; }
    public decimal? Navgrte { get; set; }
    public decimal? Nadjavgrte { get; set; }
    public decimal? Navgrevhrd { get; set; }
    public decimal? Navgrevimp { get; set; }
    public decimal? Navgwlkpen { get; set; }
    public decimal? Navgbkgpts { get; set; }
    public decimal? Ngrpcntrb { get; set; }
    public decimal? Nadjgrpcnt { get; set; }
    public decimal? Nrevhrd { get; set; }
    public decimal? Ntrnrevimp { get; set; }
    public decimal? Nwlkpen { get; set; }
    public decimal? Nbkgpts { get; set; }
    public string? Oldresults { get; set; }
    public DateTime? Oarrdate { get; set; }
    public DateTime? Odepdate { get; set; }
    public decimal? Oavgrte { get; set; }
    public decimal? Oadjavgrte { get; set; }
    public decimal? Oavgrevhrd { get; set; }
    public decimal? Oavgrevimp { get; set; }
    public decimal? Oavgwlkpen { get; set; }
    public decimal? Oavgbkgpts { get; set; }
    public decimal? Ogrpcntrb { get; set; }
    public decimal? Oadjgrpcnt { get; set; }
    public decimal? Orevhrd { get; set; }
    public decimal? Otrnrevimp { get; set; }
    public decimal? Owlkpen { get; set; }
    public decimal? Obkgpts { get; set; }
    public decimal? Benewanal { get; set; }
    public decimal? Bebkgpts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tlpanal>(entity =>
        {
            entity.HasKey(e => new { e.Hotelcode, e.Groupid, e.Workstatid, e.Arrdate })
                .HasName("TLPA_PK");

            entity.ToTable("TLPANAL");

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

            entity.Property(e => e.Arrdate)
                .HasColumnName("ARRDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Analystype)
                .IsRequired()
                .HasColumnName("ANALYSTYPE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Bebkgpts)
                .HasColumnName("BEBKGPTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Benewanal)
                .HasColumnName("BENEWANAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Depdate)
                .HasColumnName("DEPDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Groupchgd)
                .IsRequired()
                .HasColumnName("GROUPCHGD")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'F'");

            entity.Property(e => e.Nadjavgrte)
                .HasColumnName("NADJAVGRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nadjgrpcnt)
                .HasColumnName("NADJGRPCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Navgbkgpts)
                .HasColumnName("NAVGBKGPTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Navgrevhrd)
                .HasColumnName("NAVGREVHRD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Navgrevimp)
                .HasColumnName("NAVGREVIMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Navgrte)
                .HasColumnName("NAVGRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Navgwlkpen)
                .HasColumnName("NAVGWLKPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nbkgpts)
                .HasColumnName("NBKGPTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ngrpcntrb)
                .HasColumnName("NGRPCNTRB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nrevhrd)
                .HasColumnName("NREVHRD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ntrnrevimp)
                .HasColumnName("NTRNREVIMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nwlkpen)
                .HasColumnName("NWLKPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oadjavgrte)
                .HasColumnName("OADJAVGRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oadjgrpcnt)
                .HasColumnName("OADJGRPCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oarrdate)
                .HasColumnName("OARRDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Oavgbkgpts)
                .HasColumnName("OAVGBKGPTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oavgrevhrd)
                .HasColumnName("OAVGREVHRD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oavgrevimp)
                .HasColumnName("OAVGREVIMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oavgrte)
                .HasColumnName("OAVGRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oavgwlkpen)
                .HasColumnName("OAVGWLKPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Obkgpts)
                .HasColumnName("OBKGPTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Odepdate)
                .HasColumnName("ODEPDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Ogrpcntrb)
                .HasColumnName("OGRPCNTRB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oldresults)
                .HasColumnName("OLDRESULTS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Orevhrd)
                .HasColumnName("OREVHRD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Otrnrevimp)
                .HasColumnName("OTRNREVIMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owlkpen)
                .HasColumnName("OWLKPEN")
                .HasColumnType("NUMBER");
        });
	}
}
