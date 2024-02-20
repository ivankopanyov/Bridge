namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PostIt
{
    public string? Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? FolioNo { get; set; }
    public string? TrxCode { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public string? DisplayYn { get; set; }
    public decimal? ArticleId { get; set; }
    public string? Description { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? Amount { get; set; }
    public string? FtSubtype { get; set; }
    public decimal? PostitNo { get; set; }
    public decimal? TrxNoAddedBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PostIt>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("POST_IT");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArticleId)
                .HasColumnName("ARTICLE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2001)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostitNo)
                .HasColumnName("POSTIT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");
        });
	}
}
