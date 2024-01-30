namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailHitlist
{
    public decimal? HitlistId { get; set; }
    public decimal? QueryId { get; set; }
    public decimal? SourceId { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }

    public virtual MailQuery Query { get; set; }
    public virtual MailSource Source { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailHitlist>(entity =>
        {
            entity.HasKey(e => e.HitlistId)
                .HasName("MAIL_HITLIST_PK");

            entity.ToTable("MAIL_HITLIST");

            entity.HasIndex(e => e.QueryId)
                .HasName("MAILHL_QUERYID_IDX");

            entity.HasIndex(e => e.Resort)
                .HasName("MAILHL_RESORT_IDX");

            entity.HasIndex(e => e.SourceId)
                .HasName("MAILHL_SOURCEID_IDX");

            entity.Property(e => e.HitlistId)
                .HasColumnName("HITLIST_ID")
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

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MailQuery)))
				entity.Ignore(e => e.Query);
			else
	            entity.HasOne(d => d.Query)
	                .WithMany(p => p.MailHitlist)
	                .HasForeignKey(d => d.QueryId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILHL_MQRY_FK");

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailHitlist)
	                .HasForeignKey(d => d.SourceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILHL_MAILS_FK");
        });
	}
}
