namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameMergeList
{
    public decimal? NameId { get; set; }
    public DateTime? EvaluationDate { get; set; }
    public DateTime? LastUpdateDate { get; set; }
    public string? EvaluateYn { get; set; }
    public decimal? NoOfTimesEvaluated { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameMergeList>(entity =>
        {
            entity.HasKey(e => e.NameId)
                .HasName("NAME_MERGE_LST_PK");

            entity.ToTable("NAME_MERGE_LIST");

            entity.HasIndex(e => new { e.EvaluateYn, e.LastUpdateDate, e.EvaluationDate, e.NameId })
                .HasName("NAME_MERGE_LST_IDX1");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvaluateYn)
                .IsRequired()
                .HasColumnName("EVALUATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EvaluationDate)
                .HasColumnName("EVALUATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastUpdateDate)
                .HasColumnName("LAST_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NoOfTimesEvaluated)
                .HasColumnName("NO_OF_TIMES_EVALUATED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
