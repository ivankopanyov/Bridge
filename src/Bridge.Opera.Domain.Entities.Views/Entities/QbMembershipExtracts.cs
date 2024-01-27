namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbMembershipExtracts
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbMembershipExtracts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_MEMBERSHIP_EXTRACTS");

            entity.Property(e => e.ExcludeExtractYn)
                .HasColumnName("EXCLUDE_EXTRACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtractBatchId)
                .HasColumnName("EXTRACT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtractCode)
                .HasColumnName("EXTRACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtractId)
                .HasColumnName("EXTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtractedDate)
                .HasColumnName("EXTRACTED_DATE")
                .HasColumnType("DATE");

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
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
