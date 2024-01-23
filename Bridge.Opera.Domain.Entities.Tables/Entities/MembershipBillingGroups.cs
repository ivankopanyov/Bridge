namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipBillingGroups
{
    public string ChainCode { get; set; }
    public string BillingGroup { get; set; }
    public string ExchangeCode { get; set; }
    public string BillingGroupLabel { get; set; }
    public string AccountType { get; set; }
    public string AccountCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipBillingGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.BillingGroup })
                .HasName("BGP_PK");

            entity.ToTable("MEMBERSHIP_BILLING_GROUPS");

            entity.HasIndex(e => new { e.ChainCode, e.ExchangeCode })
                .HasName("MEM_BILLING_GRP_IND1");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillingGroupLabel)
                .HasColumnName("BILLING_GROUP_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeCode)
                .IsRequired()
                .HasColumnName("EXCHANGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
