namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrsResvName
{
    public decimal? RequestId { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public decimal? ResvContactId { get; set; }
    public decimal? BillingContactId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsResvName>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.NameId })
                .HasName("ORS_RESV_NAME_PK");

            entity.ToTable("ORS_RESV_NAME");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
