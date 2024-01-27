namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipEnrollGroupCodes
{
    public string MemEnrollGroup { get; set; }
    public string EnrollmentCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ChainCode { get; set; }

    public virtual MembershipEnrollGroups MembershipEnrollGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipEnrollGroupCodes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemEnrollGroup, e.EnrollmentCode })
                .HasName("MEM_ENROLL_GROUP_CODES_PK");

            entity.ToTable("MEMBERSHIP_ENROLL_GROUP_CODES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemEnrollGroup)
                .HasColumnName("MEM_ENROLL_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentCode)
                .HasColumnName("ENROLLMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipEnrollGroups)))
				entity.Ignore(e => e.MembershipEnrollGroups);
			else
	            entity.HasOne(d => d.MembershipEnrollGroups)
	                .WithMany(p => p.MembershipEnrollGroupCodes)
	                .HasForeignKey(d => new { d.ChainCode, d.MemEnrollGroup })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_ENROLL_FK1");
        });
	}
}
