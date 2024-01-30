namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oMembershipTypes
{
    public string? O2oMigId { get; set; }
    public string? MembershipType { get; set; }
    public string? UsageType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oMembershipTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("O2O_MEMBERSHIP_TYPES");

            entity.HasIndex(e => e.O2oMigId)
                .HasName("O2O_MEM_TYPE_IND");

            entity.HasIndex(e => new { e.O2oMigId, e.MembershipType })
                .HasName("O2O_MEMBERSHIP_TYPES_IDX1");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.O2oMigId)
                .HasColumnName("O2O_MIG_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsageType)
                .HasColumnName("USAGE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
