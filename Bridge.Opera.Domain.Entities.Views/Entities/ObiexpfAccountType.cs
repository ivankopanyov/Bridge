namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpfAccountType
{
    public string RowKey { get; set; }
    public DateTime RowTimestamp { get; set; }
    public string Resort { get; set; }
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string AccountType { get; set; }
    public string AccountTypeDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string ResortId { get; set; }
    public string AccountTypeKey { get; set; }
    public string AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpfAccountType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPF_ACCOUNT_TYPE");

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeDesc)
                .HasColumnName("ACCOUNT_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeKey)
                .HasColumnName("ACCOUNT_TYPE_KEY")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}
