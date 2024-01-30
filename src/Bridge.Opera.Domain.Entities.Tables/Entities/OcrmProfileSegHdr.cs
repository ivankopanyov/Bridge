namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmProfileSegHdr
{
    public OcrmProfileSegHdr()
    {
        OcrmCampaigns = new HashSet<OcrmCampaigns>();
        OcrmProfileSegBatches = new HashSet<OcrmProfileSegBatches>();
    }

    public decimal? SegId { get; set; }
    public string? SegCode { get; set; }
    public string? SegDesc { get; set; }
    public string? SegSourceType { get; set; }
    public string? Resort { get; set; }
    public string? JobNameId { get; set; }
    public string? ActionText { get; set; }
    public string? RepeatInterval { get; set; }
    public decimal? TimesExec { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? DynCodeId { get; set; }

    public virtual ICollection<OcrmCampaigns> OcrmCampaigns { get; set; }
    public virtual ICollection<OcrmProfileSegBatches> OcrmProfileSegBatches { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmProfileSegHdr>(entity =>
        {
            entity.HasKey(e => e.SegId)
                .HasName("ONR_PK");

            entity.ToTable("OCRM_PROFILE_SEG_HDR");

            entity.HasIndex(e => new { e.SegCode, e.SegSourceType, e.Resort })
                .HasName("ONR_UK")
                .IsUnique();

            entity.Property(e => e.SegId)
                .HasColumnName("SEG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionText)
                .HasColumnName("ACTION_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.DynCodeId)
                .HasColumnName("DYN_CODE_ID")
                .HasMaxLength(40)
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

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegCode)
                .IsRequired()
                .HasColumnName("SEG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegDesc)
                .HasColumnName("SEG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SegSourceType)
                .IsRequired()
                .HasColumnName("SEG_SOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimesExec)
                .HasColumnName("TIMES_EXEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(OcrmCampaigns)))
				entity.Ignore(e => e.OcrmCampaigns);

			if (!types.Contains(typeof(OcrmProfileSegBatches)))
				entity.Ignore(e => e.OcrmProfileSegBatches);
		});
	}
}
