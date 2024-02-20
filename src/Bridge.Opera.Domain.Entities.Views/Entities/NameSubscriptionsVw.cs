namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameSubscriptionsVw
{
    public decimal? NameId { get; set; }
    public string? DatabaseId { get; set; }
    public string? DatabaseNameId { get; set; }
    public string? InterfaceId { get; set; }
    public string? PmsResort { get; set; }
    public string? ExternalResort { get; set; }
    public string? BeConsumerName { get; set; }
    public string? SystemType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameSubscriptionsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_SUBSCRIPTIONS_VW");

            entity.Property(e => e.BeConsumerName)
                .HasColumnName("BE_CONSUMER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .IsRequired()
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseNameId)
                .HasColumnName("DATABASE_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalResort)
                .IsRequired()
                .HasColumnName("EXTERNAL_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsResort)
                .IsRequired()
                .HasColumnName("PMS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
