namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SnapshotSetup
{
    public decimal SnapshotId { get; set; }
    public string Resort { get; set; }
    public string SnapshotDescription { get; set; }
    public string OverrideYn { get; set; }
    public string ActiveYn { get; set; }
    public string SnapshotType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual SnapshotTypes SnapshotTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SnapshotSetup>(entity =>
        {
            entity.HasKey(e => new { e.SnapshotId, e.Resort })
                .HasName("SNAPSET_PK");

            entity.ToTable("SNAPSHOT$SETUP");

            entity.HasIndex(e => new { e.SnapshotType, e.Resort })
                .HasName("SNAPSET_TYPE_IDX");

            entity.Property(e => e.SnapshotId)
                .HasColumnName("SNAPSHOT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideYn)
                .HasColumnName("OVERRIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotDescription)
                .HasColumnName("SNAPSHOT_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotType)
                .IsRequired()
                .HasColumnName("SNAPSHOT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(SnapshotTypes)))
				entity.Ignore(e => e.SnapshotTypes);
			else
	            entity.HasOne(d => d.SnapshotTypes)
	                .WithMany(p => p.SnapshotSetup)
	                .HasForeignKey(d => new { d.SnapshotType, d.Resort })
	                .HasConstraintName("SNAPSET_SNAPTYPE_FK");
        });
	}
}
