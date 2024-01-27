namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GrsumFolioDetail
{
    public decimal ResvNameId { get; set; }
    public decimal NameId { get; set; }
    public decimal? FolioNo { get; set; }
    public string FolioView { get; set; }
    public string FolioStyle { get; set; }
    public string Room { get; set; }
    public decimal? FromId { get; set; }
    public decimal? TrxCode { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GrsumFolioDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GRSUM_FOLIO_DETAIL");

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .IsUnicode(false);

            entity.Property(e => e.FromId)
                .HasColumnName("FROM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasColumnType("NUMBER");
        });
	}
}
