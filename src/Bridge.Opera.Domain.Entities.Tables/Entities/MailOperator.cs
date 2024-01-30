namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailOperator
{
    public MailOperator()
    {
        MailConditions = new HashSet<MailConditions>();
        MailNotshowOpForField = new HashSet<MailNotshowOpForField>();
    }

    public decimal? OperatorId { get; set; }
    public string? DataType { get; set; }
    public string? Description { get; set; }
    public string? VirtualYn { get; set; }
    public string? DefaultYn { get; set; }
    public string? DerivedYn { get; set; }
    public decimal? SourceId { get; set; }
    public string? FieldName { get; set; }
    public string? OperatorCode { get; set; }
    public string? InternalYn { get; set; }
    public string? UseNullYn { get; set; }
    public decimal? SubqueryId { get; set; }
    public decimal? DefaultOrderby { get; set; }

    public virtual MailSubquery Subquery { get; set; }
    public virtual ICollection<MailConditions> MailConditions { get; set; }
    public virtual ICollection<MailNotshowOpForField> MailNotshowOpForField { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailOperator>(entity =>
        {
            entity.HasKey(e => e.OperatorId)
                .HasName("MAILO_PK");

            entity.ToTable("MAIL_OPERATOR");

            entity.HasIndex(e => e.SubqueryId)
                .HasName("MAILOP_MSQRY_FKI");

            entity.HasIndex(e => new { e.OperatorCode, e.DataType, e.SourceId, e.FieldName })
                .HasName("MAILO_UK")
                .IsUnique();

            entity.Property(e => e.OperatorId)
                .HasColumnName("OPERATOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultOrderby)
                .HasColumnName("DEFAULT_ORDERBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DerivedYn)
                .HasColumnName("DERIVED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperatorCode)
                .HasColumnName("OPERATOR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubqueryId)
                .HasColumnName("SUBQUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UseNullYn)
                .HasColumnName("USE_NULL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VirtualYn)
                .HasColumnName("VIRTUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailSubquery)))
				entity.Ignore(e => e.Subquery);
			else
	            entity.HasOne(d => d.Subquery)
	                .WithMany(p => p.MailOperator)
	                .HasForeignKey(d => d.SubqueryId)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("MAILOP_MSQRY_FK");
        
			if (!types.Contains(typeof(MailConditions)))
				entity.Ignore(e => e.MailConditions);

			if (!types.Contains(typeof(MailNotshowOpForField)))
				entity.Ignore(e => e.MailNotshowOpForField);
		});
	}
}
