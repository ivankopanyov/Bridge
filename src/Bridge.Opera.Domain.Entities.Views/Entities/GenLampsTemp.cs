namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GenLampsTemp
{
    public decimal? LayoutId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? GroupOrderBy { get; set; }
    public string? LampId { get; set; }
    public string? ItemName { get; set; }
    public string? Description { get; set; }
    public string? LampInfo { get; set; }
    public string? LampType { get; set; }
    public string? ActionBehavior { get; set; }
    public string? ItemEnabled { get; set; }
    public string? ItemVisualAttribute { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? AbsoluteRow { get; set; }
    public decimal? AbsoluteColumn { get; set; }
    public decimal? AbsoluteOrderBy { get; set; }
    public string? UserTag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GenLampsTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEN_LAMPS_TEMP");

            entity.Property(e => e.AbsoluteColumn)
                .HasColumnName("ABSOLUTE_COLUMN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsoluteOrderBy)
                .HasColumnName("ABSOLUTE_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AbsoluteRow)
                .HasColumnName("ABSOLUTE_ROW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionBehavior)
                .HasColumnName("ACTION_BEHAVIOR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupOrderBy)
                .HasColumnName("GROUP_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemEnabled)
                .HasColumnName("ITEM_ENABLED")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ItemVisualAttribute)
                .HasColumnName("ITEM_VISUAL_ATTRIBUTE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LampId)
                .HasColumnName("LAMP_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LampInfo)
                .HasColumnName("LAMP_INFO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LampType)
                .HasColumnName("LAMP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LayoutId)
                .HasColumnName("LAYOUT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserTag)
                .HasColumnName("USER_TAG")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
