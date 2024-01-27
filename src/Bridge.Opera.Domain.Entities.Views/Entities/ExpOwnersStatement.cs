namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpOwnersStatement
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public string ExportType { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public decimal? NameId { get; set; }
    public string OwnerName { get; set; }
    public string AccountNo { get; set; }
    public string Units { get; set; }
    public decimal? OpnBalance { get; set; }
    public decimal? OwnerShare { get; set; }
    public decimal? Fees { get; set; }
    public decimal? OtherActivity { get; set; }
    public decimal? Payment { get; set; }
    public decimal? Balance { get; set; }
    public string OwnerAddress1 { get; set; }
    public string OwnerAddress2 { get; set; }
    public string OwnerAddress3 { get; set; }
    public string OwnerAddress4 { get; set; }
    public string OwnerCity { get; set; }
    public string OwnerZip { get; set; }
    public string OwnerCountry { get; set; }
    public string OwnerState { get; set; }
    public string OwnerPhone { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpOwnersStatement>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_OWNERS_STATEMENT");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Fees)
                .HasColumnName("FEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OpnBalance)
                .HasColumnName("OPN_BALANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OtherActivity)
                .HasColumnName("OTHER_ACTIVITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerAddress1)
                .HasColumnName("OWNER_ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerAddress2)
                .HasColumnName("OWNER_ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerAddress3)
                .HasColumnName("OWNER_ADDRESS3")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerAddress4)
                .HasColumnName("OWNER_ADDRESS4")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerCity)
                .HasColumnName("OWNER_CITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerCountry)
                .HasColumnName("OWNER_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerName)
                .HasColumnName("OWNER_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerPhone)
                .HasColumnName("OWNER_PHONE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerShare)
                .HasColumnName("OWNER_SHARE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerState)
                .HasColumnName("OWNER_STATE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerZip)
                .HasColumnName("OWNER_ZIP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Payment)
                .HasColumnName("PAYMENT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Units)
                .HasColumnName("UNITS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
