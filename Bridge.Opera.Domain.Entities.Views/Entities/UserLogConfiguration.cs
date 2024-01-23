namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UserLogConfiguration
{
    public string LogUser { get; set; }
    public string LogTime { get; set; }
    public DateTime LogDate { get; set; }
    public string StationId { get; set; }
    public string ActionType { get; set; }
    public string ActionDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserLogConfiguration>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USER_LOG_CONFIGURATION");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LogDate)
                .HasColumnName("LOG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LogTime)
                .HasColumnName("LOG_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.LogUser)
                .HasColumnName("LOG_USER")
                .IsUnicode(false);

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false);
        });
	}
}
