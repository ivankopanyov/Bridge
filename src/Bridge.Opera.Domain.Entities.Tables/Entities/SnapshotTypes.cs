namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SnapshotTypes
{
    public SnapshotTypes()
    {
        SnapshotSetup = new HashSet<SnapshotSetup>();
    }

    public string? SnapshotType { get; set; }
    public string? Resort { get; set; }
    public string? EditYn { get; set; }
    public string? SnapshotOrigin { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<SnapshotSetup> SnapshotSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SnapshotTypes>(entity =>
        {
            entity.HasKey(e => new { e.SnapshotType, e.Resort })
                .HasName("SNAPTYPE_PK");

            entity.ToTable("SNAPSHOT$TYPES");

            entity.Property(e => e.SnapshotType)
                .HasColumnName("SNAPSHOT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EditYn)
                .HasColumnName("EDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotOrigin)
                .HasColumnName("SNAPSHOT_ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(SnapshotSetup)))
				entity.Ignore(e => e.SnapshotSetup);
		});
	}
}
