namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailOperatorDetails
{
    public decimal? OperatorId { get; set; }
    public decimal? Optype { get; set; }
    public string? Description { get; set; }
    public string? Realisation { get; set; }
    public string? Visualisation { get; set; }
    public string? MultiValueYn { get; set; }
    public string? ExecuteYn { get; set; }
    public string? UseTransformationYn { get; set; }

    public virtual MailOperator Operator { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailOperatorDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAIL_OPERATOR_DETAILS");

            entity.HasIndex(e => e.OperatorId)
                .HasName("MAILOD_OPID_IDX");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExecuteYn)
                .HasColumnName("EXECUTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MultiValueYn)
                .HasColumnName("MULTI_VALUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OperatorId)
                .HasColumnName("OPERATOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Optype)
                .HasColumnName("OPTYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Realisation)
                .HasColumnName("REALISATION")
                .IsUnicode(false);

            entity.Property(e => e.UseTransformationYn)
                .HasColumnName("USE_TRANSFORMATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Visualisation)
                .HasColumnName("VISUALISATION")
                .IsUnicode(false);

			if (!types.Contains(typeof(MailOperator)))
				entity.Ignore(e => e.Operator);
			else
	            entity.HasOne(d => d.Operator)
	                .WithMany()
	                .HasForeignKey(d => d.OperatorId)
	                .HasConstraintName("MAILOD_MAILO_FK");
        });
	}
}
