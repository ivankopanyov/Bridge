namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileChangeLink
{
    public decimal? NameId { get; set; }
    public string? ChangeType { get; set; }
    public DateTime? ChangeDate { get; set; }
    public decimal? ChangeUser { get; set; }
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? AirlineMembershipId { get; set; }
    public decimal? BusinessCreditCardId { get; set; }
    public decimal? LeisureCreditCardId { get; set; }
    public string? UpdatedItems { get; set; }
    public string? SgiUpdateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileChangeLink>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_CHANGE_LINK");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.NameId })
                .HasName("PROF_CHNG_LINK_UK")
                .IsUnique();

            entity.Property(e => e.AirlineMembershipId)
                .HasColumnName("AIRLINE_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessCreditCardId)
                .HasColumnName("BUSINESS_CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeType)
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChangeUser)
                .HasColumnName("CHANGE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeisureCreditCardId)
                .HasColumnName("LEISURE_CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SgiUpdateYn)
                .HasColumnName("SGI_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedItems)
                .HasColumnName("UPDATED_ITEMS")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
