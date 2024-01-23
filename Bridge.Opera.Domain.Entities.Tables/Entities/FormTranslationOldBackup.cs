namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FormTranslationOldBackup
{
    public string FormName { get; set; }
    public string BlockName { get; set; }
    public string CanvasName { get; set; }
    public string ItemName { get; set; }
    public string ItemValue { get; set; }
    public string Version { get; set; }
    public string Datatype { get; set; }
    public string SubclassGroup { get; set; }
    public string Prompt { get; set; }
    public string DisplayedYn { get; set; }
    public string Tooltip { get; set; }
    public string AccessKey { get; set; }
    public decimal? ItemLength { get; set; }
    public DateTime CreateDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string UpdatedBy { get; set; }
    public string Itemtype { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public string Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FormTranslationOldBackup>(entity =>
        {
            entity.HasKey(e => new { e.FormName, e.BlockName, e.ItemName, e.Itemtype })
                .HasName("FORM_TRANSLATION_PK");

            entity.ToTable("FORM_TRANSLATION_OLD_BACKUP");

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BlockName)
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Itemtype)
                .HasColumnName("ITEMTYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccessKey)
                .HasColumnName("ACCESS_KEY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CanvasName)
                .HasColumnName("CANVAS_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasColumnName("CREATED_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(20)
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
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.ItemValue)
                .HasColumnName("ITEM_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Prompt)
                .HasColumnName("PROMPT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SubclassGroup)
                .HasColumnName("SUBCLASS_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Tooltip)
                .HasColumnName("TOOLTIP")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");
        });
	}
}
