namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScBusblockInfoFact
{
    public string Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? NoOfNights { get; set; }
    public decimal? RmsBlocked { get; set; }
    public decimal? RevBlocked { get; set; }
    public decimal? Avgrate { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? ActualRooms { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? ActualAvgRate { get; set; }
    public decimal? AvailableRooms { get; set; }
    public decimal? AvailableRevenue { get; set; }
    public decimal? TotalComplimentaryRooms { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? RmsContracted { get; set; }
    public decimal? PeakRooms { get; set; }
    public string RelatedResorts { get; set; }
    public string AllOwners { get; set; }
    public string RmsOwners { get; set; }
    public string CatOwners { get; set; }
    public decimal? RevContracted { get; set; }
    public decimal? AvgRateNet { get; set; }
    public decimal? RevBlockedNet { get; set; }
    public decimal? FbRevInactive { get; set; }
    public decimal? OtherRevInactive { get; set; }
    public decimal? CatRevInactive { get; set; }
    public decimal? OffsetTotRevGross { get; set; }
    public decimal? OffsetTotRevNet { get; set; }
    public decimal? OffsetAvailRevGross { get; set; }
    public decimal? OffsetAvailRevNet { get; set; }
    public decimal? OffsetPickupRevGross { get; set; }
    public decimal? OffsetPickupRevNet { get; set; }
    public decimal? ExpAudioVisualRev { get; set; }
    public decimal? ExpBevRev { get; set; }
    public decimal? ExpFoodRev { get; set; }
    public decimal? ExpOtherRev { get; set; }
    public decimal? ExpRentalRev { get; set; }
    public decimal? FcastAudioVisualRev { get; set; }
    public decimal? FcastBevRev { get; set; }
    public decimal? FcastFoodRev { get; set; }
    public decimal? FcastOtherRev { get; set; }
    public decimal? FcastRentalRev { get; set; }
    public decimal? GtdAudioVisualRev { get; set; }
    public decimal? GtdBevRev { get; set; }
    public decimal? GtdFoodRev { get; set; }
    public decimal? GtdOtherRev { get; set; }
    public decimal? GtdRentalRev { get; set; }
    public decimal? BilledAudioVisualRev { get; set; }
    public decimal? BilledBevRev { get; set; }
    public decimal? BilledFoodRev { get; set; }
    public decimal? BilledOtherRev { get; set; }
    public decimal? BilledRentalRev { get; set; }
    public decimal? OtbAudioVisualRev { get; set; }
    public decimal? OtbBevRev { get; set; }
    public decimal? OtbFoodRev { get; set; }
    public decimal? OtbOtherRev { get; set; }
    public decimal? OtbRentalRev { get; set; }
    public decimal? ExpGroup1Rev { get; set; }
    public decimal? ExpGroup2Rev { get; set; }
    public decimal? ExpGroup3Rev { get; set; }
    public decimal? ExpGroup4Rev { get; set; }
    public decimal? ExpGroup5Rev { get; set; }
    public decimal? FcastGroup1Rev { get; set; }
    public decimal? FcastGroup2Rev { get; set; }
    public decimal? FcastGroup3Rev { get; set; }
    public decimal? FcastGroup4Rev { get; set; }
    public decimal? FcastGroup5Rev { get; set; }
    public decimal? GtdGroup1Rev { get; set; }
    public decimal? GtdGroup2Rev { get; set; }
    public decimal? GtdGroup3Rev { get; set; }
    public decimal? GtdGroup4Rev { get; set; }
    public decimal? GtdGroup5Rev { get; set; }
    public decimal? BilledGroup1Rev { get; set; }
    public decimal? BilledGroup2Rev { get; set; }
    public decimal? BilledGroup3Rev { get; set; }
    public decimal? BilledGroup4Rev { get; set; }
    public decimal? BilledGroup5Rev { get; set; }
    public decimal? OtbGroup1Rev { get; set; }
    public decimal? OtbGroup2Rev { get; set; }
    public decimal? OtbGroup3Rev { get; set; }
    public decimal? OtbGroup4Rev { get; set; }
    public decimal? OtbGroup5Rev { get; set; }
    public string AllCompanyOwners { get; set; }
    public string AllAgentOwners { get; set; }
    public string AllSourceOwners { get; set; }
    public decimal? DepositPaidAmt { get; set; }
    public decimal? DepositRequestAmt { get; set; }
    public decimal? DepositUnpaidAmt { get; set; }
    public decimal? FbTransactionRev { get; set; }
    public decimal? OtherTransactionRev { get; set; }
    public decimal? TotalTransactionRev { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScBusblockInfoFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_BUSBLOCK_INFO_FACT");

            entity.Property(e => e.ActualAvgRate)
                .HasColumnName("ACTUAL_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRooms)
                .HasColumnName("ACTUAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllAgentOwners)
                .HasColumnName("ALL_AGENT_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.AllCompanyOwners)
                .HasColumnName("ALL_COMPANY_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.AllOwners)
                .HasColumnName("ALL_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.AllSourceOwners)
                .HasColumnName("ALL_SOURCE_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.AvailableRevenue)
                .HasColumnName("AVAILABLE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailableRooms)
                .HasColumnName("AVAILABLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgRateNet)
                .HasColumnName("AVG_RATE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Avgrate)
                .HasColumnName("AVGRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledAudioVisualRev)
                .HasColumnName("BILLED_AUDIO_VISUAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledBevRev)
                .HasColumnName("BILLED_BEV_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledFoodRev)
                .HasColumnName("BILLED_FOOD_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledGroup1Rev)
                .HasColumnName("BILLED_GROUP1_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledGroup2Rev)
                .HasColumnName("BILLED_GROUP2_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledGroup3Rev)
                .HasColumnName("BILLED_GROUP3_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledGroup4Rev)
                .HasColumnName("BILLED_GROUP4_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledGroup5Rev)
                .HasColumnName("BILLED_GROUP5_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledOtherRev)
                .HasColumnName("BILLED_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRentalRev)
                .HasColumnName("BILLED_RENTAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatOwners)
                .HasColumnName("CAT_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.CatRevInactive)
                .HasColumnName("CAT_REV_INACTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositPaidAmt)
                .HasColumnName("DEPOSIT_PAID_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositRequestAmt)
                .HasColumnName("DEPOSIT_REQUEST_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositUnpaidAmt)
                .HasColumnName("DEPOSIT_UNPAID_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpAudioVisualRev)
                .HasColumnName("EXP_AUDIO_VISUAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpBevRev)
                .HasColumnName("EXP_BEV_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFoodRev)
                .HasColumnName("EXP_FOOD_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpGroup1Rev)
                .HasColumnName("EXP_GROUP1_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpGroup2Rev)
                .HasColumnName("EXP_GROUP2_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpGroup3Rev)
                .HasColumnName("EXP_GROUP3_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpGroup4Rev)
                .HasColumnName("EXP_GROUP4_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpGroup5Rev)
                .HasColumnName("EXP_GROUP5_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpOtherRev)
                .HasColumnName("EXP_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpRentalRev)
                .HasColumnName("EXP_RENTAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevInactive)
                .HasColumnName("FB_REV_INACTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbTransactionRev)
                .HasColumnName("FB_TRANSACTION_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastAudioVisualRev)
                .HasColumnName("FCAST_AUDIO_VISUAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastBevRev)
                .HasColumnName("FCAST_BEV_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastFoodRev)
                .HasColumnName("FCAST_FOOD_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastGroup1Rev)
                .HasColumnName("FCAST_GROUP1_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastGroup2Rev)
                .HasColumnName("FCAST_GROUP2_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastGroup3Rev)
                .HasColumnName("FCAST_GROUP3_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastGroup4Rev)
                .HasColumnName("FCAST_GROUP4_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastGroup5Rev)
                .HasColumnName("FCAST_GROUP5_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastOtherRev)
                .HasColumnName("FCAST_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcastRentalRev)
                .HasColumnName("FCAST_RENTAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdAudioVisualRev)
                .HasColumnName("GTD_AUDIO_VISUAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdBevRev)
                .HasColumnName("GTD_BEV_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdFoodRev)
                .HasColumnName("GTD_FOOD_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdGroup1Rev)
                .HasColumnName("GTD_GROUP1_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdGroup2Rev)
                .HasColumnName("GTD_GROUP2_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdGroup3Rev)
                .HasColumnName("GTD_GROUP3_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdGroup4Rev)
                .HasColumnName("GTD_GROUP4_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdGroup5Rev)
                .HasColumnName("GTD_GROUP5_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdOtherRev)
                .HasColumnName("GTD_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GtdRentalRev)
                .HasColumnName("GTD_RENTAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfNights)
                .HasColumnName("NO_OF_NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.OffsetAvailRevGross)
                .HasColumnName("OFFSET_AVAIL_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetAvailRevNet)
                .HasColumnName("OFFSET_AVAIL_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetPickupRevGross)
                .HasColumnName("OFFSET_PICKUP_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetPickupRevNet)
                .HasColumnName("OFFSET_PICKUP_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetTotRevGross)
                .HasColumnName("OFFSET_TOT_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetTotRevNet)
                .HasColumnName("OFFSET_TOT_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbAudioVisualRev)
                .HasColumnName("OTB_AUDIO_VISUAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbBevRev)
                .HasColumnName("OTB_BEV_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbFoodRev)
                .HasColumnName("OTB_FOOD_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbGroup1Rev)
                .HasColumnName("OTB_GROUP1_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbGroup2Rev)
                .HasColumnName("OTB_GROUP2_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbGroup3Rev)
                .HasColumnName("OTB_GROUP3_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbGroup4Rev)
                .HasColumnName("OTB_GROUP4_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbGroup5Rev)
                .HasColumnName("OTB_GROUP5_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbOtherRev)
                .HasColumnName("OTB_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRentalRev)
                .HasColumnName("OTB_RENTAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevInactive)
                .HasColumnName("OTHER_REV_INACTIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherTransactionRev)
                .HasColumnName("OTHER_TRANSACTION_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PeakRooms)
                .HasColumnName("PEAK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RelatedResorts)
                .HasColumnName("RELATED_RESORTS")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevBlocked)
                .HasColumnName("REV_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevBlockedNet)
                .HasColumnName("REV_BLOCKED_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevContracted)
                .HasColumnName("REV_CONTRACTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsBlocked)
                .HasColumnName("RMS_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsContracted)
                .HasColumnName("RMS_CONTRACTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsOwners)
                .HasColumnName("RMS_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.TotalComplimentaryRooms)
                .HasColumnName("TOTAL_COMPLIMENTARY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTransactionRev)
                .HasColumnName("TOTAL_TRANSACTION_REV")
                .HasColumnType("NUMBER");
        });
	}
}
