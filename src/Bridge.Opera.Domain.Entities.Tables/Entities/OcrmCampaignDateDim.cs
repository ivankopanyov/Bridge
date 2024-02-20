namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampaignDateDim
{
    public decimal? DateId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? DateType { get; set; }
    public string? DateCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampaignDateDim>(entity =>
        {
            entity.HasKey(e => e.DateId)
                .HasName("OCRM_CAMPAIGN_DATE_DIM_PK");

            entity.ToTable("OCRM_CAMPAIGN_DATE_DIM");

            entity.HasIndex(e => new { e.DateType, e.DateCode })
                .HasName("OCRM_CAMP_DATE_DIM_UK1")
                .IsUnique();

            entity.Property(e => e.DateId)
                .HasColumnName("DATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateCode)
                .IsRequired()
                .HasColumnName("DATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DateType)
                .IsRequired()
                .HasColumnName("DATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
