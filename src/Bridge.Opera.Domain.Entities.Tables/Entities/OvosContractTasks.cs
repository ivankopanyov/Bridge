namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosContractTasks
{
    public decimal? Id { get; set; }
    public string? Resort { get; set; }
    public decimal? ContractId { get; set; }
    public string? TaskCode { get; set; }
    public string? TaskRhythm { get; set; }
    public decimal? Amount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? TrxCode { get; set; }
    public string? PostTo { get; set; }
    public string? OccupiedBy { get; set; }
    public string? PostingRule { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractTasks>(entity =>
        {
            entity.ToTable("OVOS_CONTRACT_TASKS");

            entity.HasIndex(e => new { e.Resort, e.ContractId })
                .HasName("OCT_IDX1");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupiedBy)
                .HasColumnName("OCCUPIED_BY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostTo)
                .HasColumnName("POST_TO")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostingRule)
                .HasColumnName("POSTING_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .IsRequired()
                .HasColumnName("TASK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskRhythm)
                .IsRequired()
                .HasColumnName("TASK_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
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
	                .WithMany(p => p.OvosContractTasks)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OCT_CONTRACTS_FK");
        });
	}
}
