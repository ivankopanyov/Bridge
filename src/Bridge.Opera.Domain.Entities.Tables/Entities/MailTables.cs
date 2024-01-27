namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailTables
{
    public decimal SourceId { get; set; }
    public string TableName { get; set; }
    public string TableAlias { get; set; }
    public string JoinOnlyYn { get; set; }
    public decimal? JoinOrder { get; set; }

    public virtual MailSource Source { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailTables>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAIL_TABLES");

            entity.HasIndex(e => e.SourceId)
                .HasName("MAILT_SOURCEID_IDX");

            entity.HasIndex(e => new { e.SourceId, e.TableName, e.TableAlias })
                .HasName("MAILT_UK")
                .IsUnique();

            entity.Property(e => e.JoinOnlyYn)
                .HasColumnName("JOIN_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.JoinOrder)
                .HasColumnName("JOIN_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableAlias)
                .HasColumnName("TABLE_ALIAS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany()
	                .HasForeignKey(d => d.SourceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILT_MAILS_FK");
        });
	}
}
