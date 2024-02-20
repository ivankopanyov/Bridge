namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailTablesSys
{
    public decimal? SourceId { get; set; }
    public string? TableName { get; set; }
    public string? TableAlias { get; set; }
    public string? JoinOnlyYn { get; set; }
    public decimal? JoinOrder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailTablesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAIL_TABLES_SYS");

            entity.Property(e => e.JoinOnlyYn)
                .HasColumnName("JOIN_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
        });
	}
}
