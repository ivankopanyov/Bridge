namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WoPbxIn
{
    public string? Resort { get; set; }
    public string? PbxInString { get; set; }
    public DateTime? RequestedDate { get; set; }
    public decimal? SequenceNo { get; set; }
    public decimal? WoNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WoPbxIn>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WO_PBX_IN");

            entity.Property(e => e.PbxInString)
                .IsRequired()
                .HasColumnName("PBX_IN_STRING")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequestedDate)
                .HasColumnName("REQUESTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SequenceNo)
                .HasColumnName("SEQUENCE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
