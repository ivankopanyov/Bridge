namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAlertsDaily
{
    public OrmsAlertsDaily()
    {
        OrmsAlertsDailyDetail = new HashSet<OrmsAlertsDailyDetail>();
    }

    public string? Resort { get; set; }
    public string? AlertName { get; set; }
    public DateTime? TriggerDate { get; set; }
    public string? Status { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<OrmsAlertsDailyDetail> OrmsAlertsDailyDetail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAlertsDaily>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AlertName, e.TriggerDate })
                .HasName("ORMS_ALERT_DAILY_PK");

            entity.ToTable("ORMS_ALERTS_DAILY");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(OrmsAlertsDailyDetail)))
				entity.Ignore(e => e.OrmsAlertsDailyDetail);
		});
	}
}
