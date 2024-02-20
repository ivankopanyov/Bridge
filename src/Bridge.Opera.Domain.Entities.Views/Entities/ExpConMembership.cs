namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConMembership
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? MembershipCardNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConMembership>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_MEMBERSHIP");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
