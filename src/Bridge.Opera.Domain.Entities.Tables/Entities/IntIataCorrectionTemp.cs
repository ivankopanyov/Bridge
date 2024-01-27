namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntIataCorrectionTemp
{
    public decimal? NameId { get; set; }
    public string Travelagentname { get; set; }
    public string Oldiatanumber { get; set; }
    public string Newiatanumber { get; set; }
    public string Status { get; set; }
    public DateTime? Insertdate { get; set; }
    public string Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntIataCorrectionTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_IATA_CORRECTION_TEMP");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Insertdate)
                .HasColumnName("INSERTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Newiatanumber)
                .HasColumnName("NEWIATANUMBER")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Oldiatanumber)
                .HasColumnName("OLDIATANUMBER")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Travelagentname)
                .HasColumnName("TRAVELAGENTNAME")
                .HasMaxLength(128)
                .IsUnicode(false);
        });
	}
}
