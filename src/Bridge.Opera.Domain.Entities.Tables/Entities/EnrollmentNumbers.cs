namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EnrollmentNumbers
{
    public string? SeqType { get; set; }
    public string? SeqStatus { get; set; }
    public decimal? BeginSeq { get; set; }
    public decimal? EndSeq { get; set; }
    public decimal? CurrentSeq { get; set; }
    public decimal? RequestSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EnrollmentNumbers>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ENROLLMENT_NUMBERS");

            entity.Property(e => e.BeginSeq)
                .HasColumnName("BEGIN_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentSeq)
                .HasColumnName("CURRENT_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndSeq)
                .HasColumnName("END_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestSeq)
                .HasColumnName("REQUEST_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqStatus)
                .IsRequired()
                .HasColumnName("SEQ_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SeqType)
                .IsRequired()
                .HasColumnName("SEQ_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
