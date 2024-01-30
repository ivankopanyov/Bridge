namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FormTranslation
{
    public string? FormName { get; set; }
    public string? ObjectName { get; set; }
    public string? BlockName { get; set; }
    public string? ItemName { get; set; }
    public string? ItemValue { get; set; }
    public string? Prompt { get; set; }
    public string? CanvasName { get; set; }
    public string? Version { get; set; }
    public string? Datatype { get; set; }
    public string? SubclassGroup { get; set; }
    public string? DisplayedYn { get; set; }
    public string? Tooltip { get; set; }
    public string? AccessKey { get; set; }
    public decimal? ItemLength { get; set; }
    public DateTime? CreateDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? Itemtype { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public string? Comments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FormTranslation>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FORM_TRANSLATION");

            entity.Property(e => e.AccessKey)
                .HasColumnName("ACCESS_KEY")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.BlockName)
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(1200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanvasName)
                .HasColumnName("CANVAS_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayedYn)
                .HasColumnName("DISPLAYED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemLength)
                .HasColumnName("ITEM_LENGTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(1200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemValue)
                .HasColumnName("ITEM_VALUE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Itemtype)
                .IsRequired()
                .HasColumnName("ITEMTYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.Prompt)
                .HasColumnName("PROMPT")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SubclassGroup)
                .HasColumnName("SUBCLASS_GROUP")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tooltip)
                .HasColumnName("TOOLTIP")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
