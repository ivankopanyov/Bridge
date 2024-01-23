namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActFrequencySetup
{
    public decimal FrequencyId { get; set; }
    public string Resort { get; set; }
    public decimal ActLink { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Frequency { get; set; }
    public decimal? GenerateBefore { get; set; }
    public DateTime? FirstRecurrence { get; set; }
    public DateTime? LastExecution { get; set; }
    public DateTime? NextRecurrence { get; set; }
    public DateTime? LastRecurrence { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActFrequencySetup>(entity =>
        {
            entity.HasKey(e => e.FrequencyId)
                .HasName("ACTFREQ_PK");

            entity.ToTable("ACT_FREQUENCY_SETUP");

            entity.HasIndex(e => e.ActLink)
                .HasName("ACTFREQ_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.StartDate, e.EndDate })
                .HasName("ACTFREQ_RESORT_DATE_IDX");

            entity.Property(e => e.FrequencyId)
                .HasColumnName("FREQUENCY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActLink)
                .HasColumnName("ACT_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FirstRecurrence)
                .HasColumnName("FIRST_RECURRENCE")
                .HasColumnType("DATE");

            entity.Property(e => e.Frequency)
                .IsRequired()
                .HasColumnName("FREQUENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GenerateBefore)
                .HasColumnName("GENERATE_BEFORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastExecution)
                .HasColumnName("LAST_EXECUTION")
                .HasColumnType("DATE");

            entity.Property(e => e.LastRecurrence)
                .HasColumnName("LAST_RECURRENCE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextRecurrence)
                .HasColumnName("NEXT_RECURRENCE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
