namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScActivityFact
{
    public decimal ActId { get; set; }
    public string Resort { get; set; }
    public decimal? TotalActivities { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScActivityFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_ACTIVITY_FACT");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalActivities)
                .HasColumnName("TOTAL_ACTIVITIES")
                .HasColumnType("NUMBER");
        });
	}
}
