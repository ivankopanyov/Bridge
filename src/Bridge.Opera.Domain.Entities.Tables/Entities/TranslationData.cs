namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TranslationData
{
    public string? FormName { get; set; }
    public string? ObjectType { get; set; }
    public string? BlockName { get; set; }
    public string? ObjectName { get; set; }
    public string? LanguageCode { get; set; }
    public string? ObjectValue { get; set; }
    public string? DisplayedYn { get; set; }
    public string? CanvasName { get; set; }
    public string? Tooltip { get; set; }
    public string? AccessKey { get; set; }
    public string? Version { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreateDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Datatype { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public decimal? ItemLength { get; set; }
    public string? SubclassGroup { get; set; }
    public string? TabInd { get; set; }
    public string? Comments { get; set; }
    public string? ObjInd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TranslationData>(entity =>
        {
            entity.HasKey(e => new { e.FormName, e.ObjectName, e.ObjectType, e.LanguageCode })
                .HasName("TRANLATION_DATA_PK");

            entity.ToTable("TRANSLATION_DATA");

            entity.HasIndex(e => new { e.LanguageCode, e.ObjectType, e.ObjectName })
                .HasName("TRANSLATION_DATA_LANG_IDX");

            entity.HasIndex(e => new { e.ObjectType, e.ObjectName, e.LanguageCode, e.TabInd })
                .HasName("TRANSLATION_DATA_OBJECT_IDX");

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectType)
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccessKey)
                .HasColumnName("ACCESS_KEY")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.BlockName)
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanvasName)
                .HasColumnName("CANVAS_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DisplayedYn)
                .HasColumnName("DISPLAYED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemLength)
                .HasColumnName("ITEM_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ObjInd)
                .HasColumnName("OBJ_IND")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectValue)
                .HasColumnName("OBJECT_VALUE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SubclassGroup)
                .HasColumnName("SUBCLASS_GROUP")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TabInd)
                .HasColumnName("TAB_IND")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tooltip)
                .HasColumnName("TOOLTIP")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");
        });
	}
}
