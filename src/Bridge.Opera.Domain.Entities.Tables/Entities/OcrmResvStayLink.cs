namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmResvStayLink
{
    public OcrmResvStayLink()
    {
        OcrmResvStayOfferLink = new HashSet<OcrmResvStayOfferLink>();
    }

    public decimal? ResvLinkId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? PmsResvNameId { get; set; }
    public string? PosCode { get; set; }
    public decimal? LegNo { get; set; }
    public decimal? OcrmProfileId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? DataSource { get; set; }

    public virtual ICollection<OcrmResvStayOfferLink> OcrmResvStayOfferLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmResvStayLink>(entity =>
        {
            entity.HasKey(e => e.ResvLinkId)
                .HasName("OCRM_RESV_STAY_LINK_PK");

            entity.ToTable("OCRM_RESV_STAY_LINK");

            entity.HasIndex(e => e.OcrmProfileId)
                .HasName("OCRM_RESV_STAY_LINK__IDX01");

            entity.HasIndex(e => new { e.ResvNameId, e.Resort, e.LegNo })
                .HasName("OCRM_RESV_STAY_LINK__UK01")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.PmsResvNameId, e.PosCode, e.LegNo })
                .HasName("OCRM_RESV_STAY_LINK__UK02")
                .IsUnique();

            entity.Property(e => e.ResvLinkId)
                .HasColumnName("RESV_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LegNo)
                .HasColumnName("LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsResvNameId)
                .HasColumnName("PMS_RESV_NAME_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PosCode)
                .HasColumnName("POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(OcrmResvStayOfferLink)))
				entity.Ignore(e => e.OcrmResvStayOfferLink);
		});
	}
}
