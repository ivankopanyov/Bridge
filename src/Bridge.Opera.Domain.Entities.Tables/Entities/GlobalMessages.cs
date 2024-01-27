namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GlobalMessages
{
    public decimal? MesgSeq { get; set; }
    public string MesgFileName { get; set; }
    public string MesgText { get; set; }
    public decimal? DisplayInterval { get; set; }
    public DateTime? DisplayStartDate { get; set; }
    public DateTime? DisplayEndDate { get; set; }
    public string DisplayLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GlobalMessages>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GLOBAL_MESSAGES");

            entity.Property(e => e.DisplayEndDate)
                .HasColumnName("DISPLAY_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DisplayInterval)
                .HasColumnName("DISPLAY_INTERVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayLink)
                .HasColumnName("DISPLAY_LINK")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DisplayStartDate)
                .HasColumnName("DISPLAY_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MesgFileName)
                .HasColumnName("MESG_FILE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MesgSeq)
                .HasColumnName("MESG_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MesgText)
                .HasColumnName("MESG_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
