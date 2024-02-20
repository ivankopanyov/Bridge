namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpModes
{
    public string? ModeValue { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Description { get; set; }
    public string? UsedInForm { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpModes>(entity =>
        {
            entity.HasKey(e => new { e.ModeValue, e.UsedInForm })
                .HasName("SCREEN_MOD_PK");

            entity.ToTable("SP_MODES");

            entity.Property(e => e.ModeValue)
                .HasColumnName("MODE_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UsedInForm)
                .HasColumnName("USED_IN_FORM")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
