namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkSections
{
    public string SectionCode { get; set; }
    public string Description { get; set; }
    public string ActiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkSections>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_SECTIONS");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SectionCode)
                .IsRequired()
                .HasColumnName("SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
