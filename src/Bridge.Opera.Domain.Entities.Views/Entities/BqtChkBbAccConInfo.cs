namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkBbAccConInfo
{
    public decimal? BbId { get; set; }
    public string BbDescription { get; set; }
    public string Accname { get; set; }
    public string Accaddress1 { get; set; }
    public string Accaddress2 { get; set; }
    public string Acccity { get; set; }
    public string Acczipcode { get; set; }
    public string Accstate { get; set; }
    public string Acccountry { get; set; }
    public string Conname { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string PaymentMethod { get; set; }
    public string CatManager { get; set; }
    public decimal? ReportId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkBbAccConInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_BB_ACC_CON_INFO");

            entity.Property(e => e.Accaddress1)
                .HasColumnName("ACCADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Accaddress2)
                .HasColumnName("ACCADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Acccity)
                .HasColumnName("ACCCITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Acccountry)
                .HasColumnName("ACCCOUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Accname)
                .HasColumnName("ACCNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Accstate)
                .HasColumnName("ACCSTATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Acczipcode)
                .HasColumnName("ACCZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.BbDescription)
                .HasColumnName("BB_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BbId)
                .HasColumnName("BB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatManager)
                .HasColumnName("CAT_MANAGER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Conname)
                .HasColumnName("CONNAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.FaxNumber)
                .HasColumnName("FAX_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
