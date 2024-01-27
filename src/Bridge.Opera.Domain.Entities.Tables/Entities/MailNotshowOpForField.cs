namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailNotshowOpForField
{
    public decimal SourceId { get; set; }
    public string Tablename { get; set; }
    public string Fieldname { get; set; }
    public decimal OperatorId { get; set; }

    public virtual MailOperator Operator { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailNotshowOpForField>(entity =>
        {
            entity.HasKey(e => new { e.SourceId, e.Tablename, e.Fieldname, e.OperatorId })
                .HasName("MAIL_NOTSHOW_PK");

            entity.ToTable("MAIL_NOTSHOW_OP_FOR_FIELD");

            entity.HasIndex(e => e.OperatorId)
                .HasName("MAIL_NSFF_MAILOP_FKI");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tablename)
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Fieldname)
                .HasColumnName("FIELDNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.OperatorId)
                .HasColumnName("OPERATOR_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MailOperator)))
				entity.Ignore(e => e.Operator);
			else
	            entity.HasOne(d => d.Operator)
	                .WithMany(p => p.MailNotshowOpForField)
	                .HasForeignKey(d => d.OperatorId)
	                .HasConstraintName("MAIL_NSFF_MAILOP_FK");
        });
	}
}
