namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailSubquery
{
    public MailSubquery()
    {
        MailOperator = new HashSet<MailOperator>();
    }

    public decimal SubqueryId { get; set; }
    public string SubqueryCode { get; set; }
    public string Description { get; set; }
    public decimal SourceId { get; set; }
    public string SubqueryText { get; set; }
    public string Placeholder { get; set; }

    public virtual MailSource Source { get; set; }
    public virtual ICollection<MailOperator> MailOperator { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailSubquery>(entity =>
        {
            entity.HasKey(e => e.SubqueryId)
                .HasName("MSQRY_PK");

            entity.ToTable("MAIL_SUBQUERY");

            entity.HasIndex(e => new { e.SourceId, e.SubqueryCode })
                .HasName("MSQRY_UK")
                .IsUnique();

            entity.Property(e => e.SubqueryId)
                .HasColumnName("SUBQUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Placeholder)
                .HasColumnName("PLACEHOLDER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubqueryCode)
                .IsRequired()
                .HasColumnName("SUBQUERY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SubqueryText)
                .IsRequired()
                .HasColumnName("SUBQUERY_TEXT")
                .IsUnicode(false);

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailSubquery)
	                .HasForeignKey(d => d.SourceId)
	                .HasConstraintName("MSQRY_MAILSRC_FK");
        
			if (!types.Contains(typeof(MailOperator)))
				entity.Ignore(e => e.MailOperator);
		});
	}
}
