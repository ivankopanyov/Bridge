namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcFrmView
{
    public string? Resort { get; set; }
    public string? Id { get; set; }
    public string? ExpTable { get; set; }
    public string? Expression { get; set; }
    public string? DbfLogo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcFrmView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_FRM_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.ExpTable)
                .HasColumnName("EXP_TABLE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Expression)
                .HasColumnName("EXPRESSION")
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
