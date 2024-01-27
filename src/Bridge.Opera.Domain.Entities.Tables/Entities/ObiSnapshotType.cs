namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiSnapshotType
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string WhereCondition { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSnapshotType>(entity =>
        {
            entity.HasKey(e => e.Code)
                .HasName("OBI_SNAPSHOT_TYPE_PK");

            entity.ToTable("OBI_SNAPSHOT_TYPE");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.WhereCondition)
                .HasColumnName("WHERE_CONDITION")
                .IsUnicode(false);
        });
	}
}
