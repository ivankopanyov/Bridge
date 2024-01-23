namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempV5iBlockdata
{
    public string Hotelcode { get; set; }
    public decimal Groupid { get; set; }
    public DateTime? Blockdate { get; set; }
    public decimal? Forecast { get; set; }
    public string Rmtypecode { get; set; }
    public decimal? Block { get; set; }
    public decimal? Pickup { get; set; }
    public decimal? Sglocc { get; set; }
    public decimal? Dblocc { get; set; }
    public decimal? Tplocc { get; set; }
    public decimal? Quadocc { get; set; }
    public decimal? Extraocc { get; set; }
    public decimal? Sglrte { get; set; }
    public decimal? Dblrte { get; set; }
    public decimal? Tplrte { get; set; }
    public decimal? Quadrte { get; set; }
    public decimal? Extrarte { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempV5iBlockdata>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_V5I_BLOCKDATA");

            entity.Property(e => e.Block)
                .HasColumnName("BLOCK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Blockdate)
                .HasColumnName("BLOCKDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Dblocc)
                .HasColumnName("DBLOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dblrte)
                .HasColumnName("DBLRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Extraocc)
                .HasColumnName("EXTRAOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Extrarte)
                .HasColumnName("EXTRARTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Forecast)
                .HasColumnName("FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Groupid)
                .HasColumnName("GROUPID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Hotelcode)
                .IsRequired()
                .HasColumnName("HOTELCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Pickup)
                .HasColumnName("PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quadocc)
                .HasColumnName("QUADOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quadrte)
                .HasColumnName("QUADRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rmtypecode)
                .HasColumnName("RMTYPECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sglocc)
                .HasColumnName("SGLOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sglrte)
                .HasColumnName("SGLRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tplocc)
                .HasColumnName("TPLOCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tplrte)
                .HasColumnName("TPLRTE")
                .HasColumnType("NUMBER");
        });
	}
}
