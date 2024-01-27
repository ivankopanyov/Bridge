namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NamePurgeList
{
    public decimal NameId { get; set; }
    public DateTime EvaluationDueDate { get; set; }
    public decimal NoTimesAttempted { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ProcessingMessage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NamePurgeList>(entity =>
        {
            entity.HasKey(e => e.NameId)
                .HasName("NPT_PK");

            entity.ToTable("NAME_PURGE_LIST");

            entity.HasIndex(e => new { e.EvaluationDueDate, e.NameId })
                .HasName("NAME_PURGE_LIST_IDX1");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvaluationDueDate)
                .HasColumnName("EVALUATION_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoTimesAttempted)
                .HasColumnName("NO_TIMES_ATTEMPTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
