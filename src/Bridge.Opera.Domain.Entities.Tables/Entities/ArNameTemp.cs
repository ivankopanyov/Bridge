namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArNameTemp
{
    public string? Resort { get; set; }
    public decimal? RowId { get; set; }
    public string? Seeker { get; set; }
    public string? ArNumber { get; set; }
    public string? GuestName { get; set; }
    public decimal? GuestNum { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArNameTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR_NAME_TEMP");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.GuestNum)
                .HasColumnName("GUEST_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Seeker)
                .HasColumnName("SEEKER")
                .HasMaxLength(6)
                .IsUnicode(false);
        });
	}
}
