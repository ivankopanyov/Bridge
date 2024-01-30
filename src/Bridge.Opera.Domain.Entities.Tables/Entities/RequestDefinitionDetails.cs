namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RequestDefinitionDetails
{
    public decimal? RequestId { get; set; }
    public string? Language { get; set; }
    public string? DefaultYn { get; set; }
    public string? ScriptText { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Script { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RequestDefinitionDetails>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.Language })
                .HasName("REQDET_PK");

            entity.ToTable("REQUEST_DEFINITION_DETAILS");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Script)
                .HasColumnName("SCRIPT")
                .HasColumnType("CLOB");

            entity.Property(e => e.ScriptText)
                .HasColumnName("SCRIPT_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
