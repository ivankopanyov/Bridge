namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaTsTabIdx
{
    public string? TablespaceName { get; set; }
    public string? TableName { get; set; }
    public string? IndexName { get; set; }
    public decimal? Count1 { get; set; }
    public decimal? GrpId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaTsTabIdx>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_TS_TAB_IDX");

            entity.Property(e => e.Count1)
                .HasColumnName("COUNT(1)")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpId)
                .HasColumnName("GRP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndexName)
                .HasColumnName("INDEX_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TablespaceName)
                .HasColumnName("TABLESPACE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
