namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StandardTextsView
{
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public decimal? TextId { get; set; }
    public string? Description { get; set; }
    public string? CanDeleteYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StandardTextsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STANDARD_TEXTS_VIEW");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
