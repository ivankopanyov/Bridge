namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipAwardProducts
{
    public string Resort { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string Product { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ChainCode { get; set; }

    public virtual MembershipAwards MembershipAwards { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAwardProducts>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEMBERSHIP_AWARD_PRODUCTS");

            entity.HasIndex(e => new { e.Resort, e.Product })
                .HasName("MEMBERSHIP_AWARD_PRODUCTS_IND1");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.AwardType, e.Resort, e.Product })
                .HasName("MEMBERSHIP_AWARD_PRODUCTS_UK1")
                .IsUnique();

            entity.Property(e => e.AwardType)
                .IsRequired()
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipAwards)))
				entity.Ignore(e => e.MembershipAwards);
			else
	            entity.HasOne(d => d.MembershipAwards)
	                .WithMany()
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType, d.AwardType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_AWARD_PRODUCTS_FK");
        });
	}
}
