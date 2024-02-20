namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcRightsView
{
    public string? Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal? Right { get; set; }
    public string? Category { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcRightsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_RIGHTS_VIEW");

            entity.Property(e => e.Category)
                .HasColumnName("CATEGORY")
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

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Right)
                .HasColumnName("RIGHT")
                .HasColumnType("NUMBER");
        });
	}
}
