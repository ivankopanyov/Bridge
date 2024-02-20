namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosContractElements
{
    public decimal? Id { get; set; }
    public string? Resort { get; set; }
    public decimal? ContractId { get; set; }
    public string? ElementCode { get; set; }
    public decimal? ElementMultiplier { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }
    public virtual OvosElements OvosElements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractElements>(entity =>
        {
            entity.ToTable("OVOS_CONTRACT_ELEMENTS");

            entity.HasIndex(e => new { e.Resort, e.ElementCode })
                .HasName("OCE_OE_FKI");

            entity.HasIndex(e => new { e.Resort, e.ContractId, e.ElementCode })
                .HasName("OCE_UK")
                .IsUnique();

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElementCode)
                .IsRequired()
                .HasColumnName("ELEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ElementMultiplier)
                .HasColumnName("ELEMENT_MULTIPLIER")
                .HasColumnType("NUMBER");

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
	                .WithMany(p => p.OvosContractElements)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCE_OC_FK");

			if (!types.Contains(typeof(OvosElements)))
				entity.Ignore(e => e.OvosElements);
			else
	            entity.HasOne(d => d.OvosElements)
	                .WithMany(p => p.OvosContractElements)
	                .HasForeignKey(d => new { d.Resort, d.ElementCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCE_OE_FK");
        });
	}
}
