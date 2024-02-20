namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MitEvtype1
{
    public string? Resort { get; set; }
    public decimal? MitId { get; set; }
    public string? EventType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MitEvtype1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MIT_EVTYPE");

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
