namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CompanySubsidiaryView
{
    public decimal? NameId { get; set; }
    public string? DisplayName { get; set; }
    public decimal? MasterCompanyId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CompanySubsidiaryView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COMPANY_SUBSIDIARY_VIEW");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.MasterCompanyId)
                .HasColumnName("MASTER_COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
