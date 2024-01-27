namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ChainCode
{
    public ChainCode()
    {
        AlternateChains = new HashSet<AlternateChains>();
        BroadcastRules = new HashSet<BroadcastRules>();
    }

    public string ChainCode1 { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? ScriptId { get; set; }
    public string LogoFileName { get; set; }
    public decimal? ImgChainId { get; set; }
    public string ShareProfiles { get; set; }
    public string AspYn { get; set; }
    public string HoStreet { get; set; }
    public string HoCity { get; set; }
    public string HoPostCode { get; set; }
    public string HoCountry { get; set; }
    public string HoState { get; set; }
    public string HoTelephone { get; set; }
    public string HoFax { get; set; }
    public string HoEmail { get; set; }
    public string FrequentFlierCardsAcceptYn { get; set; }
    public string BookingConditions { get; set; }
    public string LoyaltyProgram { get; set; }
    public string MarketingText { get; set; }

    public virtual ICollection<AlternateChains> AlternateChains { get; set; }
    public virtual ICollection<BroadcastRules> BroadcastRules { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ChainCode>(entity =>
        {
            entity.HasKey(e => e.ChainCode1)
                .HasName("CHAIN_CODE_PK");

            entity.ToTable("CHAIN_CODE");

            entity.Property(e => e.ChainCode1)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AspYn)
                .HasColumnName("ASP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingConditions)
                .HasColumnName("BOOKING_CONDITIONS")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FrequentFlierCardsAcceptYn)
                .HasColumnName("FREQUENT_FLIER_CARDS_ACCEPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HoCity)
                .HasColumnName("HO_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.HoCountry)
                .HasColumnName("HO_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HoEmail)
                .HasColumnName("HO_EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HoFax)
                .HasColumnName("HO_FAX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.HoPostCode)
                .HasColumnName("HO_POST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HoState)
                .HasColumnName("HO_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.HoStreet)
                .HasColumnName("HO_STREET")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HoTelephone)
                .HasColumnName("HO_TELEPHONE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ImgChainId)
                .HasColumnName("IMG_CHAIN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogoFileName)
                .HasColumnName("LOGO_FILE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyProgram)
                .HasColumnName("LOYALTY_PROGRAM")
                .IsUnicode(false);

            entity.Property(e => e.MarketingText)
                .HasColumnName("MARKETING_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScriptId)
                .HasColumnName("SCRIPT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareProfiles)
                .HasColumnName("SHARE_PROFILES")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(AlternateChains)))
				entity.Ignore(e => e.AlternateChains);

			if (!types.Contains(typeof(BroadcastRules)))
				entity.Ignore(e => e.BroadcastRules);
		});
	}
}
