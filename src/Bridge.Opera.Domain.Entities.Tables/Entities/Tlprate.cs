namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tlprate
{
    public string? Hotelcode { get; set; }
    public string? Groupid { get; set; }
    public string? Workstatid { get; set; }
    public string? Rmtypecode { get; set; }
    public DateTime? Blockdate { get; set; }
    public decimal? Sglrte { get; set; }
    public decimal? Dblrte { get; set; }
    public decimal? Tplrte { get; set; }
    public decimal? Quadrte { get; set; }
    public decimal? Extrarte { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tlprate>(entity =>
        {
            entity.HasKey(e => new { e.Hotelcode, e.Groupid, e.Workstatid, e.Blockdate, e.Rmtypecode })
                .HasName("TLPR_PK");

            entity.ToTable("TLPRATE");

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

            entity.Property(e => e.Dblrte)
                .HasColumnName("DBLRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Extrarte)
                .HasColumnName("EXTRARTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quadrte)
                .HasColumnName("QUADRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sglrte)
                .HasColumnName("SGLRTE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tplrte)
                .HasColumnName("TPLRTE")
                .HasColumnType("NUMBER");
        });
	}
}
