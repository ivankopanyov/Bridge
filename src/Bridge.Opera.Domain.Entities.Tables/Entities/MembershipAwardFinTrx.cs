namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipAwardFinTrx
{
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string ChainCode { get; set; }
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual MembershipAwards MembershipAwards { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAwardFinTrx>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.AwardType, e.Resort })
                .HasName("MAX_PK");

            entity.ToTable("MEMBERSHIP_AWARD_FIN_TRX");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
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
	                .WithMany(p => p.MembershipAwardFinTrx)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType, d.AwardType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAX_MAD_FK");
        });
	}
}
