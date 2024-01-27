namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipResorts
{
    public string MembershipType { get; set; }
    public string InternalRefValue { get; set; }
    public string ExternalRefType { get; set; }
    public string ExternalRefValue { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ChainCode { get; set; }

    public virtual MembershipTypes MembershipTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipResorts>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.InternalRefValue, e.ExternalRefType })
                .HasName("MEMBERSHIP_RESORTS_PK");

            entity.ToTable("MEMBERSHIP_RESORTS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InternalRefValue)
                .HasColumnName("INTERNAL_REF_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalRefType)
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

			if (!types.Contains(typeof(MembershipTypes)))
				entity.Ignore(e => e.MembershipTypes);
			else
	            entity.HasOne(d => d.MembershipTypes)
	                .WithMany(p => p.MembershipResorts)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_MEMBERSHIP_TYPES_FK");
        });
	}
}
