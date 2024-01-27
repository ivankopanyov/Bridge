namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArCreditTrnsList
{
    public decimal? SessionId { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? AccountCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArCreditTrnsList>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR_CREDIT_TRNS_LIST");

            entity.HasIndex(e => e.SessionId)
                .HasName("AR_CREDIT_SESS_ID");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
