namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemEventPkg
{
    public GemEventPkg()
    {
        GemEventPkgRevenue = new HashSet<GemEventPkgRevenue>();
    }

    public decimal PkgId { get; set; }
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public string PkgCode { get; set; }
    public string PkgName { get; set; }
    public decimal? Duration { get; set; }
    public decimal? TotalRevenue { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? ExpectedAttendees { get; set; }
    public decimal? GuaranteedAttendees { get; set; }
    public decimal? ActualAttendees { get; set; }
    public string AttendeesChangeableYn { get; set; }
    public string PriceCode { get; set; }
    public string PriceCodeDesc { get; set; }
    public decimal? PkgPriceId { get; set; }
    public string PkgResort { get; set; }
    public decimal? GroupId { get; set; }

    public virtual ICollection<GemEventPkgRevenue> GemEventPkgRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemEventPkg>(entity =>
        {
            entity.HasKey(e => new { e.PkgId, e.Resort, e.BookId })
                .HasName("GEP_PK");

            entity.ToTable("GEM$EVENT_PKG");

            entity.HasIndex(e => e.PkgId)
                .HasName("GEP_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.BookId, e.PkgId })
                .HasName("GEP_RES_BK_PKG")
                .IsUnique();

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesChangeableYn)
                .HasColumnName("ATTENDEES_CHANGEABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedAttendees)
                .HasColumnName("EXPECTED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedAttendees)
                .HasColumnName("GUARANTEED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PkgPriceId)
                .HasColumnName("PKG_PRICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgResort)
                .HasColumnName("PKG_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriceCodeDesc)
                .HasColumnName("PRICE_CODE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(GemEventPkgRevenue)))
				entity.Ignore(e => e.GemEventPkgRevenue);
		});
	}
}
