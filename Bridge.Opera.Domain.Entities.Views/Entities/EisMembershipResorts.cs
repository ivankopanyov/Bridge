namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisMembershipResorts
{
    public string MembershipType { get; set; }
    public string InternalRefValue { get; set; }
    public string ExternalRefType { get; set; }
    public string ExternalRefValue { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisMembershipResorts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_MEMBERSHIP_RESORTS");

            entity.Property(e => e.ExternalRefType)
                .IsRequired()
                .HasColumnName("EXTERNAL_REF_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalRefValue)
                .IsRequired()
                .HasColumnName("EXTERNAL_REF_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InternalRefValue)
                .IsRequired()
                .HasColumnName("INTERNAL_REF_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
