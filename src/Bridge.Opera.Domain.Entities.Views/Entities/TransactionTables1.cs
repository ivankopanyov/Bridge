namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TransactionTables1
{
    public string? TableName { get; set; }
    public string? TableOwner { get; set; }
    public string? DownloadType { get; set; }
    public string? WhereClause { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TransactionTables1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRANSACTION_TABLES");

            entity.Property(e => e.DownloadType)
                .IsRequired()
                .HasColumnName("DOWNLOAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TableOwner)
                .HasColumnName("TABLE_OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .IsUnicode(false);
        });
	}
}
