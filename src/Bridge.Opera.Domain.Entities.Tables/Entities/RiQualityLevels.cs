namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RiQualityLevels
{
    public RiQualityLevels()
    {
        RoomInspectionDetails = new HashSet<RoomInspectionDetails>();
    }

    public string Resort { get; set; }
    public decimal RiQualityLevelSeq { get; set; }
    public string RiQualityLevelDescription { get; set; }
    public decimal RiQualityLevelPoints { get; set; }

    public virtual ICollection<RoomInspectionDetails> RoomInspectionDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiQualityLevels>(entity =>
        {
            entity.HasKey(e => new { e.RiQualityLevelSeq, e.Resort })
                .HasName("RQ_PK");

            entity.ToTable("RI_QUALITY_LEVELS");

            entity.Property(e => e.RiQualityLevelSeq)
                .HasColumnName("RI_QUALITY_LEVEL_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiQualityLevelDescription)
                .IsRequired()
                .HasColumnName("RI_QUALITY_LEVEL_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RiQualityLevelPoints)
                .HasColumnName("RI_QUALITY_LEVEL_POINTS")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RoomInspectionDetails)))
				entity.Ignore(e => e.RoomInspectionDetails);
		});
	}
}
