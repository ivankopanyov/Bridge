namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MicEvtype1
{
    public decimal MicId { get; set; }
    public string EventType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MicEvtype1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MIC_EVTYPE");

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MicId)
                .HasColumnName("MIC_ID")
                .HasColumnType("NUMBER");
        });
	}
}
