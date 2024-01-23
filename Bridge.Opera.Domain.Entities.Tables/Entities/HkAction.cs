namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HkAction
{
    public decimal ActionId { get; set; }
    public string HkModuleId { get; set; }
    public string ActionType { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string ActionDesc { get; set; }
    public string Machine { get; set; }
    public string Terminal { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal? RepairSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkAction>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("HK_ACTION_PK");

            entity.ToTable("HK_ACTION");

            entity.HasIndex(e => e.InsertDate)
                .HasName("HKA_INSDT_IDX");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDesc)
                .HasColumnName("ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HkModuleId)
                .IsRequired()
                .HasColumnName("HK_MODULE_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

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

            entity.Property(e => e.RepairSeq)
                .HasColumnName("REPAIR_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
