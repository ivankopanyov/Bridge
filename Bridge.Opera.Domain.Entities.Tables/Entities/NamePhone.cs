namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NamePhone
{
    public NamePhone()
    {
        ArAccountEmail = new HashSet<ArAccount>();
        ArAccountFaxNavigation = new HashSet<ArAccount>();
        ArAccountPhoneNavigation = new HashSet<ArAccount>();
        ReservationCommPref = new HashSet<ReservationCommPref>();
    }

    public decimal PhoneId { get; set; }
    public decimal NameId { get; set; }
    public string PhoneType { get; set; }
    public string PhoneRole { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal? AddressId { get; set; }
    public string PrimaryYn { get; set; }
    public decimal? DisplaySeq { get; set; }
    public byte? LaptopChange { get; set; }
    public string IndexPhone { get; set; }
    public string Extension { get; set; }
    public string EmailFormat { get; set; }
    public string ShareEmailYn { get; set; }
    public string DefaultConfirmationYn { get; set; }
    public string EmailLanguage { get; set; }
    public string MobileAudioKeyYn { get; set; }
    public decimal? CountryDialingCode { get; set; }
    public string ValidYn { get; set; }
    public string PhoneCountryCode { get; set; }

    public virtual Name Name { get; set; }
    public virtual ICollection<ArAccount> ArAccountEmail { get; set; }
    public virtual ICollection<ArAccount> ArAccountFaxNavigation { get; set; }
    public virtual ICollection<ArAccount> ArAccountPhoneNavigation { get; set; }
    public virtual ICollection<ReservationCommPref> ReservationCommPref { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NamePhone>(entity =>
        {
            entity.HasKey(e => e.PhoneId)
                .HasName("NAME_PHONE_PK");

            entity.ToTable("NAME_PHONE");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("NAME_PHONE_IND2");

            entity.HasIndex(e => e.IndexPhone)
                .HasName("NAME_PHONE_IND1");

            entity.HasIndex(e => new { e.NameId, e.PhoneId, e.PrimaryYn })
                .HasName("NAME_PHONE_UNIQUE")
                .IsUnique();

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CountryDialingCode)
                .HasColumnName("COUNTRY_DIALING_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultConfirmationYn)
                .HasColumnName("DEFAULT_CONFIRMATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailFormat)
                .HasColumnName("EMAIL_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailLanguage)
                .HasColumnName("EMAIL_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Extension)
                .HasColumnName("EXTENSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IndexPhone)
                .HasColumnName("INDEX_PHONE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.MobileAudioKeyYn)
                .HasColumnName("MOBILE_AUDIO_KEY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneCountryCode)
                .HasColumnName("PHONE_COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneRole)
                .IsRequired()
                .HasColumnName("PHONE_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'BUSINESS'");

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShareEmailYn)
                .HasColumnName("SHARE_EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NamePhone)
	                .HasForeignKey(d => d.NameId)
	                .HasConstraintName("NAME_ID_FK4");
        
			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccountEmail);

			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccountFaxNavigation);

			if (!types.Contains(typeof(ArAccount)))
				entity.Ignore(e => e.ArAccountPhoneNavigation);

			if (!types.Contains(typeof(ReservationCommPref)))
				entity.Ignore(e => e.ReservationCommPref);
		});
	}
}
