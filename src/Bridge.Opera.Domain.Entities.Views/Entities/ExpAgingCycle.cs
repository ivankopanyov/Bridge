namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpAgingCycle
{
    public string Resort { get; set; }
    public decimal? FromAge { get; set; }
    public decimal? ToAge { get; set; }
    public string AgeRange { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string DateForAging { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal? AgeSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpAgingCycle>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_AGING_CYCLE");

            entity.Property(e => e.AgeRange)
                .HasColumnName("AGE_RANGE")
                .IsUnicode(false);

            entity.Property(e => e.AgeSeq)
                .HasColumnName("AGE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateForAging)
                .HasColumnName("DATE_FOR_AGING")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.FromAge)
                .HasColumnName("FROM_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToAge)
                .HasColumnName("TO_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");
        });
	}
}
