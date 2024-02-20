namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpdateMarketCodeExceptions
{
    public string? TableName { get; set; }
    public string? FromMktCode { get; set; }
    public string? ToMktCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpdateMarketCodeExceptions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("UPDATE_MARKET_CODE_EXCEPTIONS");

            entity.Property(e => e.FromMktCode)
                .HasColumnName("FROM_MKT_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ToMktCode)
                .HasColumnName("TO_MKT_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
