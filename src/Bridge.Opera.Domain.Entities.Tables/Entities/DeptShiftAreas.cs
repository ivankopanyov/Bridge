namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DeptShiftAreas
{
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? ShiftId { get; set; }
    public string? AreaId { get; set; }
    public string? AreaType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeptShiftAreas>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeptId, e.ShiftId, e.AreaId, e.AreaType })
                .HasName("DS_PK");

            entity.ToTable("DEPT_SHIFT_AREAS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShiftId)
                .HasColumnName("SHIFT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AreaId)
                .HasColumnName("AREA_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AreaType)
                .HasColumnName("AREA_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
