namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookActResDetailVw
{
    public string Resort { get; set; }
    public decimal BookedActId { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string GuestName { get; set; }
    public string ActCode { get; set; }
    public string ActDesc { get; set; }
    public string ActStatus { get; set; }
    public decimal BookedResId { get; set; }
    public string ResType { get; set; }
    public string ResId { get; set; }
    public string ResDesc { get; set; }
    public string AddonYn { get; set; }
    public decimal Price { get; set; }
    public decimal Priority010 { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookActResDetailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOK_ACT_RES_DETAIL_VW");

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

            entity.Property(e => e.ActStatus)
                .IsRequired()
                .HasColumnName("ACT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddonYn)
                .HasColumnName("ADDON_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedResId)
                .HasColumnName("BOOKED_RES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority010)
                .HasColumnName("PRIORITY0_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDesc)
                .IsRequired()
                .HasColumnName("RES_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .IsRequired()
                .HasColumnName("RES_TYPE")
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

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
