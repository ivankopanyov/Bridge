namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiSizingLog
{
    public decimal? SizingId { get; set; }
    public decimal LogId { get; set; }
    public string Action { get; set; }
    public string ProgramName { get; set; }
    public string Comments { get; set; }
    public DateTime? InsertDate { get; set; }
    public string InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSizingLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SIZING_LOG");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SizingId)
                .HasColumnName("SIZING_ID")
                .HasColumnType("NUMBER");
        });
	}
}
