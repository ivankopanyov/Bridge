namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DphPmsMap
{
    public string Resort { get; set; }
    public string RecordType { get; set; }
    public string PmsCode { get; set; }
    public string DphCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphPmsMap>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RecordType, e.PmsCode })
                .HasName("DPH_PMS_MAP_PK");

            entity.ToTable("DPH_PMS_MAP");

            entity.HasIndex(e => new { e.Resort, e.RecordType, e.DphCode })
                .HasName("DPH_PMS_MAP_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsCode)
                .HasColumnName("PMS_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DphCode)
                .HasColumnName("DPH_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
