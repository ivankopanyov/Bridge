namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CreditCardReaderDevices
{
    public CreditCardReaderDevices()
    {
        PmsTerminals = new HashSet<PmsTerminals>();
    }

    public decimal? CCReaderDeviceId { get; set; }
    public string? Description { get; set; }
    public string? Track2Seperator { get; set; }
    public string? ExpyDateStartCharacter { get; set; }
    public string? NameSeperator { get; set; }
    public string? EndOfTrackSeperator { get; set; }
    public string? ChainCode { get; set; }
    public string? SecureDeviceYn { get; set; }
    public string? AdditionalInfoSeparator { get; set; }
    public decimal? KsnFieldPosition { get; set; }
    public decimal? Et1FieldPosition { get; set; }
    public decimal? Et2FieldPosition { get; set; }
    public string? EncryptionFormatCode { get; set; }
    public string? SoftwareId { get; set; }
    public string? AdditionalInfoEndSeparator { get; set; }
    public string? AdditionalInfoFormatType { get; set; }

    public virtual ICollection<PmsTerminals> PmsTerminals { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CreditCardReaderDevices>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.CCReaderDeviceId })
                .HasName("CCRD_PK");

            entity.ToTable("CREDIT_CARD_READER_DEVICES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CCReaderDeviceId)
                .HasColumnName("C_C_READER_DEVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdditionalInfoEndSeparator)
                .HasColumnName("ADDITIONAL_INFO_END_SEPARATOR")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.AdditionalInfoFormatType)
                .HasColumnName("ADDITIONAL_INFO_FORMAT_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AdditionalInfoSeparator)
                .HasColumnName("ADDITIONAL_INFO_SEPARATOR")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EncryptionFormatCode)
                .HasColumnName("ENCRYPTION_FORMAT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndOfTrackSeperator)
                .HasColumnName("END_OF_TRACK_SEPERATOR")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Et1FieldPosition)
                .HasColumnName("ET1_FIELD_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Et2FieldPosition)
                .HasColumnName("ET2_FIELD_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpyDateStartCharacter)
                .HasColumnName("EXPY_DATE_START_CHARACTER")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.KsnFieldPosition)
                .HasColumnName("KSN_FIELD_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameSeperator)
                .HasColumnName("NAME_SEPERATOR")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.SecureDeviceYn)
                .HasColumnName("SECURE_DEVICE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SoftwareId)
                .HasColumnName("SOFTWARE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Track2Seperator)
                .HasColumnName("TRACK_2_SEPERATOR")
                .HasMaxLength(3)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(PmsTerminals)))
				entity.Ignore(e => e.PmsTerminals);
		});
	}
}
