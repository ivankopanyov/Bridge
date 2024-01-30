namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EInvWsLog
{
    public string? Resort { get; set; }
    public decimal? FolioTaxSeqNo { get; set; }
    public DateTime? RequestDate { get; set; }
    public string? Description { get; set; }
    public string? ErrorText { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EInvWsLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("E_INV_WS_LOG");

            entity.HasIndex(e => new { e.Resort, e.FolioTaxSeqNo, e.RequestDate })
                .HasName("E_INV_WS_LOG_RES_SEQ_DATE_IND");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.FolioTaxSeqNo)
                .HasColumnName("FOLIO_TAX_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
