namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPropupdMapping
{
    public string Resort { get; set; }
    public string CategoryType { get; set; }
    public string SubcategoryType { get; set; }
    public string OperaCode { get; set; }
    public string GdsCode { get; set; }
    public string Type1 { get; set; }
    public string Type2 { get; set; }
    public string Type3 { get; set; }
    public string Type4 { get; set; }
    public string Type5 { get; set; }
    public string Type6 { get; set; }
    public string Type7 { get; set; }
    public string Type8 { get; set; }
    public decimal? AmountQty { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Dow { get; set; }
    public string CategoryId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPropupdMapping>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_PROPUPD_MAPPING");

            entity.HasIndex(e => new { e.Resort, e.CategoryType, e.SubcategoryType, e.OperaCode, e.GdsCode })
                .HasName("GDS_PROPUPD_MAPPING_IDX");

            entity.Property(e => e.AmountQty)
                .HasColumnName("AMOUNT_QTY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CategoryId)
                .HasColumnName("CATEGORY_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CategoryType)
                .IsRequired()
                .HasColumnName("CATEGORY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Dow)
                .HasColumnName("DOW")
                .HasMaxLength(7)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsCode)
                .IsRequired()
                .HasColumnName("GDS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaCode)
                .IsRequired()
                .HasColumnName("OPERA_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SubcategoryType)
                .IsRequired()
                .HasColumnName("SUBCATEGORY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type1)
                .HasColumnName("TYPE_1")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type2)
                .HasColumnName("TYPE_2")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type3)
                .HasColumnName("TYPE_3")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type4)
                .HasColumnName("TYPE_4")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type5)
                .HasColumnName("TYPE_5")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type6)
                .HasColumnName("TYPE_6")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type7)
                .HasColumnName("TYPE_7")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type8)
                .HasColumnName("TYPE_8")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
