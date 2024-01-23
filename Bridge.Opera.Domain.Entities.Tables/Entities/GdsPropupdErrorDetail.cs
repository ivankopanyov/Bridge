namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPropupdErrorDetail
{
    public decimal PropupdId { get; set; }
    public string ErrorId { get; set; }
    public string ErrorText { get; set; }
    public string ErrorType { get; set; }
    public string Warning { get; set; }
    public decimal? RetryCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPropupdErrorDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_PROPUPD_ERROR_DETAIL");

            entity.HasIndex(e => e.PropupdId)
                .HasName("GDS_PROPUPD_ERROR_DETAIL_IDX");

            entity.Property(e => e.ErrorId)
                .HasColumnName("ERROR_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorType)
                .HasColumnName("ERROR_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PropupdId)
                .HasColumnName("PROPUPD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Warning)
                .HasColumnName("WARNING")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
