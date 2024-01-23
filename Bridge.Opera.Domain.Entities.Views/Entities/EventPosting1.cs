namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventPosting1
{
    public decimal BookId { get; set; }
    public string ChequeNumber { get; set; }
    public decimal EventId { get; set; }
    public decimal EvPostId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string PostedBy { get; set; }
    public decimal? PostedById { get; set; }
    public string PostedByResort { get; set; }
    public DateTime? PostedDateExtra { get; set; }
    public DateTime? PostedDateIncl { get; set; }
    public string Resort { get; set; }
    public decimal? RevenueExtra { get; set; }
    public decimal? RevenueIncluded { get; set; }
    public string RevenueType { get; set; }
    public string TrxCodeExtra { get; set; }
    public string TrxCodeIncluded { get; set; }
    public decimal? TrxNoExtra { get; set; }
    public decimal? TrxNoIncl { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? PostedToIncl { get; set; }
    public decimal? PostedToExtra { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? Units { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventPosting1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_POSTING");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(250)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EvPostId)
                .HasColumnName("EV_POST_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedBy)
                .HasColumnName("POSTED_BY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedById)
                .HasColumnName("POSTED_BY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedByResort)
                .HasColumnName("POSTED_BY_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedDateExtra)
                .HasColumnName("POSTED_DATE_EXTRA")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedDateIncl)
                .HasColumnName("POSTED_DATE_INCL")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedToExtra)
                .HasColumnName("POSTED_TO_EXTRA")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostedToIncl)
                .HasColumnName("POSTED_TO_INCL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueExtra)
                .HasColumnName("REVENUE_EXTRA")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueIncluded)
                .HasColumnName("REVENUE_INCLUDED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCodeExtra)
                .HasColumnName("TRX_CODE_EXTRA")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCodeIncluded)
                .HasColumnName("TRX_CODE_INCLUDED")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxNoExtra)
                .HasColumnName("TRX_NO_EXTRA")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxNoIncl)
                .HasColumnName("TRX_NO_INCL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Units)
                .HasColumnName("UNITS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
