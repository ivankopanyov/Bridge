namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationBalances
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ResvStatus { get; set; }
    public decimal? DepLedBalance { get; set; }
    public decimal? PackLedBalance { get; set; }
    public decimal? GuestLedBalance { get; set; }
    public DateTime? LastUpdateDate { get; set; }
    public decimal? CompWinBalance { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationBalances>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_BALANCES_PK");

            entity.ToTable("RESERVATION_BALANCES");

            entity.HasIndex(e => new { e.Resort, e.ResvStatus, e.DepLedBalance, e.PackLedBalance, e.GuestLedBalance, e.CompWinBalance })
                .HasName("RESV_BALANCES_STATUS_INDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompWinBalance)
                .HasColumnName("COMP_WIN_BALANCE")
                .HasColumnType("NUMBER(38,12)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepLedBalance)
                .HasColumnName("DEP_LED_BALANCE")
                .HasColumnType("NUMBER(38,12)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestLedBalance)
                .HasColumnName("GUEST_LED_BALANCE")
                .HasColumnType("NUMBER(38,12)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastUpdateDate)
                .HasColumnName("LAST_UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PackLedBalance)
                .HasColumnName("PACK_LED_BALANCE")
                .HasColumnType("NUMBER(38,12)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithOne(p => p.ReservationBalances)
	                .HasForeignKey<ReservationBalances>(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_BALANCES_FK");
        });
	}
}
