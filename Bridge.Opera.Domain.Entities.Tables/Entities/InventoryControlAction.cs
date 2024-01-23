namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InventoryControlAction
{
    public decimal ActionInstanceId { get; set; }
    public string ActionType { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string Machine { get; set; }
    public string Terminal { get; set; }
    public string ActionDescription { get; set; }
    public decimal? StartLimitId { get; set; }
    public decimal? EndLimitId { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InventoryControlAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("INVENTORY_CONTROL_ACTION_PK");

            entity.ToTable("INVENTORY_CONTROL_ACTION");

            entity.HasIndex(e => e.InsertDate)
                .HasName("ICA_INSDT_IDX");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.EndLimitId)
                .HasColumnName("END_LIMIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .IsRequired()
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartLimitId)
                .HasColumnName("START_LIMIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Terminal)
                .IsRequired()
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
