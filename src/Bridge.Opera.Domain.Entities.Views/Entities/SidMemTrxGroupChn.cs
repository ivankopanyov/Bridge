namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMemTrxGroupChn
{
    public string? TrxGroupCode { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string? IncludeExclude { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMemTrxGroupChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MEM_TRX_GROUP_CHN");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
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

            entity.Property(e => e.TrxGroupCode)
                .IsRequired()
                .HasColumnName("TRX_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
