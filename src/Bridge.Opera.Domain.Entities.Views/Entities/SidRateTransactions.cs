namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidRateTransactions
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? EntityType { get; set; }
    public string? EntityValue { get; set; }
    public string? TrxCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidRateTransactions>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RATE_TRANSACTIONS");

            entity.Property(e => e.EntityType)
                .IsRequired()
                .HasColumnName("ENTITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EntityValue)
                .IsRequired()
                .HasColumnName("ENTITY_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
