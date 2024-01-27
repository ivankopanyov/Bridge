namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPsMenuDimVw
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string Resort { get; set; }
    public string MenuId { get; set; }
    public string MenuKeyId { get; set; }
    public string MenuDesc { get; set; }
    public string MajorGroup { get; set; }
    public string MajorGroupDesc { get; set; }
    public string FamilyGroup { get; set; }
    public string FamilyGroupDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string ResortId { get; set; }
    public string AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPsMenuDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PS_MENU_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.FamilyGroup)
                .HasColumnName("FAMILY_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.FamilyGroupDesc)
                .HasColumnName("FAMILY_GROUP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MajorGroup)
                .HasColumnName("MAJOR_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.MajorGroupDesc)
                .HasColumnName("MAJOR_GROUP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MenuDesc)
                .HasColumnName("MENU_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .IsUnicode(false);

            entity.Property(e => e.MenuKeyId)
                .HasColumnName("MENU_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
