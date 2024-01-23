namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidSnapshotSetup
{
    public decimal SnapshotId { get; set; }
    public string Resort { get; set; }
    public string SnapshotDescription { get; set; }
    public string OverrideYn { get; set; }
    public string ActiveYn { get; set; }
    public string SnapshotType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidSnapshotSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SNAPSHOT$SETUP");

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

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotDescription)
                .HasColumnName("SNAPSHOT_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotId)
                .HasColumnName("SNAPSHOT_ID")
                .HasColumnType("NUMBER");

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
        });
	}
}
