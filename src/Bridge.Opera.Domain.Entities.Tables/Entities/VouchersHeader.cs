namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VouchersHeader
{
    public VouchersHeader()
    {
        VouchersDetails = new HashSet<VouchersDetails>();
    }

    public decimal? VoucherId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public decimal? VoucherAmount { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

    public virtual ReservationName Res { get; set; }
    public virtual ICollection<VouchersDetails> VouchersDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VouchersHeader>(entity =>
        {
            entity.HasKey(e => new { e.VoucherId, e.Resort, e.ResvNameId })
                .HasName("VOUCHERS_HEADER_PK");

            entity.ToTable("VOUCHERS_HEADER");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("VOUCHERS_HEADER_FKI");

            entity.Property(e => e.VoucherId)
                .HasColumnName("VOUCHER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherAmount)
                .HasColumnName("VOUCHER_AMOUNT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.VouchersHeader)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("VOUCHERS_HEADER_FK");
        
			if (!types.Contains(typeof(VouchersDetails)))
				entity.Ignore(e => e.VouchersDetails);
		});
	}
}
