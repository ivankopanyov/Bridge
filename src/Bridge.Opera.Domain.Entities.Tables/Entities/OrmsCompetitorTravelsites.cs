namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCompetitorTravelsites
{
    public OrmsCompetitorTravelsites()
    {
        OrmsCompetitorData = new HashSet<OrmsCompetitorData>();
        OrmsCompetitorRatecodes = new HashSet<OrmsCompetitorRatecodes>();
        OrmsCompetitorRoomtypes = new HashSet<OrmsCompetitorRoomtypes>();
    }

    public string? Resort { get; set; }
    public string? ShopperCode { get; set; }
    public string? CompetitorResort { get; set; }
    public string? TravelsiteCode { get; set; }
    public string? TravelsiteName { get; set; }
    public string? TravelsiteDesc { get; set; }
    public string? OperaChannel { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ChannelYn { get; set; }

    public virtual OrmsResortCompetitors OrmsResortCompetitors { get; set; }
    public virtual ICollection<OrmsCompetitorData> OrmsCompetitorData { get; set; }
    public virtual ICollection<OrmsCompetitorRatecodes> OrmsCompetitorRatecodes { get; set; }
    public virtual ICollection<OrmsCompetitorRoomtypes> OrmsCompetitorRoomtypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCompetitorTravelsites>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode, e.CompetitorResort, e.TravelsiteCode })
                .HasName("ORMS_COMP_TRAVELSITES_PK");

            entity.ToTable("ORMS_COMPETITOR_TRAVELSITES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompetitorResort)
                .HasColumnName("COMPETITOR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteCode)
                .HasColumnName("TRAVELSITE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChannelYn)
                .HasColumnName("CHANNEL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperaChannel)
                .HasColumnName("OPERA_CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteDesc)
                .HasColumnName("TRAVELSITE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteName)
                .IsRequired()
                .HasColumnName("TRAVELSITE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsResortCompetitors)))
				entity.Ignore(e => e.OrmsResortCompetitors);
			else
	            entity.HasOne(d => d.OrmsResortCompetitors)
	                .WithMany(p => p.OrmsCompetitorTravelsites)
	                .HasForeignKey(d => new { d.CompetitorResort, d.ShopperCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMSCOMPTRAVELSITES_FK");
        
			if (!types.Contains(typeof(OrmsCompetitorData)))
				entity.Ignore(e => e.OrmsCompetitorData);

			if (!types.Contains(typeof(OrmsCompetitorRatecodes)))
				entity.Ignore(e => e.OrmsCompetitorRatecodes);

			if (!types.Contains(typeof(OrmsCompetitorRoomtypes)))
				entity.Ignore(e => e.OrmsCompetitorRoomtypes);
		});
	}
}
