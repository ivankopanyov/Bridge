namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StandardTexts
{
    public string? DeptId { get; set; }
    public decimal? TextId { get; set; }
    public string? Description { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StandardTexts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STANDARD_TEXTS");

            entity.HasIndex(e => new { e.Resort, e.DeptId, e.TextId, e.Description, e.CanDeleteYn })
                .HasName("STANDARD_TEXTS_UK")
                .IsUnique();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TextId)
                .HasColumnName("TEXT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
