namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvAutoAttachRules
{
    public ResvAutoAttachRules()
    {
        ResvAutoAttachDet = new HashSet<ResvAutoAttachDet>();
    }

    public string Resort { get; set; }
    public string RuleCode { get; set; }
    public string Type { get; set; }
    public string BasedOn { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string RateCode { get; set; }
    public string Preference { get; set; }
    public string PreferenceType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string RoomCategory { get; set; }
    public decimal? MinAdults { get; set; }
    public decimal? MinChildren { get; set; }
    public string KeywordType { get; set; }
    public string VipStatus { get; set; }
    public string AdvancedYn { get; set; }
    public decimal? QueryId { get; set; }

    public virtual ResortRoomCategory R { get; set; }
    public virtual ICollection<ResvAutoAttachDet> ResvAutoAttachDet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvAutoAttachRules>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RuleCode })
                .HasName("RAE_PK");

            entity.ToTable("RESV_AUTO_ATTACH_RULES");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory })
                .HasName("RAE_RRC_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdvancedYn)
                .HasColumnName("ADVANCED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BasedOn)
                .IsRequired()
                .HasColumnName("BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeywordType)
                .HasColumnName("KEYWORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinAdults)
                .HasColumnName("MIN_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinChildren)
                .HasColumnName("MIN_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Preference)
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ResortRoomCategory)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.ResvAutoAttachRules)
	                .HasForeignKey(d => new { d.Resort, d.RoomCategory })
	                .HasConstraintName("RAE_RRC_FK");
        
			if (!types.Contains(typeof(ResvAutoAttachDet)))
				entity.Ignore(e => e.ResvAutoAttachDet);
		});
	}
}
