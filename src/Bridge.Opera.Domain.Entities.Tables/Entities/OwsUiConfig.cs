namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsUiConfig
{
    public decimal Id { get; set; }
    public string ConfigurationType { get; set; }
    public string ConfigurationValue { get; set; }
    public string ResortCode { get; set; }
    public string ChannelCode { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsUiConfig>(entity =>
        {
            entity.ToTable("OWS_UI_CONFIG");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChannelCode)
                .IsRequired()
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfigurationType)
                .IsRequired()
                .HasColumnName("CONFIGURATION_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ConfigurationValue)
                .IsRequired()
                .HasColumnName("CONFIGURATION_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResortCode)
                .IsRequired()
                .HasColumnName("RESORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
