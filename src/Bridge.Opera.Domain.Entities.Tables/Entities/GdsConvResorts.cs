namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvResorts
{
    public GdsConvResorts()
    {
        GdsConvRateCodes = new HashSet<GdsConvRateCodes>();
    }

    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string ChainCode { get; set; }
    public string GdsResort { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ActivateYn { get; set; }
    public string CityCode { get; set; }
    public string ResortChainId { get; set; }
    public decimal? MaxRoomLimit { get; set; }
    public string AdsAriEnable { get; set; }
    public string PrevailingYn { get; set; }
    public string ArUrl { get; set; }
    public string BrUrl { get; set; }
    public string InitialUpload { get; set; }
    public decimal? BookingLimit { get; set; }
    public string DefaultRateCode { get; set; }
    public decimal? LowRevThreshold1 { get; set; }
    public decimal? HighRevThreshold1 { get; set; }
    public string DefaultRateCode1 { get; set; }
    public decimal? LowRevThreshold2 { get; set; }
    public decimal? HighRevThreshold2 { get; set; }
    public string DefaultRateCode2 { get; set; }
    public decimal? LowRevThreshold3 { get; set; }
    public decimal? HighRevThreshold3 { get; set; }
    public string DefaultRateCode3 { get; set; }
    public string AddOnLicense { get; set; }

    public virtual GdsHosts GdsHostNavigation { get; set; }
    public virtual ICollection<GdsConvRateCodes> GdsConvRateCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvResorts>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.Resort })
                .HasName("GDS_CONV_RESORTS_PK");

            entity.ToTable("GDS_CONV_RESORTS");

            entity.HasIndex(e => e.Resort)
                .HasName("GDS_CONV_RESORTS_IND1");

            entity.HasIndex(e => new { e.GdsHost, e.GdsResort })
                .HasName("GDS_CONV_RESORTS_IND2");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.AddOnLicense)
                .HasColumnName("ADD_ON_LICENSE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdsAriEnable)
                .HasColumnName("ADS_ARI_ENABLE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArUrl)
                .HasColumnName("AR_URL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookingLimit)
                .HasColumnName("BOOKING_LIMIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BrUrl)
                .HasColumnName("BR_URL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CityCode)
                .HasColumnName("CITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRateCode)
                .HasColumnName("DEFAULT_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRateCode1)
                .HasColumnName("DEFAULT_RATE_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRateCode2)
                .HasColumnName("DEFAULT_RATE_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultRateCode3)
                .HasColumnName("DEFAULT_RATE_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsResort)
                .IsRequired()
                .HasColumnName("GDS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HighRevThreshold1)
                .HasColumnName("HIGH_REV_THRESHOLD1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HighRevThreshold2)
                .HasColumnName("HIGH_REV_THRESHOLD2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HighRevThreshold3)
                .HasColumnName("HIGH_REV_THRESHOLD3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InitialUpload)
                .HasColumnName("INITIAL_UPLOAD")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LowRevThreshold1)
                .HasColumnName("LOW_REV_THRESHOLD1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LowRevThreshold2)
                .HasColumnName("LOW_REV_THRESHOLD2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LowRevThreshold3)
                .HasColumnName("LOW_REV_THRESHOLD3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxRoomLimit)
                .HasColumnName("MAX_ROOM_LIMIT")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrevailingYn)
                .HasColumnName("PREVAILING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortChainId)
                .HasColumnName("RESORT_CHAIN_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsHosts)))
				entity.Ignore(e => e.GdsHostNavigation);
			else
	            entity.HasOne(d => d.GdsHostNavigation)
	                .WithMany(p => p.GdsConvResorts)
	                .HasForeignKey(d => d.GdsHost)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_CONV_RESO_GDS_HOSTS_FK");
        
			if (!types.Contains(typeof(GdsConvRateCodes)))
				entity.Ignore(e => e.GdsConvRateCodes);
		});
	}
}
