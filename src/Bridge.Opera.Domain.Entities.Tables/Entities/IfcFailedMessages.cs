namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcFailedMessages
{
    public decimal? Id { get; set; }
    public string? Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public string? ActionName { get; set; }
    public string? Message { get; set; }
    public string? ReprocessedYn { get; set; }
    public decimal? RetryCount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcFailedMessages>(entity =>
        {
            entity.ToTable("IFC_FAILED_MESSAGES");

            entity.HasIndex(e => new { e.IfcCtrlId, e.ActionName })
                .HasName("IFCFAILM_CTRLID_ACTION_IND");

            entity.HasIndex(e => new { e.Resort, e.InsertDate })
                .HasName("IFC_FAILED_MSG_IDX");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionName)
                .HasColumnName("ACTION_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Message)
                .HasColumnName("MESSAGE")
                .HasColumnType("CLOB");

            entity.Property(e => e.ReprocessedYn)
                .HasColumnName("REPROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
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
