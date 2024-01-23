namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemberCardFeeAmounts
{
    public string ChainCode { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string FeeCode { get; set; }
    public decimal FeeAmount { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardFeeAmounts>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.MembershipLevel, e.FeeCode })
                .HasName("MEMBER_CARD_FEE_AMOUNTS_PK");

            entity.ToTable("MEMBER_CARD_FEE_AMOUNTS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeeCode)
                .HasColumnName("FEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeeAmount)
                .HasColumnName("FEE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
