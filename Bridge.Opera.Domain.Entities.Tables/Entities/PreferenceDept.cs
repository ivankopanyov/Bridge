namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PreferenceDept
{
    public decimal PreferenceSeqId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PreferenceDept>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PREFERENCE_DEPT");

            entity.HasIndex(e => new { e.PreferenceSeqId, e.Resort, e.DeptId })
                .HasName("PREFERENCE_DEPT_UK");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceSeqId)
                .HasColumnName("PREFERENCE_SEQ_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
