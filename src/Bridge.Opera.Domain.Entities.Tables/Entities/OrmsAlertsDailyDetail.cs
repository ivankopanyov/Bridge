namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAlertsDailyDetail
{
    public string? Resort { get; set; }
    public DateTime? TriggerDate { get; set; }
    public string? AlertName { get; set; }
    public string? AlertKey { get; set; }
    public string? AlertMsg { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual OrmsAlertsDaily OrmsAlertsDaily { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAlertsDailyDetail>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AlertName, e.TriggerDate, e.AlertKey })
                .HasName("ORMS_ALERTS_DAILY_DETAILS_PK");

            entity.ToTable("ORMS_ALERTS_DAILY_DETAIL");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertName)
                .HasColumnName("ALERT_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TriggerDate)
                .HasColumnName("TRIGGER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AlertKey)
                .HasColumnName("ALERT_KEY")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.AlertMsg)
                .HasColumnName("ALERT_MSG")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsAlertsDaily)))
				entity.Ignore(e => e.OrmsAlertsDaily);
			else
	            entity.HasOne(d => d.OrmsAlertsDaily)
	                .WithMany(p => p.OrmsAlertsDailyDetail)
	                .HasForeignKey(d => new { d.Resort, d.AlertName, d.TriggerDate })
	                .HasConstraintName("ORMS_ALERTS_DAILY_DETAIL_FK");
        });
	}
}
