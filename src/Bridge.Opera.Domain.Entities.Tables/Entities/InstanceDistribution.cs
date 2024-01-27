namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InstanceDistribution
{
    public decimal InstId { get; set; }
    public decimal? FpInstances { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ForceInstanceUse { get; set; }
    public string ProcessorType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InstanceDistribution>(entity =>
        {
            entity.HasKey(e => new { e.InstId, e.ProcessorType })
                .HasName("INSTANCE_DISTRIBUTION_PK");

            entity.ToTable("INSTANCE_DISTRIBUTION");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessorType)
                .HasColumnName("PROCESSOR_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForceInstanceUse)
                .HasColumnName("FORCE_INSTANCE_USE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FpInstances)
                .HasColumnName("FP_INSTANCES")
                .HasColumnType("NUMBER");

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
        });
	}
}
