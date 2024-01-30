namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpHskRsActionData
{
    public string? AttendantId { get; set; }
    public string? AttendantName { get; set; }
    public string? JobTitleCode { get; set; }
    public string? Room { get; set; }
    public string? BlockCode { get; set; }
    public string? TimeIn { get; set; }
    public string? TimeOut { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpHskRsActionData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_HSK_RS_ACTION_DATA");

            entity.Property(e => e.AttendantId)
                .IsRequired()
                .HasColumnName("ATTENDANT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttendantName)
                .IsRequired()
                .HasColumnName("ATTENDANT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.JobTitleCode)
                .HasColumnName("JOB_TITLE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimeIn)
                .HasColumnName("TIME_IN")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.TimeOut)
                .HasColumnName("TIME_OUT")
                .HasMaxLength(75)
                .IsUnicode(false);
        });
	}
}
