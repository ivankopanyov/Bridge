namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbReservationMemberships
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? MembershipId { get; set; }
    public string? PopulationMethod { get; set; }
    public decimal? PointsMultiplier { get; set; }
    public decimal? NameId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? MembershipLevel { get; set; }
    public string? ProcessedYn { get; set; }
    public DateTime? ProcessedDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? EarningPreference { get; set; }
    public string? HostFlag { get; set; }
    public decimal? HostResvNameId { get; set; }
    public decimal? MultiplierInstance { get; set; }
    public decimal? HostCardinality { get; set; }
    public DateTime? HostBusinessDate { get; set; }
    public decimal? RankValue { get; set; }
    public decimal? PartnerMembershipId { get; set; }
    public DateTime? MbrprefChangedDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbReservationMemberships>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_RESERVATION_MEMBERSHIPS");

            entity.Property(e => e.EarningPreference)
                .HasColumnName("EARNING_PREFERENCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HostBusinessDate)
                .HasColumnName("HOST_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HostCardinality)
                .HasColumnName("HOST_CARDINALITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HostFlag)
                .HasColumnName("HOST_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HostResvNameId)
                .HasColumnName("HOST_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MbrprefChangedDate)
                .HasColumnName("MBRPREF_CHANGED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultiplierInstance)
                .HasColumnName("MULTIPLIER_INSTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartnerMembershipId)
                .HasColumnName("PARTNER_MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsMultiplier)
                .HasColumnName("POINTS_MULTIPLIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PopulationMethod)
                .HasColumnName("POPULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessedDate)
                .HasColumnName("PROCESSED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessedYn)
                .IsRequired()
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RankValue)
                .HasColumnName("RANK_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
