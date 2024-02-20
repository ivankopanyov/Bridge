namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActTraceDetail
{
    public decimal? TraceId { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Condition { get; set; }
    public string? FieldName { get; set; }
    public string? FieldValue { get; set; }
    public string? NewOrOld { get; set; }
    public string? DataType { get; set; }
    public string? Operator { get; set; }
    public string? OperatorValue { get; set; }
    public string? OpenBracket { get; set; }
    public string? CloseBracket { get; set; }
    public string? JoinCondition { get; set; }

    public virtual ActTrace Trace { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActTraceDetail>(entity =>
        {
            entity.HasKey(e => new { e.TraceId, e.OrderBy })
                .HasName("ATD_PK");

            entity.ToTable("ACT$TRACE_DETAIL");

            entity.Property(e => e.TraceId)
                .HasColumnName("TRACE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CloseBracket)
                .HasColumnName("CLOSE_BRACKET")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Condition)
                .IsRequired()
                .HasColumnName("CONDITION")
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FieldValue)
                .HasColumnName("FIELD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.JoinCondition)
                .HasColumnName("JOIN_CONDITION")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.NewOrOld)
                .IsRequired()
                .HasColumnName("NEW_OR_OLD")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.OpenBracket)
                .HasColumnName("OPEN_BRACKET")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .IsRequired()
                .HasColumnName("OPERATOR")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.OperatorValue)
                .IsRequired()
                .HasColumnName("OPERATOR_VALUE")
                .HasMaxLength(30)
                .IsUnicode(false);

			if (!types.Contains(typeof(ActTrace)))
				entity.Ignore(e => e.Trace);
			else
	            entity.HasOne(d => d.Trace)
	                .WithMany(p => p.ActTraceDetail)
	                .HasForeignKey(d => d.TraceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ATD_AT_FK");
        });
	}
}
