namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Preferences
{
    public Preferences()
    {
        ReservationFeatures = new HashSet<ReservationFeatures>();
        ResortAmenityLevelLinks = new HashSet<ResortAmenityLevelLinks>();
        RoomPreferences = new HashSet<RoomPreferences>();
    }

    public string? Preference { get; set; }
    public string? PreferenceType { get; set; }
    public string? Resort { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Description { get; set; }
    public string? CrsPreferenceYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? PreferenceSeqId { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? ChainCode { get; set; }
    public string? SendDeleteRequestYn { get; set; }
    public string? CorporateYn { get; set; }
    public string? OwsAllowedYn { get; set; }
    public string? AmenityYn { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<ReservationFeatures> ReservationFeatures { get; set; }
    public virtual ICollection<ResortAmenityLevelLinks> ResortAmenityLevelLinks { get; set; }
    public virtual ICollection<RoomPreferences> RoomPreferences { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Preferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PREFERENCES$");

            entity.HasIndex(e => e.PreferenceSeqId)
                .HasName("PREFERENCES_UK1")
                .IsUnique();

            entity.HasIndex(e => e.Resort)
                .HasName("PREFERENCE_RESORT_FKI");

            entity.HasIndex(e => new { e.ChainCode, e.PreferenceType, e.Preference, e.Resort })
                .HasName("PREFERENCE_V_UK")
                .IsUnique();

            entity.Property(e => e.AmenityYn)
                .HasColumnName("AMENITY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CorporateYn)
                .HasColumnName("CORPORATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CrsPreferenceYn)
                .HasColumnName("CRS_PREFERENCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwsAllowedYn)
                .HasColumnName("OWS_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Preference)
                .IsRequired()
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceSeqId)
                .IsRequired()
                .HasColumnName("PREFERENCE_SEQ_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SendDeleteRequestYn)
                .HasColumnName("SEND_DELETE_REQUEST_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Resort)
	                .HasConstraintName("PREFERENCE_RESORT_FK");
        
			if (!types.Contains(typeof(ReservationFeatures)))
				entity.Ignore(e => e.ReservationFeatures);

			if (!types.Contains(typeof(ResortAmenityLevelLinks)))
				entity.Ignore(e => e.ResortAmenityLevelLinks);

			if (!types.Contains(typeof(RoomPreferences)))
				entity.Ignore(e => e.RoomPreferences);
		});
	}
}
