namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MergeHeader
{
    public decimal? MergeId { get; set; }
    public string? Description { get; set; }
    public string? SystemYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MergeHeader>(entity =>
        {
            entity.HasKey(e => e.MergeId)
                .HasName("MGH_PK");

            entity.ToTable("MERGE$HEADER");

            entity.Property(e => e.MergeId)
                .HasColumnName("MERGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SystemYn)
                .HasColumnName("SYSTEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");
        });
	}
}
