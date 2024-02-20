namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScFields1
{
    public string? Tablename { get; set; }
    public string? Fieldname { get; set; }
    public string? Language { get; set; }
    public string? RealTable { get; set; }
    public string? Description { get; set; }
    public string? RealField { get; set; }
    public string? DisplayYn { get; set; }
    public string? ObjType { get; set; }
    public string? TraceGroup { get; set; }
    public string? DataType { get; set; }
    public string? LovYn { get; set; }
    public string? UserDescription { get; set; }
    public string? MailingYn { get; set; }
    public string? FolioXmlYn { get; set; }
    public string? FieldDefaultsYn { get; set; }
    public string? TracesYn { get; set; }
    public string? FilterYn { get; set; }
    public string? ContractYn { get; set; }
    public string? StartTag { get; set; }
    public string? EndTag { get; set; }
    public string? DefaultValue { get; set; }
    public string? DataInfo { get; set; }
    public string? DescriptionOriginal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScFields1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_FIELDS");

            entity.Property(e => e.ContractYn)
                .HasColumnName("CONTRACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DataInfo)
                .HasColumnName("DATA_INFO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DescriptionOriginal)
                .HasColumnName("DESCRIPTION_ORIGINAL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndTag)
                .HasColumnName("END_TAG")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldDefaultsYn)
                .HasColumnName("FIELD_DEFAULTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Fieldname)
                .IsRequired()
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FilterYn)
                .HasColumnName("FILTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioXmlYn)
                .HasColumnName("FOLIO_XML_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .IsRequired()
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LovYn)
                .HasColumnName("LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MailingYn)
                .HasColumnName("MAILING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ObjType)
                .HasColumnName("OBJ_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RealField)
                .HasColumnName("REAL_FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RealTable)
                .IsRequired()
                .HasColumnName("REAL_TABLE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.StartTag)
                .HasColumnName("START_TAG")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tablename)
                .IsRequired()
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TraceGroup)
                .HasColumnName("TRACE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TracesYn)
                .HasColumnName("TRACES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UserDescription)
                .HasColumnName("USER_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
