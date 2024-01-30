namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LoadError
{
    public string? LoadProcess { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? ErrMessage { get; set; }
    public string? ErrCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LoadError>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("LOAD_ERROR");

            entity.Property(e => e.ErrCode)
                .HasColumnName("ERR_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ErrMessage)
                .IsRequired()
                .HasColumnName("ERR_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoadProcess)
                .IsRequired()
                .HasColumnName("LOAD_PROCESS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
