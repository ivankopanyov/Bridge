namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsWaitlistProcessed
{
    public decimal QId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime? ProcessedDate { get; set; }
    public string ResvStatus { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsWaitlistProcessed>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_WAITLIST_PROCESSED");

            entity.HasIndex(e => e.ResvNameId)
                .HasName("GDS_WAITLIST_PROCESSED_IND1");

            entity.Property(e => e.ProcessedDate)
                .HasColumnName("PROCESSED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QId)
                .HasColumnName("Q_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
