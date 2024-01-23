namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepManagerSetup
{
    public string Resort { get; set; }
    public string ItemName { get; set; }
    public decimal ModuleId { get; set; }
    public decimal DefaultPrintSequence { get; set; }
    public decimal? PrintSequence { get; set; }
    public string PrintLineAfterYn { get; set; }
    public decimal? BlankRowsAfter { get; set; }
    public string ActiveYn { get; set; }
    public string AmountFormatType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string RepMgrCorrespondingColumn { get; set; }
    public string UdfItemYn { get; set; }
    public string UdfType { get; set; }
    public string UdfDescription { get; set; }
    public string UdfInclDayUseYn { get; set; }
    public string UdfInclNoShowYn { get; set; }
    public string UdfExclHouseYn { get; set; }
    public string UdfExclCompYn { get; set; }
    public string UdfExclOooYn { get; set; }
    public string UdfExclOosYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepManagerSetup>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemName, e.ModuleId })
                .HasName("REP_MANAGER_SETUP_PK");

            entity.ToTable("REP_MANAGER_SETUP");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AmountFormatType)
                .HasColumnName("AMOUNT_FORMAT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BlankRowsAfter)
                .HasColumnName("BLANK_ROWS_AFTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultPrintSequence)
                .HasColumnName("DEFAULT_PRINT_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintLineAfterYn)
                .HasColumnName("PRINT_LINE_AFTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintSequence)
                .HasColumnName("PRINT_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepMgrCorrespondingColumn)
                .HasColumnName("REP_MGR_CORRESPONDING_COLUMN")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UdfDescription)
                .HasColumnName("UDF_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UdfExclCompYn)
                .HasColumnName("UDF_EXCL_COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfExclHouseYn)
                .HasColumnName("UDF_EXCL_HOUSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfExclOooYn)
                .HasColumnName("UDF_EXCL_OOO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfExclOosYn)
                .HasColumnName("UDF_EXCL_OOS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfInclDayUseYn)
                .HasColumnName("UDF_INCL_DAY_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfInclNoShowYn)
                .HasColumnName("UDF_INCL_NO_SHOW_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfItemYn)
                .HasColumnName("UDF_ITEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UdfType)
                .HasColumnName("UDF_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
