namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BeErrors
{
    public string? Module { get; set; }
    public string? ActionType { get; set; }
    public string? Resort { get; set; }
    public string? CodeLocation { get; set; }
    public string? ErrorMessage { get; set; }
    public string? MessageType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BeErrors>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BE_ERRORS");

            entity.HasIndex(e => e.Resort)
                .HasName("BE_ERRORS_IND2");

            entity.HasIndex(e => new { e.Module, e.ActionType })
                .HasName("BE_ERRORS_IND1");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CodeLocation)
                .HasColumnName("CODE_LOCATION")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
