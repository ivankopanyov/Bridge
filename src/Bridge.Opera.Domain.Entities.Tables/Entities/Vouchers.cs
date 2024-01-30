namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Vouchers
{
    public decimal? VoucherId { get; set; }
    public string? Resort { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? VoucherAmount { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Validity { get; set; }
    public decimal? MaxVouchersPerCheck { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Vouchers>(entity =>
        {
            entity.HasKey(e => e.VoucherId)
                .HasName("VOUCHERS_PK");

            entity.ToTable("VOUCHERS");

            entity.HasIndex(e => new { e.Resort, e.MembershipType, e.MembershipLevel })
                .HasName("VOUCHERS_MEMBERSHIP_IDX");

            entity.Property(e => e.VoucherId)
                .HasColumnName("VOUCHER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxVouchersPerCheck)
                .HasColumnName("MAX_VOUCHERS_PER_CHECK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Validity)
                .HasColumnName("VALIDITY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.VoucherAmount)
                .HasColumnName("VOUCHER_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
