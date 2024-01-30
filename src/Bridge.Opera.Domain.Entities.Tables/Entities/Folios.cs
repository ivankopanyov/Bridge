namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Folios
{
    public decimal? ResvDeptRno { get; set; }
    public string? FolioStatus { get; set; }
    public decimal? CurrExchRno { get; set; }
    public decimal? CheckExchRno { get; set; }
    public decimal? FolioNo { get; set; }
    public string? State { get; set; }
    public decimal? NumberReprints { get; set; }
    public DateTime? Timestamp { get; set; }
    public decimal? CashierId { get; set; }
    public string? FolioStyle { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Resort { get; set; }
    public string? FltType { get; set; }
    public string? TemplatePath { get; set; }
    public string? PhoneDetails { get; set; }
    public string? ProcessIdent { get; set; }
    public decimal? NoOfPersons { get; set; }
    public DateTime? FoDate { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? RevisionNo { get; set; }
    public decimal? FolioSeqNo { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public string? FolioType { get; set; }
    public string? PostitYn { get; set; }
    public decimal? PostitNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Folios>(entity =>
        {
            entity.HasKey(e => e.FolioSeqNo)
                .HasName("FOLIOS_PK");

            entity.ToTable("FOLIOS");

            entity.HasIndex(e => e.BillGenerationDate)
                .HasName("FOLIO_BILL_GEN_DATE");

            entity.HasIndex(e => e.BillNo)
                .HasName("FOLIOS_BILL_IND");

            entity.HasIndex(e => e.PostitNo)
                .HasName("FOLIOS_POSTIT_NO_IND");

            entity.HasIndex(e => new { e.FolioNo, e.BillNo })
                .HasName("FOLIOS_FOL_BILL_I");

            entity.HasIndex(e => new { e.NameId, e.FolioView })
                .HasName("FOLIO_NAME_VW");

            entity.HasIndex(e => new { e.Resort, e.FoDate })
                .HasName("FOLIO_DATE_IDX");

            entity.HasIndex(e => new { e.ResvNameId, e.FolioView })
                .HasName("FOLIO_RESV_VW");

            entity.HasIndex(e => new { e.Resort, e.FltType, e.Timestamp })
                .HasName("FOLIO_TIMESTAMP_IDX");

            entity.Property(e => e.FolioSeqNo)
                .HasColumnName("FOLIO_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckExchRno)
                .HasColumnName("CHECK_EXCH_RNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrExchRno)
                .HasColumnName("CURR_EXCH_RNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FltType)
                .HasColumnName("FLT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoDate)
                .HasColumnName("FO_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioStatus)
                .HasColumnName("FOLIO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioStyle)
                .IsRequired()
                .HasColumnName("FOLIO_STYLE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfPersons)
                .HasColumnName("NO_OF_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberReprints)
                .HasColumnName("NUMBER_REPRINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneDetails)
                .HasColumnName("PHONE_DETAILS")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PostitNo)
                .HasColumnName("POSTIT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostitYn)
                .HasColumnName("POSTIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessIdent)
                .HasColumnName("PROCESS_IDENT")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvDeptRno)
                .HasColumnName("RESV_DEPT_RNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNo)
                .HasColumnName("REVISION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .IsRequired()
                .HasColumnName("STATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplatePath)
                .HasColumnName("TEMPLATE_PATH")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Timestamp)
                .HasColumnName("TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
