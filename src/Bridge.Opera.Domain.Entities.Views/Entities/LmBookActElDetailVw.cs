namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookActElDetailVw
{
    public string? Resort { get; set; }
    public decimal? BookedActId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? GuestName { get; set; }
    public string? ActCode { get; set; }
    public string? ActDesc { get; set; }
    public string? ActStatus { get; set; }
    public decimal? BookedElId { get; set; }
    public string? ActElCode { get; set; }
    public string? ActElDesc { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? ActElStatus { get; set; }
    public string? OutletCode { get; set; }
    public string? CustomerYn { get; set; }
    public string? InternalYn { get; set; }
    public decimal? NoOfPeople { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookActElDetailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOK_ACT_EL_DETAIL_VW");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActDesc)
                .IsRequired()
                .HasColumnName("ACT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActElCode)
                .IsRequired()
                .HasColumnName("ACT_EL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActElDesc)
                .IsRequired()
                .HasColumnName("ACT_EL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActElStatus)
                .IsRequired()
                .HasColumnName("ACT_EL_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActStatus)
                .IsRequired()
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

            entity.Property(e => e.CustomerYn)
                .IsRequired()
                .HasColumnName("CUSTOMER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InternalYn)
                .IsRequired()
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfPeople)
                .HasColumnName("NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
