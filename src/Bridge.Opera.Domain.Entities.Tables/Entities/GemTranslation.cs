namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemTranslation
{
    public GemTranslation()
    {
        GemMenu = new HashSet<GemMenu>();
        GemMenuitem = new HashSet<GemMenuitem>();
        RoomRates = new HashSet<RoomRates>();
        RoomSetup = new HashSet<RoomSetup>();
    }

    public decimal? CodeId { get; set; }
    public string? CodeType { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? DisplayYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ChainCode { get; set; }
    public string? WebBookingYn { get; set; }
    public decimal? WebSetup { get; set; }
    public decimal? WebSetdown { get; set; }
    public string? FulldayYn { get; set; }

    public virtual ICollection<GemMenu> GemMenu { get; set; }
    public virtual ICollection<GemMenuitem> GemMenuitem { get; set; }
    public virtual ICollection<RoomRates> RoomRates { get; set; }
    public virtual ICollection<RoomSetup> RoomSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemTranslation>(entity =>
        {
            entity.HasKey(e => e.CodeId)
                .HasName("GT_PK");

            entity.ToTable("GEM$TRANSLATION");

            entity.HasIndex(e => new { e.ChainCode, e.CodeType, e.Code })
                .HasName("GT_UK")
                .IsUnique();

            entity.Property(e => e.CodeId)
                .HasColumnName("CODE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CodeType)
                .IsRequired()
                .HasColumnName("CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.FulldayYn)
                .HasColumnName("FULLDAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WebSetdown)
                .HasColumnName("WEB_SETDOWN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebSetup)
                .HasColumnName("WEB_SETUP")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(GemMenu)))
				entity.Ignore(e => e.GemMenu);

			if (!types.Contains(typeof(GemMenuitem)))
				entity.Ignore(e => e.GemMenuitem);

			if (!types.Contains(typeof(RoomRates)))
				entity.Ignore(e => e.RoomRates);

			if (!types.Contains(typeof(RoomSetup)))
				entity.Ignore(e => e.RoomSetup);
		});
	}
}
