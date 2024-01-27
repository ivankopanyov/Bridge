namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestOverviewLayout
{
    public string Resort { get; set; }
    public string StayHistoryField1 { get; set; }
    public string StayHistoryField2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestOverviewLayout>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("GUEST_OVERVIEW_LAYOUT_PK");

            entity.ToTable("GUEST_OVERVIEW_LAYOUT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayHistoryField1)
                .HasColumnName("STAY_HISTORY_FIELD1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StayHistoryField2)
                .HasColumnName("STAY_HISTORY_FIELD2")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
