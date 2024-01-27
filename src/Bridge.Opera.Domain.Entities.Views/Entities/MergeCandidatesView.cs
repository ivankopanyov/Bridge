namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MergeCandidatesView
{
    public string Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string MergeToResvYn { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MergeCandidatesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MERGE_CANDIDATES_VIEW");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MergeToResvYn)
                .HasColumnName("MERGE_TO_RESV_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
