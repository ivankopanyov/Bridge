namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConBlkContact
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ParentNameId { get; set; }
    public string? ProfileType { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NameCode { get; set; }
    public string? AccountType { get; set; }
    public string? RelationshipType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConBlkContact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_BLK_CONTACT");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentNameId)
                .HasColumnName("PARENT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
