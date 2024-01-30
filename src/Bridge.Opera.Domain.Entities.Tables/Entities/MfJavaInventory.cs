namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MfJavaInventory
{
    public string? JarFile { get; set; }
    public string? JavaFile { get; set; }
    public string? FileType { get; set; }
    public decimal? FileSize { get; set; }
    public DateTime? FileDate { get; set; }
    public decimal? TimeStamp { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MfJavaInventory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MF_JAVA_INVENTORY");

            entity.HasIndex(e => e.JavaFile)
                .HasName("SYS_C0031393")
                .IsUnique();

            entity.Property(e => e.FileDate)
                .HasColumnName("FILE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FileSize)
                .HasColumnName("FILE_SIZE")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.FileType)
                .IsRequired()
                .HasColumnName("FILE_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.JarFile)
                .HasColumnName("JAR_FILE")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.JavaFile)
                .IsRequired()
                .HasColumnName("JAVA_FILE")
                .HasMaxLength(1500)
                .IsUnicode(false);

            entity.Property(e => e.TimeStamp)
                .HasColumnName("TIME_STAMP")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");
        });
	}
}
