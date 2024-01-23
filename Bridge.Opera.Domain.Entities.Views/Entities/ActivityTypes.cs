namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ActivityTypes
{
    public string ActivityType { get; set; }
    public string Description { get; set; }
    public string ActivityClass { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? MinutesBeforeAlert { get; set; }
    public string AlertOnCreationYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActivityTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACTIVITY_TYPES");

            entity.Property(e => e.ActivityClass)
                .HasColumnName("ACTIVITY_CLASS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActivityType)
                .IsRequired()
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertOnCreationYn)
                .HasColumnName("ALERT_ON_CREATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MinutesBeforeAlert)
                .HasColumnName("MINUTES_BEFORE_ALERT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
