namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WebproposalInfo
{
    public string? Resort { get; set; }
    public string? AppServerUrl { get; set; }
    public string? CallerType { get; set; }
    public decimal? CallerId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WebproposalInfo>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CallerType, e.CallerId })
                .HasName("WPINFO_PK");

            entity.ToTable("WEBPROPOSAL_INFO");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CallerType)
                .HasColumnName("CALLER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CallerId)
                .HasColumnName("CALLER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppServerUrl)
                .HasColumnName("APP_SERVER_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
