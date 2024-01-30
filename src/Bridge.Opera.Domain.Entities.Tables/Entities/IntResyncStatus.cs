namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntResyncStatus
{
    public decimal? Id { get; set; }
    public string? Interface { get; set; }
    public string? PmsResort { get; set; }
    public string? Module { get; set; }
    public string? Status { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? Processed { get; set; }
    public decimal? Failed { get; set; }
    public string? Remarks { get; set; }
    public decimal? Total { get; set; }
    public decimal? Sid { get; set; }
    public decimal? SerialNo { get; set; }
    public decimal? InstId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntResyncStatus>(entity =>
        {
            entity.ToTable("INT_RESYNC_STATUS");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Failed)
                .HasColumnName("FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Interface)
                .IsRequired()
                .HasColumnName("INTERFACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.PmsResort)
                .IsRequired()
                .HasColumnName("PMS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Processed)
                .HasColumnName("PROCESSED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.SerialNo)
                .HasColumnName("SERIAL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.Total)
                .HasColumnName("TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
