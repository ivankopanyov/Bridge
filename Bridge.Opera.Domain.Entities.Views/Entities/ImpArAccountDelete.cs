namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ImpArAccountDelete
{
    public string Resort { get; set; }
    public string AccountNo { get; set; }
    public decimal? ImportId { get; set; }
    public string ImportTabName { get; set; }
    public DateTime? ImportDate { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? SeqNo { get; set; }
    public string ImportStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpArAccountDelete>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IMP_AR_ACCOUNT_DELETE");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportId)
                .HasColumnName("IMPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImportStatus)
                .HasColumnName("IMPORT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ImportTabName)
                .HasColumnName("IMPORT_TAB_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
