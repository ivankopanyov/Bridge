namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpfMemEnroll
{
    public string RowKey { get; set; }
    public DateTime RowTimestamp { get; set; }
    public string Resort { get; set; }
    public string AllKey { get; set; }
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string EnrollGroupKey { get; set; }
    public string EnrollGroup { get; set; }
    public string EnrollGroupDesc { get; set; }
    public string EnrollCodeKey { get; set; }
    public string EnrollCode { get; set; }
    public string EnrollDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpfMemEnroll>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPF_MEM_ENROLL");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.EnrollCode)
                .IsRequired()
                .HasColumnName("ENROLL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EnrollCodeKey)
                .IsRequired()
                .HasColumnName("ENROLL_CODE_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EnrollDesc)
                .HasColumnName("ENROLL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EnrollGroup)
                .HasColumnName("ENROLL_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.EnrollGroupDesc)
                .HasColumnName("ENROLL_GROUP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EnrollGroupKey)
                .HasColumnName("ENROLL_GROUP_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasColumnType("CHAR(7)");

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}
