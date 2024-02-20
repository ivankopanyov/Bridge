namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidFormDetailsTrn
{
    public string? FormName { get; set; }
    public string? Description { get; set; }
    public DateTime? ExtractedOn { get; set; }
    public string? Application { get; set; }
    public string? ModuleName { get; set; }
    public string? Owner { get; set; }
    public string? FormMenu { get; set; }
    public string? ApplicationFlow { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidFormDetailsTrn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_FORM_DETAILS_TRN");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationFlow)
                .HasColumnName("APPLICATION_FLOW")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtractedOn)
                .HasColumnName("EXTRACTED_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.FormMenu)
                .HasColumnName("FORM_MENU")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
