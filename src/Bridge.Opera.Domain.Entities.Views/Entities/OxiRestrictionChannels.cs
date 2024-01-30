namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OxiRestrictionChannels
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? ChannelType { get; set; }
    public string? ExternalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OxiRestrictionChannels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OXI_RESTRICTION_CHANNELS");

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExternalYn)
                .HasColumnName("EXTERNAL_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(240)
                .IsUnicode(false);
        });
	}
}
