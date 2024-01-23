namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScFields
{
    public string Tablename { get; set; }
    public string Fieldname { get; set; }
    public string Language { get; set; }
    public string RealTable { get; set; }
    public string RealField { get; set; }
    public string Description { get; set; }
    public string DisplayYn { get; set; }
    public string ObjType { get; set; }
    public string TraceGroup { get; set; }
    public string DataType { get; set; }
    public string LovYn { get; set; }
    public string UserDescription { get; set; }
    public string MailingYn { get; set; }
    public string FolioXmlYn { get; set; }
    public string FieldDefaultsYn { get; set; }
    public string TracesYn { get; set; }
    public string FilterYn { get; set; }
    public string ContractYn { get; set; }
    public string StartTag { get; set; }
    public string EndTag { get; set; }
    public string DefaultValue { get; set; }
    public string DataInfo { get; set; }
    public string SqlColumn { get; set; }

    public virtual TraceGroups TraceGroupNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScFields>(entity =>
        {
            entity.HasKey(e => new { e.Tablename, e.Fieldname, e.Language, e.RealTable })
                .HasName("DD_PK");

            entity.ToTable("SC$FIELDS");

            entity.HasIndex(e => e.Language)
                .HasName("DD_LANGUAGE_IDX");

            entity.HasIndex(e => e.TraceGroup)
                .HasName("DD_TG_IDX");

            entity.Property(e => e.Tablename)
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Fieldname)
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'E'");

            entity.Property(e => e.RealTable)
                .HasColumnName("REAL_TABLE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ContractYn)
                .HasColumnName("CONTRACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

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

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.EndTag)
                .HasColumnName("END_TAG")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldDefaultsYn)
                .HasColumnName("FIELD_DEFAULTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.FilterYn)
                .HasColumnName("FILTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.FolioXmlYn)
                .HasColumnName("FOLIO_XML_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.LovYn)
                .HasColumnName("LOV_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.MailingYn)
                .HasColumnName("MAILING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ObjType)
                .HasColumnName("OBJ_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RealField)
                .HasColumnName("REAL_FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SqlColumn)
                .HasColumnName("SQL_COLUMN")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.StartTag)
                .HasColumnName("START_TAG")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TraceGroup)
                .HasColumnName("TRACE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TracesYn)
                .HasColumnName("TRACES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UserDescription)
                .HasColumnName("USER_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(TraceGroups)))
				entity.Ignore(e => e.TraceGroupNavigation);
			else
	            entity.HasOne(d => d.TraceGroupNavigation)
	                .WithMany(p => p.ScFields)
	                .HasForeignKey(d => d.TraceGroup)
	                .HasConstraintName("DD_TG_FK");
        });
	}
}
