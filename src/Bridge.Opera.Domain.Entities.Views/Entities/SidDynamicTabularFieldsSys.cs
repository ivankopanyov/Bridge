namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidDynamicTabularFieldsSys
{
    public string? ModuleName { get; set; }
    public string? DisplaySet { get; set; }
    public string? BlockName { get; set; }
    public string? FieldName { get; set; }
    public decimal? OrderBy { get; set; }
    public string? DataType { get; set; }
    public string? Resort { get; set; }
    public string? PromptText { get; set; }
    public string? PromptCode { get; set; }
    public string? VisibleYn { get; set; }
    public string? InitialValue { get; set; }
    public string? CaseRestriction { get; set; }
    public string? EntityName { get; set; }
    public string? DefaultTemplateYn { get; set; }
    public string? SidYn { get; set; }
    public string? PopulationMethod { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidDynamicTabularFieldsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_DYNAMIC_TABULAR_FIELDS_SYS");

            entity.Property(e => e.BlockName)
                .IsRequired()
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CaseRestriction)
                .HasColumnName("CASE_RESTRICTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultTemplateYn)
                .HasColumnName("DEFAULT_TEMPLATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySet)
                .IsRequired()
                .HasColumnName("DISPLAY_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityName)
                .HasColumnName("ENTITY_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InitialValue)
                .HasColumnName("INITIAL_VALUE")
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PopulationMethod)
                .HasColumnName("POPULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromptCode)
                .HasColumnName("PROMPT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PromptText)
                .HasColumnName("PROMPT_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SidYn)
                .HasColumnName("SID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VisibleYn)
                .HasColumnName("VISIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
