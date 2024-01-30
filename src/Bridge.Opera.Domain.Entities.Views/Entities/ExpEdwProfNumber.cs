namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwProfNumber
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? NumberType { get; set; }
    public string? NumberPmsType { get; set; }
    public string? ProfNumber { get; set; }
    public DateTime? NumberExpiration { get; set; }
    public DateTime? NumberEnrollment { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwProfNumber>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_PROF_NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberEnrollment)
                .HasColumnName("NUMBER_ENROLLMENT")
                .HasColumnType("DATE");

            entity.Property(e => e.NumberExpiration)
                .HasColumnName("NUMBER_EXPIRATION")
                .HasColumnType("DATE");

            entity.Property(e => e.NumberPmsType)
                .HasColumnName("NUMBER_PMS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NumberType)
                .HasColumnName("NUMBER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProfNumber)
                .HasColumnName("PROF_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
