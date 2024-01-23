namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FloorPlans
{
    public string Resort { get; set; }
    public string Floor { get; set; }
    public string ItemName { get; set; }
    public decimal XPos { get; set; }
    public decimal YPos { get; set; }
    public string Name { get; set; }
    public string DisplayedYn { get; set; }
    public string NavigableYn { get; set; }
    public string DefaultValue { get; set; }
    public decimal? TabOrder { get; set; }
    public decimal? LineHeight { get; set; }
    public decimal? LineWidth { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FloorPlans>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemName, e.Floor })
                .HasName("FLOOR_PLANS_PK");

            entity.ToTable("FLOOR_PLANS$");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayedYn)
                .IsRequired()
                .HasColumnName("DISPLAYED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.LineHeight)
                .HasColumnName("LINE_HEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LineWidth)
                .HasColumnName("LINE_WIDTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NavigableYn)
                .IsRequired()
                .HasColumnName("NAVIGABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.TabOrder)
                .HasColumnName("TAB_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XPos)
                .HasColumnName("X_POS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YPos)
                .HasColumnName("Y_POS")
                .HasColumnType("NUMBER");
        });
	}
}
