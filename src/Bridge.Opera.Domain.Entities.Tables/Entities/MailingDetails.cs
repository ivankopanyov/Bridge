namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailingDetails
{
    public decimal? QueryIdLink { get; set; }
    public string? OpenYn { get; set; }
    public string? TableName { get; set; }
    public string? FieldName { get; set; }
    public string? Operator { get; set; }
    public string? FieldType { get; set; }
    public string? Value { get; set; }
    public string? CloseYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Connector { get; set; }

    public virtual MailingHeader QueryIdLinkNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MAILING$DETAILS");

            entity.HasIndex(e => e.QueryIdLink)
                .HasName("MD_MH_IDX");

            entity.Property(e => e.CloseYn)
                .HasColumnName("CLOSE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Connector)
                .HasColumnName("CONNECTOR")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FieldType)
                .HasColumnName("FIELD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OpenYn)
                .HasColumnName("OPEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Operator)
                .HasColumnName("OPERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueryIdLink)
                .HasColumnName("QUERY_ID_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailingHeader)))
				entity.Ignore(e => e.QueryIdLinkNavigation);
			else
	            entity.HasOne(d => d.QueryIdLinkNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.QueryIdLink)
	                .HasConstraintName("MD_MH_FK");
        });
	}
}
