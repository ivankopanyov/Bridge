namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailParameters
{
    public decimal? QueryId { get; set; }
    public decimal? ParamValue { get; set; }

    public virtual MailQuery Query { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAIL_PARAMETERS");

            entity.HasIndex(e => new { e.QueryId, e.ParamValue })
                .HasName("MPARAM_FK_I");

            entity.Property(e => e.ParamValue)
                .HasColumnName("PARAM_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MailQuery)))
				entity.Ignore(e => e.Query);
			else
	            entity.HasOne(d => d.Query)
	                .WithMany()
	                .HasForeignKey(d => d.QueryId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MPARAM_MQRY_FK");
        });
	}
}
