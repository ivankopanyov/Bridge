namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oVipLevels
{
    public string O2oMigId { get; set; }
    public string VipLevel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oVipLevels>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("O2O_VIP_LEVELS");

            entity.HasIndex(e => new { e.O2oMigId, e.VipLevel })
                .HasName("O2OVIPIND");

            entity.Property(e => e.O2oMigId)
                .IsRequired()
                .HasColumnName("O2O_MIG_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipLevel)
                .HasColumnName("VIP_LEVEL")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
