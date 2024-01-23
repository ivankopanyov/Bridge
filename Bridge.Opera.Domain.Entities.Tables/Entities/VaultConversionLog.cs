namespace Bridge.Opera.Domain.Entities.Tables;

public partial class VaultConversionLog
{
    public decimal Id { get; set; }
    public string InputMsg { get; set; }
    public DateTime RequestDt { get; set; }
    public DateTime? ResponseDt { get; set; }
    public string Request { get; set; }
    public string Response { get; set; }
    public string SessionInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<VaultConversionLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VAULT_CONVERSION_LOG");

            entity.HasIndex(e => e.Id)
                .HasName("VCL_IDX");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InputMsg)
                .HasColumnName("INPUT_MSG")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Request)
                .HasColumnName("REQUEST")
                .HasColumnType("CLOB");

            entity.Property(e => e.RequestDt)
                .HasColumnName("REQUEST_DT")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Response)
                .HasColumnName("RESPONSE")
                .HasColumnType("CLOB")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResponseDt)
                .HasColumnName("RESPONSE_DT")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SessionInfo)
                .HasColumnName("SESSION_INFO")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
