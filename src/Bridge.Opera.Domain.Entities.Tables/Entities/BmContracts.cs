namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmContracts
{
    public BmContracts()
    {
        BmContractElements = new HashSet<BmContractElements>();
    }

    public decimal? NameId { get; set; }
    public decimal? ContractId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Note { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ContractNo { get; set; }

    public virtual BmAccounts Name { get; set; }
    public virtual ICollection<BmContractElements> BmContractElements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmContracts>(entity =>
        {
            entity.HasKey(e => e.ContractId)
                .HasName("BMC_PK");

            entity.ToTable("BM_CONTRACTS");

            entity.HasIndex(e => new { e.EndDate, e.NameId })
                .HasName("BMC_ED");

            entity.HasIndex(e => new { e.NameId, e.BeginDate, e.EndDate })
                .HasName("BMC_NBD")
                .IsUnique();

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractNo)
                .HasColumnName("CONTRACT_NO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(BmAccounts)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.BmContracts)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMC_BMA_FK");
        
			if (!types.Contains(typeof(BmContractElements)))
				entity.Ignore(e => e.BmContractElements);
		});
	}
}
