namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConContactOfComp
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ContactNameId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? RowCount { get; set; }
    public string CompanyName { get; set; }
    public string ContactNameType { get; set; }
    public string CompanyNameType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConContactOfComp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_CONTACT_OF_COMP");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyNameType)
                .HasColumnName("COMPANY_NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactNameType)
                .HasColumnName("CONTACT_NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowCount)
                .HasColumnName("ROW_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
