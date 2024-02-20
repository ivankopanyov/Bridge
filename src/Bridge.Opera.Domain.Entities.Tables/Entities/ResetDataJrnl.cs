namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResetDataJrnl
{
    public string? ObjectName { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdatedBy { get; set; }
    public string? Status { get; set; }
    public string? ObjectType { get; set; }
    public string? Action { get; set; }
    public string? ErrorNumber { get; set; }
    public string? ErrorDescription { get; set; }
    public decimal? ResetTableSeqno { get; set; }
    public string? WorkstationId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResetDataJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESET_DATA_JRNL");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(800)
                .IsUnicode(false);

            entity.Property(e => e.ErrorDescription)
                .HasColumnName("ERROR_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorNumber)
                .HasColumnName("ERROR_NUMBER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ResetTableSeqno)
                .HasColumnName("RESET_TABLE_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WorkstationId)
                .HasColumnName("WORKSTATION_ID")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
