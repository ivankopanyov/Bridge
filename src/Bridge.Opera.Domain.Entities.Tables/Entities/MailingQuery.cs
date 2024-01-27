namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailingQuery
{
    public decimal QueryId { get; set; }
    public DateTime InsertDate { get; set; }
    public string Query { get; set; }
    public string ColumnList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingQuery>(entity =>
        {
            entity.HasKey(e => e.QueryId)
                .HasName("MAILING_QUERY_PK");

            entity.ToTable("MAILING_QUERY");

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ColumnList)
                .HasColumnName("COLUMN_LIST")
                .HasColumnType("CLOB");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Query)
                .HasColumnName("QUERY")
                .HasColumnType("CLOB");
        });
	}
}
