namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaGenGtt
{
    public string IdxCol { get; set; }
    public string Char1 { get; set; }
    public string Char2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaGenGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OPERA_GEN_GTT");

            entity.HasIndex(e => e.IdxCol)
                .HasName("OPERA_GEN__GTT_IDX1");

            entity.Property(e => e.Char1)
                .HasColumnName("CHAR1")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Char2)
                .HasColumnName("CHAR2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IdxCol)
                .HasColumnName("IDX_COL")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
