namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcAllowedRights
{
    public decimal? Right { get; set; }
    public string? Description { get; set; }
    public string? RightCategory { get; set; }
    public string? TransCode { get; set; }
    public string? ExtendedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcAllowedRights>(entity =>
        {
            entity.HasKey(e => e.Right)
                .HasName("IAT_PK");

            entity.ToTable("IFC_ALLOWED_RIGHTS");

            entity.Property(e => e.Right)
                .HasColumnName("RIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExtendedYn)
                .HasColumnName("EXTENDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RightCategory)
                .HasColumnName("RIGHT_CATEGORY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TransCode)
                .HasColumnName("TRANS_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
