namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiXmlBuildStat
{
    public decimal? XmlLoadid { get; set; }
    public string? AwName { get; set; }
    public decimal? Processed { get; set; }
    public decimal? Rejected { get; set; }
    public DateTime? BuildStartTime { get; set; }
    public DateTime? BuildMaxTime { get; set; }
    public DateTime? BuildFinishTime { get; set; }
    public decimal? BuildMinutes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiXmlBuildStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_XML_BUILD_STAT");

            entity.Property(e => e.AwName)
                .HasColumnName("AW_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BuildFinishTime)
                .HasColumnName("BUILD_FINISH_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BuildMaxTime)
                .HasColumnName("BUILD_MAX_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BuildMinutes)
                .HasColumnName("BUILD_MINUTES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BuildStartTime)
                .HasColumnName("BUILD_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Processed)
                .HasColumnName("PROCESSED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rejected)
                .HasColumnName("REJECTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XmlLoadid)
                .HasColumnName("XML_LOADID")
                .HasColumnType("NUMBER");
        });
	}
}
