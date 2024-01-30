namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TranslationV
{
    public string? FormName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }
    public string? Version { get; set; }
    public string? ObjectValue { get; set; }
    public string? ObjectTypeDesc { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageName { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreateDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Comments { get; set; }
    public string? Datatype { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public decimal? ItemLength { get; set; }
    public string? SubclassGroup { get; set; }
    public string? TabInd { get; set; }
    public string? ObjInd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TranslationV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRANSLATION_V");

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

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemLength)
                .HasColumnName("ITEM_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageName)
                .HasColumnName("LANGUAGE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ObjInd)
                .HasColumnName("OBJ_IND")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .IsRequired()
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ObjectTypeDesc)
                .HasColumnName("OBJECT_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ObjectValue)
                .HasColumnName("OBJECT_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.SubclassGroup)
                .HasColumnName("SUBCLASS_GROUP")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TabInd)
                .HasColumnName("TAB_IND")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .IsUnicode(false);

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");
        });
	}
}
