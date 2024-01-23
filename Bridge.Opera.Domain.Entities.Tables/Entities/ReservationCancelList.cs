namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationCancelList
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime? CancelAfter { get; set; }
    public string DepositRequiredYn { get; set; }
    public decimal? CcPendingDays { get; set; }
    public string Status { get; set; }
    public string ProcessingMsg { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationCancelList>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_CANCEL_LIST_PK");

            entity.ToTable("RESERVATION_CANCEL_LIST");

            entity.HasIndex(e => new { e.Resort, e.Status, e.CancelAfter })
                .HasName("RESERVATION_CANCEL_LIST_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelAfter)
                .HasColumnName("CANCEL_AFTER")
                .HasColumnType("DATE");

            entity.Property(e => e.CcPendingDays)
                .HasColumnName("CC_PENDING_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositRequiredYn)
                .HasColumnName("DEPOSIT_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'CANCEL'");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithOne(p => p.ReservationCancelList)
	                .HasForeignKey<ReservationCancelList>(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RCT_RNE_FK");
        });
	}
}
