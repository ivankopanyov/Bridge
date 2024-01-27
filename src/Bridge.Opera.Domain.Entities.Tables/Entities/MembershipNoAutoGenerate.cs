namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipNoAutoGenerate
{
    public string SeqType { get; set; }
    public string MembershipType { get; set; }
    public decimal FromSeqNo { get; set; }
    public decimal ToSeqNo { get; set; }
    public decimal LastSeqNo { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string CardPrefix { get; set; }
    public string ChainCode { get; set; }
    public string RandomNoFormat { get; set; }

    public virtual MembershipTypes MembershipTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipNoAutoGenerate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.SeqType, e.MembershipType })
                .HasName("MEMBERSHIP_NO_AUTO_GEN_PK");

            entity.ToTable("MEMBERSHIP_NO_AUTO_GENERATE");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType })
                .HasName("MEMBERSHIP_NO_AUTO_GEN_IDX1");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeqType)
                .HasColumnName("SEQ_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CardPrefix)
                .HasColumnName("CARD_PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromSeqNo)
                .HasColumnName("FROM_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastSeqNo)
                .HasColumnName("LAST_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RandomNoFormat)
                .HasColumnName("RANDOM_NO_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToSeqNo)
                .HasColumnName("TO_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipTypes)))
				entity.Ignore(e => e.MembershipTypes);
			else
	            entity.HasOne(d => d.MembershipTypes)
	                .WithMany(p => p.MembershipNoAutoGenerate)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_NO_AUTO_GEN_FK1");
        });
	}
}
