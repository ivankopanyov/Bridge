namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosFractionalOwnersUsers
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal NameId { get; set; }
    public string ProfileType { get; set; }
    public string Relation { get; set; }
    public decimal? RevenueShare { get; set; }
    public decimal? CommissionShare { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? RepeatEndDate { get; set; }
    public string Range { get; set; }
    public string ExpireYn { get; set; }
    public decimal? AccountCode { get; set; }

    public virtual OvosContracts OvosContracts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosFractionalOwnersUsers>(entity =>
        {
            entity.ToTable("OVOS_FRACTIONAL_OWNERS_USERS");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.ContractId })
                .HasName("OFOU_IDX2");

            entity.HasIndex(e => new { e.Resort, e.ContractId, e.BeginDate, e.EndDate })
                .HasName("OFOU_IDX1");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommissionShare)
                .HasColumnName("COMMISSION_SHARE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpireYn)
                .HasColumnName("EXPIRE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileType)
                .IsRequired()
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Range)
                .HasColumnName("RANGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Relation)
                .HasColumnName("RELATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RepeatEndDate)
                .HasColumnName("REPEAT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueShare)
                .HasColumnName("REVENUE_SHARE")
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
	                .WithMany(p => p.OvosFractionalOwnersUsers)
	                .HasForeignKey(d => new { d.Resort, d.ContractId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("OFOU_FK");
        });
	}
}
