namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NoteTypeDept
{
    public string ChainCode { get; set; }
    public string NoteType { get; set; }
    public string NoteCode { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NoteTypeDept>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NOTE_TYPE_DEPT");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("NOTE_TYPE_DEPT_IDX2");

            entity.HasIndex(e => new { e.ChainCode, e.NoteCode, e.NoteType })
                .HasName("NOTE_TYPE_DEPT_IDX1");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .IsRequired()
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteType)
                .IsRequired()
                .HasColumnName("NOTE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
