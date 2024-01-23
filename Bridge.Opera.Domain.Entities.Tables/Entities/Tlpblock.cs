namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tlpblock
{
    public string Hotelcode { get; set; }
    public string Groupid { get; set; }
    public string Workstatid { get; set; }
    public string Rmtypecode { get; set; }
    public DateTime Blockdate { get; set; }
    public decimal? Block { get; set; }
    public decimal? Forecast { get; set; }
    public decimal? Sglocc { get; set; }
    public decimal? Dblocc { get; set; }
    public decimal? Tplocc { get; set; }
    public decimal? Quadocc { get; set; }
    public decimal? Extraocc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tlpblock>(entity =>
        {
            entity.HasKey(e => new { e.Hotelcode, e.Groupid, e.Workstatid, e.Blockdate, e.Rmtypecode })
                .HasName("TLPB_PK");

            entity.ToTable("TLPBLOCK");

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

            entity.Property(e => e.Blockdate)
                .HasColumnName("BLOCKDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Rmtypecode)
                .HasColumnName("RMTYPECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Block)
                .HasColumnName("BLOCK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dblocc)
                .HasColumnName("DBLOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Extraocc)
                .HasColumnName("EXTRAOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Forecast)
                .HasColumnName("FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quadocc)
                .HasColumnName("QUADOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sglocc)
                .HasColumnName("SGLOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tplocc)
                .HasColumnName("TPLOCC")
                .HasColumnType("NUMBER");
        });
	}
}
