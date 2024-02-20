namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookedResActVw
{
    public string? Resort { get; set; }
    public decimal? BookedResId { get; set; }
    public decimal? BookedActId { get; set; }
    public decimal? BookedElId { get; set; }
    public string? ResType { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public string? ResId { get; set; }
    public string? ActCode { get; set; }
    public string? ActElCode { get; set; }
    public string? CustomerYn { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? GuestName { get; set; }
    public string? OutletCode { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? ActStatus { get; set; }
    public string? ActElStatus { get; set; }
    public decimal? DurationDays { get; set; }
    public decimal? Duration { get; set; }
    public decimal? NoOfPeople { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedResActVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOKED_RES_ACT_VW");

            entity.Property(e => e.ActCode)
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActElCode)
                .HasColumnName("ACT_EL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActElStatus)
                .HasColumnName("ACT_EL_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActStatus)
                .HasColumnName("ACT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedElId)
                .HasColumnName("BOOKED_EL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedResId)
                .HasColumnName("BOOKED_RES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomerYn)
                .HasColumnName("CUSTOMER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DurationDays)
                .HasColumnName("DURATION_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfPeople)
                .HasColumnName("NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .HasColumnName("RES_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
