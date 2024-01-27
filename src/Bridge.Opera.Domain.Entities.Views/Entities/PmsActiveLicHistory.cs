namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsActiveLicHistory
{
    public string Resort { get; set; }
    public DateTime ActiveStatusBeginDate { get; set; }
    public string PmsActiveYn { get; set; }
    public DateTime? ActiveStatusEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsActiveLicHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_ACTIVE_LIC_HISTORY");

            entity.Property(e => e.ActiveStatusBeginDate)
                .HasColumnName("ACTIVE_STATUS_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActiveStatusEndDate)
                .HasColumnName("ACTIVE_STATUS_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PmsActiveYn)
                .HasColumnName("PMS_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
