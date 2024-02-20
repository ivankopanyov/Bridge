namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipResortGroupCodes
{
    public string? MemResortGroup { get; set; }
    public string? Resort { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RequiredYn { get; set; }
    public string? ChainCode { get; set; }

    public virtual MembershipResortGroups MembershipResortGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipResortGroupCodes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MemResortGroup, e.Resort })
                .HasName("MEM_RESORT_GROUP_CODES_PK");

            entity.ToTable("MEMBERSHIP_RESORT_GROUP_CODES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemResortGroup)
                .HasColumnName("MEM_RESORT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
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

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipResortGroups)))
				entity.Ignore(e => e.MembershipResortGroups);
			else
	            entity.HasOne(d => d.MembershipResortGroups)
	                .WithMany(p => p.MembershipResortGroupCodes)
	                .HasForeignKey(d => new { d.ChainCode, d.MemResortGroup })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEM_RESORT_GROUP_FK");
        });
	}
}
