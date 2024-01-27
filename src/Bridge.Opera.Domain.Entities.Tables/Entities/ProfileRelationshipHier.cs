namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileRelationshipHier
{
    public string RelType { get; set; }
    public string RelToType { get; set; }
    public decimal? TopId { get; set; }
    public decimal? TwoId { get; set; }
    public decimal? ThreeId { get; set; }
    public decimal? FourId { get; set; }
    public decimal? FiveId { get; set; }
    public decimal? SixId { get; set; }
    public decimal? SevenId { get; set; }
    public decimal? EightId { get; set; }
    public decimal? NineId { get; set; }
    public decimal? BottomId { get; set; }
    public string BottomNameType { get; set; }
    public decimal? TotalLevels { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileRelationshipHier>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_RELATIONSHIP_HIER");

            entity.HasIndex(e => e.BottomId)
                .HasName("PROF_REL_HR_BTM_ID_UK")
                .IsUnique();

            entity.HasIndex(e => e.EightId)
                .HasName("PROF_REL_HR_8_IDX");

            entity.HasIndex(e => e.FiveId)
                .HasName("PROF_REL_HR_5_IDX");

            entity.HasIndex(e => e.FourId)
                .HasName("PROF_REL_HR_4_IDX");

            entity.HasIndex(e => e.NineId)
                .HasName("PROF_REL_HR_9_IDX");

            entity.HasIndex(e => e.SevenId)
                .HasName("PROF_REL_HR_7_IDX");

            entity.HasIndex(e => e.SixId)
                .HasName("PROF_REL_HR_6_IDX");

            entity.HasIndex(e => e.ThreeId)
                .HasName("PROF_REL_HR_3_IDX");

            entity.HasIndex(e => e.TopId)
                .HasName("PROF_REL_HR_1_IDX");

            entity.HasIndex(e => e.TwoId)
                .HasName("PROF_REL_HR_2_IDX");

            entity.HasIndex(e => new { e.BottomNameType, e.BottomId })
                .HasName("PROF_REL_HR_BNT_IDX");

            entity.HasIndex(e => new { e.TopId, e.TwoId, e.ThreeId, e.FourId, e.FiveId, e.SixId, e.SevenId, e.EightId, e.NineId, e.BottomId })
                .HasName("PROF_REL_HR_UK")
                .IsUnique();

            entity.Property(e => e.BottomId)
                .HasColumnName("BOTTOM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BottomNameType)
                .HasColumnName("BOTTOM_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EightId)
                .HasColumnName("EIGHT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FiveId)
                .HasColumnName("FIVE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FourId)
                .HasColumnName("FOUR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NineId)
                .HasColumnName("NINE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelToType)
                .HasColumnName("REL_TO_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RelType)
                .HasColumnName("REL_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SevenId)
                .HasColumnName("SEVEN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SixId)
                .HasColumnName("SIX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ThreeId)
                .HasColumnName("THREE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TopId)
                .HasColumnName("TOP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalLevels)
                .HasColumnName("TOTAL_LEVELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TwoId)
                .HasColumnName("TWO_ID")
                .HasColumnType("NUMBER");
        });
	}
}
