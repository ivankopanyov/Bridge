namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BankAccountOrsVw
{
    public string Resort { get; set; }
    public decimal AccountId { get; set; }
    public string AccountNo { get; set; }
    public string BankCode { get; set; }
    public string BranchCode { get; set; }
    public string RoutingNo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string BankName { get; set; }
    public string CurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BankAccountOrsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BANK_ACCOUNT_ORS_VW");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .IsRequired()
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .IsRequired()
                .HasColumnName("BANK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .HasColumnName("BANK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BranchCode)
                .IsRequired()
                .HasColumnName("BRANCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingNo)
                .IsRequired()
                .HasColumnName("ROUTING_NO")
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
