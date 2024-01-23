namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsAlerts
{
    public string AlertName { get; set; }
    public string AlertType { get; set; }
    public string AlertMsg { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAlerts>(entity =>
        {
            entity.HasKey(e => e.AlertName)
                .HasName("ORMS_ALERTS_PK");

            entity.ToTable("ORMS_ALERTS");

            entity.Property(e => e.AlertName)
                .HasColumnName("ALERT_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertMsg)
                .IsRequired()
                .HasColumnName("ALERT_MSG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AlertType)
                .IsRequired()
                .HasColumnName("ALERT_TYPE")
                .HasMaxLength(20)
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
        });
	}
}
