namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScCeilingAction
{
    public decimal ActionId { get; set; }
    public string Resort { get; set; }
    public DateTime CeilingDate { get; set; }
    public string PmsRoomtype { get; set; }
    public decimal? OldQuantity { get; set; }
    public decimal? NewQuantity { get; set; }
    public string ActionType { get; set; }
    public string ActionDesc { get; set; }
    public string Machine { get; set; }
    public string TerminalId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScCeilingAction>(entity =>
        {
            entity.HasKey(e => e.ActionId)
                .HasName("SCA_PK");

            entity.ToTable("SC_CEILING_ACTION");

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

            entity.Property(e => e.CeilingDate)
                .HasColumnName("CEILING_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.NewQuantity)
                .HasColumnName("NEW_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldQuantity)
                .HasColumnName("OLD_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsRoomtype)
                .HasColumnName("PMS_ROOMTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TerminalId)
                .HasColumnName("TERMINAL_ID")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
