namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosContractsSubscriptions
{
    public decimal? ContractId { get; set; }
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? ExtContractNumber { get; set; }
    public string? ExtContractType { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractsSubscriptions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ContractId, e.InterfaceId })
                .HasName("OCS_PK");

            entity.ToTable("OVOS_CONTRACTS_SUBSCRIPTIONS");

            entity.HasIndex(e => new { e.Resort, e.InterfaceId, e.ExtContractNumber, e.ExtContractType })
                .HasName("OCS_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExtContractNumber)
                .IsRequired()
                .HasColumnName("EXT_CONTRACT_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExtContractType)
                .IsRequired()
                .HasColumnName("EXT_CONTRACT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OvosContracts)))
				entity.Ignore(e => e.OvosContracts);
			else
	            entity.HasOne(d => d.OvosContracts)
	                .WithMany(p => p.OvosContractsSubscriptions)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCS_OC_FK");
        });
	}
}
