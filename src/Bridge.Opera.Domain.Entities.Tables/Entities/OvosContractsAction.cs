namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosContractsAction
{
    public decimal ActionInstanceId { get; set; }
    public string Resort { get; set; }
    public decimal? ContractId { get; set; }
    public string ActionType { get; set; }
    public string Machine { get; set; }
    public string Terminal { get; set; }
    public string ActionDescription { get; set; }
    public string Module { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractsAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("OCA_PK");

            entity.ToTable("OVOS_CONTRACTS_ACTION");

            entity.HasIndex(e => new { e.ActionType, e.BusinessDate, e.Resort })
                .HasName("OCA_IDX3");

            entity.HasIndex(e => new { e.InsertDate, e.InsertUser, e.Resort })
                .HasName("OCA_IDX2");

            entity.HasIndex(e => new { e.Resort, e.ContractId, e.ActionType })
                .HasName("OCA_IDX1");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
