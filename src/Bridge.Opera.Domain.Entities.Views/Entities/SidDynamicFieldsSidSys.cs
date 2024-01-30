namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidDynamicFieldsSidSys
{
    public string? FormMode { get; set; }
    public string? Status { get; set; }
    public string? NextItem { get; set; }
    public string? PreviousItem { get; set; }
    public decimal? DynamicFieldsId { get; set; }
    public string? FormName { get; set; }
    public string? BlockName { get; set; }
    public string? ItemName { get; set; }
    public decimal? XPos { get; set; }
    public decimal? YPos { get; set; }
    public decimal? Height { get; set; }
    public decimal? Width { get; set; }
    public string? DisplayedYn { get; set; }
    public string? NavigableYn { get; set; }
    public string? VisualAttribute { get; set; }
    public string? Dbcolumnname { get; set; }
    public string? PreTextItemTrig { get; set; }
    public string? ValidateItemTrig { get; set; }
    public string? PostTextItemTrig { get; set; }
    public string? Profiletype { get; set; }
    public string? Itemvalue { get; set; }
    public decimal? Taborder { get; set; }
    public string? LovSql { get; set; }
    public string? UsedFor { get; set; }
    public string? CanvasName { get; set; }
    public string? TabName { get; set; }
    public string? RequiredYn { get; set; }
    public string? Itemtype { get; set; }
    public decimal? DynfIdHeader { get; set; }
    public string? Prompt { get; set; }
    public string? AccessKey { get; set; }
    public string? Tooltip { get; set; }
    public string? Version { get; set; }
    public decimal? ItemLength { get; set; }
    public string? Datatype { get; set; }
    public string? SubclassGroup { get; set; }
    public string? ValidateFromList { get; set; }
    public string? MultiSelectLov { get; set; }
    public string? AmountYn { get; set; }
    public string? Resort { get; set; }
    public int? Flags { get; set; }
    public string? PromptVa { get; set; }
    public DateTime? CompareDate { get; set; }
    public decimal? PromptAlignmentOffset { get; set; }
    public decimal? PromptAttachmentOffset { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidDynamicFieldsSidSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_DYNAMIC_FIELDS_SID_SYS");

            entity.Property(e => e.AccessKey)
                .HasColumnName("ACCESS_KEY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AmountYn)
                .HasColumnName("AMOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BlockName)
                .IsRequired()
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CanvasName)
                .HasColumnName("CANVAS_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompareDate)
                .HasColumnName("COMPARE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Datatype)
                .HasColumnName("DATATYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Dbcolumnname)
                .HasColumnName("DBCOLUMNNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DisplayedYn)
                .IsRequired()
                .HasColumnName("DISPLAYED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DynamicFieldsId)
                .HasColumnName("DYNAMIC_FIELDS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DynfIdHeader)
                .HasColumnName("DYNF_ID_HEADER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Flags).HasColumnName("FLAGS");

            entity.Property(e => e.FormMode)
                .HasColumnName("FORM_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemLength)
                .HasColumnName("ITEM_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Itemtype)
                .HasColumnName("ITEMTYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Itemvalue)
                .HasColumnName("ITEMVALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LovSql)
                .HasColumnName("LOV_SQL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MultiSelectLov)
                .HasColumnName("MULTI_SELECT_LOV")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NavigableYn)
                .IsRequired()
                .HasColumnName("NAVIGABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NextItem)
                .HasColumnName("NEXT_ITEM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PostTextItemTrig)
                .HasColumnName("POST_TEXT_ITEM_TRIG")
                .IsUnicode(false);

            entity.Property(e => e.PreTextItemTrig)
                .HasColumnName("PRE_TEXT_ITEM_TRIG")
                .IsUnicode(false);

            entity.Property(e => e.PreviousItem)
                .HasColumnName("PREVIOUS_ITEM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Profiletype)
                .HasColumnName("PROFILETYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Prompt)
                .HasColumnName("PROMPT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromptAlignmentOffset)
                .HasColumnName("PROMPT_ALIGNMENT_OFFSET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromptAttachmentOffset)
                .HasColumnName("PROMPT_ATTACHMENT_OFFSET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromptVa)
                .HasColumnName("PROMPT_VA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SubclassGroup)
                .HasColumnName("SUBCLASS_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TabName)
                .HasColumnName("TAB_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Taborder)
                .HasColumnName("TABORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tooltip)
                .HasColumnName("TOOLTIP")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UsedFor)
                .HasColumnName("USED_FOR")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ValidateFromList)
                .HasColumnName("VALIDATE_FROM_LIST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ValidateItemTrig)
                .HasColumnName("VALIDATE_ITEM_TRIG")
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VisualAttribute)
                .HasColumnName("VISUAL_ATTRIBUTE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XPos)
                .HasColumnName("X_POS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YPos)
                .HasColumnName("Y_POS")
                .HasColumnType("NUMBER");
        });
	}
}
