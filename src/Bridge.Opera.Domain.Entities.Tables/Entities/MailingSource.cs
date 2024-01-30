namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailingSource
{
    public decimal? QueryIdLink { get; set; }
    public string? TableName { get; set; }

    public virtual MailingHeader QueryIdLinkNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingSource>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAILING$SOURCE");

            entity.HasIndex(e => e.QueryIdLink)
                .HasName("MS_MH_IDX");

            entity.Property(e => e.QueryIdLink)
                .HasColumnName("QUERY_ID_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailingHeader)))
				entity.Ignore(e => e.QueryIdLinkNavigation);
			else
	            entity.HasOne(d => d.QueryIdLinkNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.QueryIdLink)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MS_MH_FK");
        });
	}
}
