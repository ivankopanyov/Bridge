namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AsciiFformat
{
    public string Resort { get; set; }
    public string FormatType { get; set; }
    public string CorporateId { get; set; }
    public string HotelId { get; set; }
    public decimal? TaxId { get; set; }
    public string TaxType { get; set; }
    public string ChainName { get; set; }
    public string ReportingCurrency { get; set; }
    public string RemittingCurrency { get; set; }
    public string ReportingMethod { get; set; }
    public string TransmissionId { get; set; }
    public string ExportFile { get; set; }
    public DateTime? LastExportDate { get; set; }
    public decimal? LastExportFileNo { get; set; }
    public string CntryIsoInd { get; set; }
    public string CompressedFileExt { get; set; }
    public string CntryTaxingAuthority { get; set; }
    public string Company { get; set; }
    public string TransLettAddr1 { get; set; }
    public string TransLettAddr2 { get; set; }
    public string TransLettAddr4 { get; set; }
    public string TransLettAddr5 { get; set; }
    public string TransLettTel { get; set; }
    public string TransLettFax { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string TransLettAddr3 { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AsciiFformat>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.FormatType })
                .HasName("ASCII_FFORMAT_PK");

            entity.ToTable("ASCII_FFORMAT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormatType)
                .HasColumnName("FORMAT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainName)
                .HasColumnName("CHAIN_NAME")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CntryIsoInd)
                .HasColumnName("CNTRY_ISO_IND")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CntryTaxingAuthority)
                .HasColumnName("CNTRY_TAXING_AUTHORITY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompressedFileExt)
                .HasColumnName("COMPRESSED_FILE_EXT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CorporateId)
                .HasColumnName("CORPORATE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportFile)
                .HasColumnName("EXPORT_FILE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelId)
                .HasColumnName("HOTEL_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastExportDate)
                .HasColumnName("LAST_EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastExportFileNo)
                .HasColumnName("LAST_EXPORT_FILE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RemittingCurrency)
                .HasColumnName("REMITTING_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReportingCurrency)
                .HasColumnName("REPORTING_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReportingMethod)
                .HasColumnName("REPORTING_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettAddr1)
                .HasColumnName("TRANS_LETT_ADDR1")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettAddr2)
                .HasColumnName("TRANS_LETT_ADDR2")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettAddr3)
                .HasColumnName("TRANS_LETT_ADDR3")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettAddr4)
                .HasColumnName("TRANS_LETT_ADDR4")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettAddr5)
                .HasColumnName("TRANS_LETT_ADDR5")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettFax)
                .HasColumnName("TRANS_LETT_FAX")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransLettTel)
                .HasColumnName("TRANS_LETT_TEL")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransmissionId)
                .HasColumnName("TRANSMISSION_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.AsciiFformat)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ASCII_FFORMAT_RESORT_FK");
        });
	}
}
