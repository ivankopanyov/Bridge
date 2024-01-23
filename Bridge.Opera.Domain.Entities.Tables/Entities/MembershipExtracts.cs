namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipExtracts
{
    public decimal ExtractId { get; set; }
    public decimal MembershipId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string ExtractCode { get; set; }
    public DateTime? ExtractedDate { get; set; }
    public decimal? ExtractBatchId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string ExcludeExtractYn { get; set; }
    public decimal? TscReportId { get; set; }

    public virtual Memberships Membership { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipExtracts>(entity =>
        {
            entity.HasKey(e => e.ExtractId)
                .HasName("MEMBERSHIP_EXTRACTS_PK");

            entity.ToTable("MEMBERSHIP_EXTRACTS");

            entity.HasIndex(e => e.MembershipId)
                .HasName("MEMBERSHIP_EXTRACTS_IND1");

            entity.Property(e => e.ExtractId)
                .HasColumnName("EXTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExcludeExtractYn)
                .HasColumnName("EXCLUDE_EXTRACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtractBatchId)
                .HasColumnName("EXTRACT_BATCH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExtractCode)
                .HasColumnName("EXTRACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExtractedDate)
                .HasColumnName("EXTRACTED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TscReportId)
                .HasColumnName("TSC_REPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Memberships)))
				entity.Ignore(e => e.Membership);
			else
	            entity.HasOne(d => d.Membership)
	                .WithMany(p => p.MembershipExtracts)
	                .HasForeignKey(d => d.MembershipId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_EXTRACTS_FK");
        });
	}
}
