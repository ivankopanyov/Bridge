namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScBiRevenueGroups
{
    public string ChainCode { get; set; }
    public string RevGroupType { get; set; }
    public string RevGroupCode { get; set; }
    public string RevTypes { get; set; }
    public string CodeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScBiRevenueGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RevGroupType, e.RevGroupCode })
                .HasName("SC_BI_REVENUE_GROUPS_PK");

            entity.ToTable("SC_BI_REVENUE_GROUPS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroupType)
                .HasColumnName("REV_GROUP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroupCode)
                .HasColumnName("REV_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeDesc)
                .IsRequired()
                .HasColumnName("CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RevTypes)
                .HasColumnName("REV_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
