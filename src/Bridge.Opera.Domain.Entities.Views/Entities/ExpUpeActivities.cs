namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeActivities
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? LinkType { get; set; }
    public string? PrimaryYn { get; set; }
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Purpose { get; set; }
    public string? TypeCode { get; set; }
    public string? ActType { get; set; }
    public string? ActClass { get; set; }
    public decimal? ContactId { get; set; }
    public string? ContactName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeActivities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_ACTIVITIES");

            entity.Property(e => e.ActClass)
                .HasColumnName("ACT_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Purpose)
                .HasColumnName("PURPOSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
