namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MencEvtype1
{
    public decimal? MencId { get; set; }
    public string? EventType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MencEvtype1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MENC_EVTYPE");

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MencId)
                .HasColumnName("MENC_ID")
                .HasColumnType("NUMBER");
        });
	}
}
