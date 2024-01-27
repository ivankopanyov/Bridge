namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosContractInsurance
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public string InsuranceType { get; set; }
    public string PolicyNo { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Company { get; set; }
    public string Add1 { get; set; }
    public string Add2 { get; set; }
    public string Add3 { get; set; }
    public string Add4 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractInsurance>(entity =>
        {
            entity.ToTable("OVOS_CONTRACT_INSURANCE");

            entity.HasIndex(e => new { e.Resort, e.ContractId })
                .HasName("OCI_IDX1");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Add1)
                .HasColumnName("ADD1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Add2)
                .HasColumnName("ADD2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Add3)
                .HasColumnName("ADD3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Add4)
                .HasColumnName("ADD4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsuranceType)
                .IsRequired()
                .HasColumnName("INSURANCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNo)
                .IsRequired()
                .HasColumnName("POLICY_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .HasColumnName("POSTAL_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

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
	                .WithMany(p => p.OvosContractInsurance)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCI_CONTRACTS_FK");
        });
	}
}
