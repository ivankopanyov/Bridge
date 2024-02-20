namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemTrxGroup
{
    public string? TrxGroupCode { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string? IncludeExclude { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemTrxGroup>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.TrxGroupCode })
                .HasName("MEM_TRX_GROUP_PK");

            entity.ToTable("MEM_TRX_GROUP");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxGroupCode)
                .HasColumnName("TRX_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IncludeExclude)
                .IsRequired()
                .HasColumnName("INCLUDE_EXCLUDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
