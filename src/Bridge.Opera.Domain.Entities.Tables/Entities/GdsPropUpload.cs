namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPropUpload
{
    public decimal PropUpdId { get; set; }
    public string Resort { get; set; }
    public string Status { get; set; }
    public string CategoryType { get; set; }
    public string SubcategoryType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string Flag { get; set; }
    public string PropData1 { get; set; }
    public string PropData2 { get; set; }
    public string PropData3 { get; set; }
    public string ActionCode { get; set; }
    public string InitialUploadYn { get; set; }
    public string PropData4 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPropUpload>(entity =>
        {
            entity.HasKey(e => e.PropUpdId)
                .HasName("GDS_PROP_UPLOAD_PK");

            entity.ToTable("GDS_PROP_UPLOAD");

            entity.HasIndex(e => new { e.Resort, e.CategoryType, e.SubcategoryType })
                .HasName("GDS_PROP_UPLOAD_IDX");

            entity.Property(e => e.PropUpdId)
                .HasColumnName("PROP_UPD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionCode)
                .HasColumnName("ACTION_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CategoryType)
                .IsRequired()
                .HasColumnName("CATEGORY_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Flag)
                .HasColumnName("FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InitialUploadYn)
                .HasColumnName("INITIAL_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropData1)
                .HasColumnName("PROP_DATA1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PropData2)
                .HasColumnName("PROP_DATA2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PropData3)
                .HasColumnName("PROP_DATA3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PropData4)
                .HasColumnName("PROP_DATA4")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SubcategoryType)
                .IsRequired()
                .HasColumnName("SUBCATEGORY_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
