namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BlockCancelCodes
{
    public string Prevcanceltype { get; set; }
    public string Prevreason { get; set; }
    public string Previnformation { get; set; }
    public string Prevdestination { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BlockCancelCodes>(entity =>
        {
            entity.HasKey(e => e.Prevcanceltype)
                .HasName("SYS_C0026968");

            entity.ToTable("BLOCK_CANCEL_CODES");

            entity.Property(e => e.Prevcanceltype)
                .HasColumnName("PREVCANCELTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Prevdestination)
                .HasColumnName("PREVDESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Previnformation)
                .HasColumnName("PREVINFORMATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Prevreason)
                .HasColumnName("PREVREASON")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
