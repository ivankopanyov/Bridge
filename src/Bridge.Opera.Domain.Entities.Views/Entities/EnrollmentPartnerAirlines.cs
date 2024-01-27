namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EnrollmentPartnerAirlines
{
    public string Resort { get; set; }
    public string ExtSystem { get; set; }
    public string MembershipType { get; set; }
    public string Description { get; set; }
    public string MembershipClass { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EnrollmentPartnerAirlines>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ENROLLMENT_PARTNER_AIRLINES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtSystem)
                .IsRequired()
                .HasColumnName("EXT_SYSTEM")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MembershipClass)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
