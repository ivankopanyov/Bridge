namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailQuery
{
    public MailQuery()
    {
        MailConditions = new HashSet<MailConditions>();
        MailHitlist = new HashSet<MailHitlist>();
    }

    public decimal? QueryId { get; set; }
    public string? Description { get; set; }
    public decimal? SourceId { get; set; }
    public string? InternalYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? TemporaryYn { get; set; }
    public string? QueryCode { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }

    public virtual MailSource Source { get; set; }
    public virtual ICollection<MailConditions> MailConditions { get; set; }
    public virtual ICollection<MailHitlist> MailHitlist { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailQuery>(entity =>
        {
            entity.HasKey(e => e.QueryId)
                .HasName("MQRY_PK");

            entity.ToTable("MAIL_QUERY");

            entity.HasIndex(e => e.QueryCode)
                .HasName("MAILQ_QUERYCODE_IDX");

            entity.HasIndex(e => e.Resort)
                .HasName("MQRY_RESORT_IDX");

            entity.HasIndex(e => e.SourceId)
                .HasName("MAILQ_SOURCEID_IDX");

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.QueryCode)
                .HasColumnName("QUERY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TemporaryYn)
                .HasColumnName("TEMPORARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailQuery)
	                .HasForeignKey(d => d.SourceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MQRY_MAILS_FK");
        
			if (!types.Contains(typeof(MailConditions)))
				entity.Ignore(e => e.MailConditions);

			if (!types.Contains(typeof(MailHitlist)))
				entity.Ignore(e => e.MailHitlist);
		});
	}
}
