namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VouchersDetails
{
    public string Resort { get; set; }
    public decimal VoucherNo { get; set; }
    public decimal VoucherId { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime VoucherDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? ValidUntilDate { get; set; }
    public string Validity { get; set; }
    public decimal? MaxVouchersPerCheck { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual VouchersHeader VouchersHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VouchersDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.VoucherNo })
                .HasName("VOUCHERS_DETAILS_PK");

            entity.ToTable("VOUCHERS_DETAILS");

            entity.HasIndex(e => new { e.ResvNameId, e.Resort })
                .HasName("VOUCHERS_DETAILS_RESV_IDX");

            entity.HasIndex(e => new { e.VoucherDate, e.Resort })
                .HasName("VOUCHERS_DETAILS_DATE_IDX");

            entity.HasIndex(e => new { e.VoucherId, e.Resort, e.ResvNameId })
                .HasName("VOUCHERS_DETAILS_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherNo)
                .HasColumnName("VOUCHER_NO")
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

            entity.Property(e => e.MaxVouchersPerCheck)
                .HasColumnName("MAX_VOUCHERS_PER_CHECK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidUntilDate)
                .HasColumnName("VALID_UNTIL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Validity)
                .HasColumnName("VALIDITY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.VoucherDate)
                .HasColumnName("VOUCHER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VoucherId)
                .HasColumnName("VOUCHER_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(VouchersHeader)))
				entity.Ignore(e => e.VouchersHeader);
			else
	            entity.HasOne(d => d.VouchersHeader)
	                .WithMany(p => p.VouchersDetails)
	                .HasForeignKey(d => new { d.VoucherId, d.Resort, d.ResvNameId })
	                .HasConstraintName("VOUCHERS_DETAILS_FK");
        });
	}
}
