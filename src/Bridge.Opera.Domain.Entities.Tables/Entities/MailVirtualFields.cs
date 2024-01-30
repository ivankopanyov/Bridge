namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailVirtualFields
{
    public decimal? FieldId { get; set; }
    public decimal? SourceId { get; set; }
    public string? TableName { get; set; }
    public string? FieldName { get; set; }
    public string? Description { get; set; }
    public string? DataType { get; set; }
    public string? Realisation { get; set; }
    public string? ParameterUseYn { get; set; }
    public string? ParameterYn { get; set; }
    public string? ReplaceableYn { get; set; }
    public string? ConditionYn { get; set; }
    public string? CalculatedYn { get; set; }
    public string? FieldCode { get; set; }
    public string? SubqueryYn { get; set; }
    public string? TagYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailVirtualFields>(entity =>
        {
            entity.HasKey(e => e.FieldId)
                .HasName("MAILVF_PK");

            entity.ToTable("MAIL_VIRTUAL_FIELDS");

            entity.HasIndex(e => new { e.FieldCode, e.DataType, e.SourceId, e.TableName, e.FieldName })
                .HasName("MAILVF_UK")
                .IsUnique();

            entity.Property(e => e.FieldId)
                .HasColumnName("FIELD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalculatedYn)
                .HasColumnName("CALCULATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConditionYn)
                .HasColumnName("CONDITION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FieldCode)
                .HasColumnName("FIELD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ParameterUseYn)
                .HasColumnName("PARAMETER_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ParameterYn)
                .HasColumnName("PARAMETER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Realisation)
                .HasColumnName("REALISATION")
                .IsUnicode(false);

            entity.Property(e => e.ReplaceableYn)
                .HasColumnName("REPLACEABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubqueryYn)
                .HasColumnName("SUBQUERY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TagYn)
                .HasColumnName("TAG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
