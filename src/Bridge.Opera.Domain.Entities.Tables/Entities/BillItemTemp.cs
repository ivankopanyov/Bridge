namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BillItemTemp
{
    public string? Resort { get; set; }
    public decimal? RowId { get; set; }
    public string? Seeker { get; set; }
    public string? PostedRoomNo { get; set; }
    public string? ResvNameId { get; set; }
    public decimal? Window { get; set; }
    public string? PostingDate { get; set; }
    public string? PostingTime { get; set; }
    public string? DeptCode { get; set; }
    public string? Text { get; set; }
    public string? Supplement { get; set; }
    public decimal? Amount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BillItemTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BILL_ITEM_TEMP");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptCode)
                .HasColumnName("DEPT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PostedRoomNo)
                .HasColumnName("POSTED_ROOM_NO")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PostingTime)
                .HasColumnName("POSTING_TIME")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Seeker)
                .HasColumnName("SEEKER")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Supplement)
                .HasColumnName("SUPPLEMENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Window)
                .HasColumnName("WINDOW")
                .HasColumnType("NUMBER");
        });
	}
}
