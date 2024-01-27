namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VouchersLog
{
    public decimal VoucherId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal VoucherNo { get; set; }
    public string PrintType { get; set; }
    public decimal PrintUser { get; set; }
    public DateTime PrintDate { get; set; }

    public virtual VouchersDetails VouchersDetails { get; set; }
    public virtual VouchersHeader VouchersHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VouchersLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VOUCHERS_LOG");

            entity.HasIndex(e => new { e.Resort, e.VoucherNo })
                .HasName("VOUCHERS_LOG_FK2I");

            entity.HasIndex(e => new { e.VoucherId, e.Resort, e.ResvNameId })
                .HasName("VOUCHERS_LOG_FK1I");

            entity.Property(e => e.PrintDate)
                .HasColumnName("PRINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintType)
                .IsRequired()
                .HasColumnName("PRINT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintUser)
                .HasColumnName("PRINT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoucherId)
                .HasColumnName("VOUCHER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoucherNo)
                .HasColumnName("VOUCHER_NO")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(VouchersDetails)))
				entity.Ignore(e => e.VouchersDetails);
			else
	            entity.HasOne(d => d.VouchersDetails)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.VoucherNo })
	                .HasConstraintName("VOUCHERS_LOG_FK2");

			if (!types.Contains(typeof(VouchersHeader)))
				entity.Ignore(e => e.VouchersHeader);
			else
	            entity.HasOne(d => d.VouchersHeader)
	                .WithMany()
	                .HasForeignKey(d => new { d.VoucherId, d.Resort, d.ResvNameId })
	                .HasConstraintName("VOUCHERS_LOG_FK1");
        });
	}
}
