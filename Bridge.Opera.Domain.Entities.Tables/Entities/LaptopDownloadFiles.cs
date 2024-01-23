namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LaptopDownloadFiles
{
    public decimal FileId { get; set; }
    public string FileName { get; set; }
    public byte[] FileContents { get; set; }
    public string FileUsage { get; set; }
    public decimal? SrepId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaptopDownloadFiles>(entity =>
        {
            entity.HasKey(e => e.FileId)
                .HasName("LF_PK");

            entity.ToTable("LAPTOP$DOWNLOAD_FILES");

            entity.Property(e => e.FileId)
                .HasColumnName("FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FileContents)
                .HasColumnName("FILE_CONTENTS")
                .HasColumnType("BLOB");

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasColumnName("FILE_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.FileUsage)
                .HasColumnName("FILE_USAGE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
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
