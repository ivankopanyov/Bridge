namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExtPosDefinition
{
    public string? Resort { get; set; }
    public string? RecordType { get; set; }
    public string? RecordTypeId { get; set; }
    public string? RecordDesc { get; set; }
    public string? MajorGroup { get; set; }
    public string? MenuItem { get; set; }
    public string? MenuItemDesc { get; set; }
    public string? MajorGroupDesc { get; set; }
    public string? FamilyGroup { get; set; }
    public string? FamilyGroupDesc { get; set; }
    public string? DiscountYn { get; set; }
    public decimal? DiscountPcnt { get; set; }
    public string? ChargeTipYn { get; set; }
    public string? TenderMediaType { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExtPosDefinition>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RecordType, e.RecordTypeId })
                .HasName("EXT_POS_DEFINITION_PK");

            entity.ToTable("EXT_POS_DEFINITION");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RecordTypeId)
                .HasColumnName("RECORD_TYPE_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ChargeTipYn)
                .HasColumnName("CHARGE_TIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiscountPcnt)
                .HasColumnName("DISCOUNT_PCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountYn)
                .HasColumnName("DISCOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FamilyGroup)
                .HasColumnName("FAMILY_GROUP")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FamilyGroupDesc)
                .HasColumnName("FAMILY_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MajorGroup)
                .HasColumnName("MAJOR_GROUP")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MajorGroupDesc)
                .HasColumnName("MAJOR_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MenuItem)
                .HasColumnName("MENU_ITEM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenuItemDesc)
                .HasColumnName("MENU_ITEM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordDesc)
                .IsRequired()
                .HasColumnName("RECORD_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TenderMediaType)
                .HasColumnName("TENDER_MEDIA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
