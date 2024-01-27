namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameMergeLog
{
    public decimal? NameIdFrom { get; set; }
    public decimal? NameIdTo { get; set; }
    public string ReportedYn { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string NameTypeF { get; set; }
    public string NameTypeT { get; set; }
    public string LastF { get; set; }
    public string LastT { get; set; }
    public string FirstF { get; set; }
    public string FirstT { get; set; }
    public string DisplayNameF { get; set; }
    public string DisplayNameT { get; set; }
    public string XfirstnameF { get; set; }
    public string XfirstnameT { get; set; }
    public string XlastnameF { get; set; }
    public string XlastnameT { get; set; }
    public string AddressTypeF { get; set; }
    public string AddressTypeT { get; set; }
    public string AddressF { get; set; }
    public string AddressT { get; set; }
    public string DatabaseId { get; set; }
    public string DatabaseNameIdF { get; set; }
    public string DatabaseNameIdT { get; set; }
    public string NameCodeF { get; set; }
    public string NameCodeT { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameMergeLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NAME_MERGE_LOG");

            entity.HasIndex(e => e.NameIdTo)
                .HasName("NAME_MERGE_LOG_IND1");

            entity.HasIndex(e => new { e.NameIdFrom, e.NameIdTo, e.ReportedYn, e.TransactionDate })
                .HasName("IND_NAME_ID_FROM_TO");

            entity.Property(e => e.AddressF)
                .HasColumnName("ADDRESS_F")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.AddressT)
                .HasColumnName("ADDRESS_T")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.AddressTypeF)
                .HasColumnName("ADDRESS_TYPE_F")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AddressTypeT)
                .HasColumnName("ADDRESS_TYPE_T")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseNameIdF)
                .HasColumnName("DATABASE_NAME_ID_F")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseNameIdT)
                .HasColumnName("DATABASE_NAME_ID_T")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayNameF)
                .HasColumnName("DISPLAY_NAME_F")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DisplayNameT)
                .HasColumnName("DISPLAY_NAME_T")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.FirstF)
                .HasColumnName("FIRST_F")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FirstT)
                .HasColumnName("FIRST_T")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastF)
                .HasColumnName("LAST_F")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LastT)
                .HasColumnName("LAST_T")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameCodeF)
                .HasColumnName("NAME_CODE_F")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameCodeT)
                .HasColumnName("NAME_CODE_T")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameIdFrom)
                .HasColumnName("NAME_ID_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameIdTo)
                .HasColumnName("NAME_ID_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTypeF)
                .HasColumnName("NAME_TYPE_F")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTypeT)
                .HasColumnName("NAME_TYPE_T")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReportedYn)
                .HasColumnName("REPORTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.XfirstnameF)
                .HasColumnName("XFIRSTNAME_F")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.XfirstnameT)
                .HasColumnName("XFIRSTNAME_T")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.XlastnameF)
                .HasColumnName("XLASTNAME_F")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.XlastnameT)
                .HasColumnName("XLASTNAME_T")
                .HasMaxLength(240)
                .IsUnicode(false);
        });
	}
}
