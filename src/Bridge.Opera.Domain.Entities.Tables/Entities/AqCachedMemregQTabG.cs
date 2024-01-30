namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AqCachedMemregQTabG
{
    public Guid Msgid { get; set; }
    public decimal? Subscriber { get; set; }
    public string? Name { get; set; }
    public decimal? Address { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqCachedMemregQTabG>(entity =>
        {
            entity.HasKey(e => new { e.Msgid, e.Subscriber, e.Name, e.Address })
                .HasName("SYS_IOT_TOP_165791");

            entity.ToTable("AQ$_CACHED$_MEMREG_Q_TAB_G");

            entity.Property(e => e.Msgid).HasColumnName("MSGID");

            entity.Property(e => e.Subscriber)
                .HasColumnName("SUBSCRIBER#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS#")
                .HasColumnType("NUMBER");
        });
	}
}
