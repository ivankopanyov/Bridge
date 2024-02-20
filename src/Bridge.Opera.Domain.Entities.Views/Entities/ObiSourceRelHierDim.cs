namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiSourceRelHierDim
{
    public string? RelType { get; set; }
    public string? RelToType { get; set; }
    public string? AllId { get; set; }
    public string? AllName { get; set; }
    public decimal? TopId { get; set; }
    public string? TopName { get; set; }
    public decimal? TwoId { get; set; }
    public string? TwoName { get; set; }
    public decimal? ThreeId { get; set; }
    public string? ThreeName { get; set; }
    public decimal? FourId { get; set; }
    public string? FourName { get; set; }
    public decimal? FiveId { get; set; }
    public string? FiveName { get; set; }
    public decimal? SixId { get; set; }
    public string? SixName { get; set; }
    public decimal? SevenId { get; set; }
    public string? SevenName { get; set; }
    public decimal? EightId { get; set; }
    public string? EightName { get; set; }
    public decimal? NineId { get; set; }
    public string? NineName { get; set; }
    public decimal? BottomId { get; set; }
    public string? BottomName { get; set; }
    public decimal? TotalLevels { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSourceRelHierDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SOURCE_REL_HIER_DIM");

            entity.Property(e => e.AllId)
                .HasColumnName("ALL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AllName)
                .HasColumnName("ALL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.BottomId)
                .HasColumnName("BOTTOM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BottomName)
                .HasColumnName("BOTTOM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.EightId)
                .HasColumnName("EIGHT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EightName)
                .HasColumnName("EIGHT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FiveId)
                .HasColumnName("FIVE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FiveName)
                .HasColumnName("FIVE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FourId)
                .HasColumnName("FOUR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FourName)
                .HasColumnName("FOUR_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NineId)
                .HasColumnName("NINE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NineName)
                .HasColumnName("NINE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.RelToType)
                .HasColumnName("REL_TO_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RelType)
                .HasColumnName("REL_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.SevenId)
                .HasColumnName("SEVEN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SevenName)
                .HasColumnName("SEVEN_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SixId)
                .HasColumnName("SIX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SixName)
                .HasColumnName("SIX_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ThreeId)
                .HasColumnName("THREE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ThreeName)
                .HasColumnName("THREE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TopId)
                .HasColumnName("TOP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TopName)
                .HasColumnName("TOP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TotalLevels)
                .HasColumnName("TOTAL_LEVELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TwoId)
                .HasColumnName("TWO_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TwoName)
                .HasColumnName("TWO_NAME")
                .IsUnicode(false);
        });
	}
}
