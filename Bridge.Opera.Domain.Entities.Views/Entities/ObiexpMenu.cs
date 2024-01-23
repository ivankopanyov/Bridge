namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpMenu
{
    public string RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string Resort { get; set; }
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
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
		modelBuilder.Entity<ObiexpMenu>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_MENU");

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
                .HasMaxLength(428)
                .IsUnicode(false);

            entity.Property(e => e.FamilyGroupDesc)
                .HasColumnName("FAMILY_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MajorGroup)
                .HasColumnName("MAJOR_GROUP")
                .HasMaxLength(224)
                .IsUnicode(false);

            entity.Property(e => e.MajorGroupDesc)
                .HasColumnName("MAJOR_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MenuDesc)
                .IsRequired()
                .HasColumnName("MENU_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MenuId)
                .IsRequired()
                .HasColumnName("MENU_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenuKeyId)
                .HasColumnName("MENU_KEY_ID")
                .HasMaxLength(223)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(262)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}
