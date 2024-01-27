namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppIndicatorSub
{
    public string IndicatorId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppIndicatorSub>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("APP_INDICATOR_SUB");

            entity.HasIndex(e => new { e.IndicatorId, e.Resort, e.DeptId })
                .HasName("APP_IND_SUB_UK1")
                .IsUnique();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IndicatorId)
                .IsRequired()
                .HasColumnName("INDICATOR_ID")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
