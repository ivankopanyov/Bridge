namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiErrorLog
{
    public string SchemaName { get; set; }
    public string AwName { get; set; }
    public string CubeName { get; set; }
    public string DimensionName { get; set; }
    public string ProgramName { get; set; }
    public string BusinessDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public string Action { get; set; }
    public string InsertUser { get; set; }
    public string Comments { get; set; }
    public decimal LogId { get; set; }
    public decimal? Loadid { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiErrorLog>(entity =>
        {
            entity.HasKey(e => e.LogId)
                .HasName("OBI_ERROR_LOG_PK");

            entity.ToTable("OBI_ERROR_LOG");

            entity.HasIndex(e => e.Loadid)
                .HasName("OBI_ERROR_LOG_IND2");

            entity.HasIndex(e => new { e.InsertDate, e.CubeName })
                .HasName("OBI_ERROR_LOG_IND3");

            entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AwName)
                .HasColumnName("AW_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CubeName)
                .HasColumnName("CUBE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DimensionName)
                .HasColumnName("DIMENSION_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Loadid)
                .HasColumnName("LOADID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SchemaName)
                .HasColumnName("SCHEMA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
