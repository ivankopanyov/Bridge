namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcRights
{
    public string? Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public decimal? Right { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? ActiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcRights>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.IfcCtrlId, e.Right })
                .HasName("IRT_PK");

            entity.ToTable("IFC_RIGHTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Right)
                .HasColumnName("RIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
