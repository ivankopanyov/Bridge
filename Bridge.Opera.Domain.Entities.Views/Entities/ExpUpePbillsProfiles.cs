namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpePbillsProfiles
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string FolioId { get; set; }
    public string ProfileType { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpePbillsProfiles>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_PBILLS_PROFILES");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioId)
                .HasColumnName("FOLIO_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
