namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HltnGlTrxGroupsView
{
    public string? ItemId { get; set; }
    public string? AllowDrillDownYn { get; set; }
    public string? GroupCode { get; set; }
    public string? GroupDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HltnGlTrxGroupsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HLTN_GL_TRX_GROUPS_VIEW");

            entity.Property(e => e.AllowDrillDownYn)
                .HasColumnName("ALLOW_DRILL_DOWN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GroupDescription)
                .HasColumnName("GROUP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
