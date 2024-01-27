namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsHostsView
{
    public string GdsHost { get; set; }
    public string Name { get; set; }
    public string ChannelType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ActivateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsHostsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_HOSTS_VIEW");

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
