namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailConditions
{
    public decimal QueryId { get; set; }
    public string TableName { get; set; }
    public string FieldName { get; set; }
    public decimal? OperatorId { get; set; }
    public string Param1 { get; set; }
    public string Param2 { get; set; }
    public string Param3 { get; set; }
    public decimal? OpenBracket { get; set; }
    public decimal? CloseBracket { get; set; }
    public string JoinCondition { get; set; }
    public decimal JoinSequence { get; set; }
    public string MultiValueYn { get; set; }
    public string VirtualYn { get; set; }
    public decimal? Function1Id { get; set; }
    public decimal? Function2Id { get; set; }

    public virtual MailOperator Operator { get; set; }
    public virtual MailQuery Query { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailConditions>(entity =>
        {
            entity.HasKey(e => new { e.QueryId, e.JoinSequence })
                .HasName("MCOND_PK");

            entity.ToTable("MAIL_CONDITIONS");

            entity.HasIndex(e => e.OperatorId)
                .HasName("MCOND_OPERATOR_IDX");

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JoinSequence)
                .HasColumnName("JOIN_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CloseBracket)
                .HasColumnName("CLOSE_BRACKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Function1Id)
                .HasColumnName("FUNCTION1_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Function2Id)
                .HasColumnName("FUNCTION2_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JoinCondition)
                .HasColumnName("JOIN_CONDITION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MultiValueYn)
                .HasColumnName("MULTI_VALUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OpenBracket)
                .HasColumnName("OPEN_BRACKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperatorId)
                .HasColumnName("OPERATOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Param1)
                .HasColumnName("PARAM1")
                .IsUnicode(false);

            entity.Property(e => e.Param2)
                .HasColumnName("PARAM2")
                .IsUnicode(false);

            entity.Property(e => e.Param3)
                .HasColumnName("PARAM3")
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.VirtualYn)
                .HasColumnName("VIRTUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

			if (!types.Contains(typeof(MailOperator)))
				entity.Ignore(e => e.Operator);
			else
	            entity.HasOne(d => d.Operator)
	                .WithMany(p => p.MailConditions)
	                .HasForeignKey(d => d.OperatorId)
	                .HasConstraintName("MCOND_MAILO_FK");

			if (!types.Contains(typeof(MailQuery)))
				entity.Ignore(e => e.Query);
			else
	            entity.HasOne(d => d.Query)
	                .WithMany(p => p.MailConditions)
	                .HasForeignKey(d => d.QueryId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MCOND_MQRY_FK");
        });
	}
}
