namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CachedErrorLog
{
    public string ErrorMsg { get; set; }
    public DateTime LastUpdateTimestamp { get; set; }
    public decimal SeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CachedErrorLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CACHED$_ERROR_LOG");

            entity.Property(e => e.ErrorMsg)
                .IsRequired()
                .HasColumnName("ERROR_MSG")
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTimestamp)
                .HasColumnName("LAST_UPDATE_TIMESTAMP")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");
        });
	}
}
