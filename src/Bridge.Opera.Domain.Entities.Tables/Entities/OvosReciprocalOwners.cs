namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosReciprocalOwners
{
    public string? Resort { get; set; }
    public decimal? ContractId { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Unit { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosReciprocalOwners>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ContractId, e.ResvNameId })
                .HasName("ORO_PK");

            entity.ToTable("OVOS_RECIPROCAL_OWNERS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Unit)
                .IsRequired()
                .HasColumnName("UNIT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(OvosContracts)))
				entity.Ignore(e => e.OvosContracts);
			else
	            entity.HasOne(d => d.OvosContracts)
	                .WithMany(p => p.OvosReciprocalOwners)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORO_OCT_FK");
        });
	}
}
