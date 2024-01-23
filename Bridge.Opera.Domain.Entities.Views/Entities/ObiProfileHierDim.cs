namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiProfileHierDim
{
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
		modelBuilder.Entity<ObiProfileHierDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PROFILE_HIER_DIM");

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
