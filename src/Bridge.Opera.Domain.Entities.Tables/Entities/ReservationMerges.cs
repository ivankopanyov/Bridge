namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationMerges
{
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public decimal MergeFromResvNameId { get; set; }
    public decimal MergeToResvNameId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationMerges>(entity =>
        {
            entity.HasKey(e => new { e.MergeFromResvNameId, e.Resort })
                .HasName("RESV_MERGE_PK");

            entity.ToTable("RESERVATION_MERGES");

            entity.HasIndex(e => new { e.MergeToResvNameId, e.Resort })
                .HasName("RESV_MERGE_TO_RESVID_IDX");

            entity.Property(e => e.MergeFromResvNameId)
                .HasColumnName("MERGE_FROM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MergeToResvNameId)
                .HasColumnName("MERGE_TO_RESV_NAME_ID")
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
