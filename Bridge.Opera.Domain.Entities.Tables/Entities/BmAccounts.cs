namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmAccounts
{
    public BmAccounts()
    {
        BmContracts = new HashSet<BmContracts>();
        BmReservations = new HashSet<BmReservations>();
        BmResorts = new HashSet<BmResorts>();
        BmStatements = new HashSet<BmStatements>();
    }

    public string AccountCode { get; set; }
    public string AccountType { get; set; }
    public decimal NameId { get; set; }
    public string Note { get; set; }
    public string ExportFormat { get; set; }
    public string ChainCode { get; set; }
    public string Currency { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string TemplateAccount { get; set; }

    public virtual Name Name { get; set; }
    public virtual ICollection<BmContracts> BmContracts { get; set; }
    public virtual ICollection<BmReservations> BmReservations { get; set; }
    public virtual ICollection<BmResorts> BmResorts { get; set; }
    public virtual ICollection<BmStatements> BmStatements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmAccounts>(entity =>
        {
            entity.HasKey(e => e.NameId)
                .HasName("BMA_PK");

            entity.ToTable("BM_ACCOUNTS");

            entity.HasIndex(e => e.AccountCode)
                .HasName("BMA_ACCOUNT_CODE")
                .IsUnique();

            entity.HasIndex(e => new { e.TemplateAccount, e.AccountCode })
                .HasName("BMA_TEMPLATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .IsRequired()
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExportFormat)
                .HasColumnName("EXPORT_FORMAT")
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

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false);

            entity.Property(e => e.TemplateAccount)
                .HasColumnName("TEMPLATE_ACCOUNT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithOne(p => p.BmAccounts)
	                .HasForeignKey<BmAccounts>(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMA_NAE_FK");
        
			if (!types.Contains(typeof(BmContracts)))
				entity.Ignore(e => e.BmContracts);

			if (!types.Contains(typeof(BmReservations)))
				entity.Ignore(e => e.BmReservations);

			if (!types.Contains(typeof(BmResorts)))
				entity.Ignore(e => e.BmResorts);

			if (!types.Contains(typeof(BmStatements)))
				entity.Ignore(e => e.BmStatements);
		});
	}
}
