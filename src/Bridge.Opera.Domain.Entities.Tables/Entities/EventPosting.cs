namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventPosting
{
    public decimal? EvPostId { get; set; }
    public decimal? EventId { get; set; }
    public string? RevenueType { get; set; }
    public decimal? RevenueIncluded { get; set; }
    public decimal? RevenueExtra { get; set; }
    public string? TrxCodeIncluded { get; set; }
    public string? TrxCodeExtra { get; set; }
    public string? ChequeNumber { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? BookId { get; set; }
    public string? Resort { get; set; }
    public decimal? PostedToIncl { get; set; }
    public decimal? PostedToExtra { get; set; }
    public DateTime? PostedDateIncl { get; set; }
    public DateTime? PostedDateExtra { get; set; }
    public string? PostedByResort { get; set; }
    public decimal? PostedById { get; set; }
    public string? PostedBy { get; set; }
    public decimal? TrxNoIncl { get; set; }
    public decimal? TrxNoExtra { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? SvcTrxNoIncl { get; set; }
    public decimal? SvcTrxNoExtra { get; set; }
    public string? SvcCalculationRuleIncluded { get; set; }
    public string? SvcTrxCodeIncluded { get; set; }
    public decimal? SvcPctIncluded { get; set; }
    public string? SvcCalculationRuleExtra { get; set; }
    public string? SvcTrxCodeExtra { get; set; }
    public decimal? SvcPctExtra { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? Units { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventPosting>(entity =>
        {
            entity.HasKey(e => e.EvPostId)
                .HasName("EVP_PK");

            entity.ToTable("EVENT$POSTING");

            entity.HasIndex(e => e.TrxNoExtra)
                .HasName("EVP_TRX_EXCL_IDX")
                .IsUnique();

            entity.HasIndex(e => e.TrxNoIncl)
                .HasName("EVP_TRX_INCL_IDX")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId, e.RevenueType, e.PostedBy, e.PostedById })
                .HasName("EVP_IDX");

            entity.Property(e => e.EvPostId)
                .HasColumnName("EV_POST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedBy)
                .HasColumnName("POSTED_BY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostedById)
                .HasColumnName("POSTED_BY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedByResort)
                .HasColumnName("POSTED_BY_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostedDateExtra)
                .HasColumnName("POSTED_DATE_EXTRA")
                .HasColumnType("DATE");

            entity.Property(e => e.PostedDateIncl)
                .HasColumnName("POSTED_DATE_INCL")
                .HasColumnType("DATE");

            entity.Property(e => e.PostedToExtra)
                .HasColumnName("POSTED_TO_EXTRA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedToIncl)
                .HasColumnName("POSTED_TO_INCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueExtra)
                .HasColumnName("REVENUE_EXTRA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueIncluded)
                .HasColumnName("REVENUE_INCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SvcCalculationRuleExtra)
                .HasColumnName("SVC_CALCULATION_RULE_EXTRA")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SvcCalculationRuleIncluded)
                .HasColumnName("SVC_CALCULATION_RULE_INCLUDED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SvcPctExtra)
                .HasColumnName("SVC_PCT_EXTRA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SvcPctIncluded)
                .HasColumnName("SVC_PCT_INCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SvcTrxCodeExtra)
                .HasColumnName("SVC_TRX_CODE_EXTRA")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SvcTrxCodeIncluded)
                .HasColumnName("SVC_TRX_CODE_INCLUDED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SvcTrxNoExtra)
                .HasColumnName("SVC_TRX_NO_EXTRA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SvcTrxNoIncl)
                .HasColumnName("SVC_TRX_NO_INCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCodeExtra)
                .HasColumnName("TRX_CODE_EXTRA")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeIncluded)
                .HasColumnName("TRX_CODE_INCLUDED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNoExtra)
                .HasColumnName("TRX_NO_EXTRA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoIncl)
                .HasColumnName("TRX_NO_INCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Units)
                .HasColumnName("UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
