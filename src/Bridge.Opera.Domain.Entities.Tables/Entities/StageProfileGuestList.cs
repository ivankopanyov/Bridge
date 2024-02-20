namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileGuestList
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? Email { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? GuestLocalNameId { get; set; }
    public decimal? GuestResortNameId { get; set; }
    public string? GuestFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileGuestList>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_GUEST_LIST");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROF_GUEST_LST_IND1");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestFlag)
                .HasColumnName("GUEST_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestLocalNameId)
                .HasColumnName("GUEST_LOCAL_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestResortNameId)
                .HasColumnName("GUEST_RESORT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasColumnName("MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
