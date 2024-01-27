namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StayRecordHistory
{
    public decimal StayRecordId { get; set; }
    public decimal? StayRecordExternalId { get; set; }
    public string ExternalPropertyCode { get; set; }
    public string ExternalPropertyName { get; set; }
    public string PmsResvNo { get; set; }
    public string RecordType { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? BookDate { get; set; }
    public string ShareNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public decimal? CancelledRoomNights { get; set; }
    public decimal? NoshowRoomNights { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string CrsBookNo { get; set; }
    public string RoomLabel { get; set; }
    public string RoomNumber { get; set; }
    public decimal GuestNameId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? TravelNameId { get; set; }
    public decimal? WholesalerNameId { get; set; }
    public decimal? GroupNameId { get; set; }
    public decimal? MiscNameId { get; set; }
    public string AllotmentCode { get; set; }
    public string PmsResvNameId { get; set; }
    public string PosCode { get; set; }
    public string PseudoYn { get; set; }
    public string RateCode { get; set; }
    public string ExternalSystemCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual Name GuestName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StayRecordHistory>(entity =>
        {
            entity.HasKey(e => e.StayRecordId)
                .HasName("STAY_RECORD_HISTORY_PK");

            entity.ToTable("STAY_RECORD_HISTORY");

            entity.HasIndex(e => e.GuestNameId)
                .HasName("STAY_RECORD_HISTORY_NAME_FKI");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookDate)
                .HasColumnName("BOOK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelledRoomNights)
                .HasColumnName("CANCELLED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalPropertyCode)
                .HasColumnName("EXTERNAL_PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalPropertyName)
                .HasColumnName("EXTERNAL_PROPERTY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExternalSystemCode)
                .HasColumnName("EXTERNAL_SYSTEM_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GroupNameId)
                .HasColumnName("GROUP_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscNameId)
                .HasColumnName("MISC_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowRoomNights)
                .HasColumnName("NOSHOW_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsResvNameId)
                .HasColumnName("PMS_RESV_NAME_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PosCode)
                .HasColumnName("POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShareNo)
                .HasColumnName("SHARE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayRecordExternalId)
                .HasColumnName("STAY_RECORD_EXTERNAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelNameId)
                .HasColumnName("TRAVEL_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WholesalerNameId)
                .HasColumnName("WHOLESALER_NAME_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.GuestName);
			else
	            entity.HasOne(d => d.GuestName)
	                .WithMany(p => p.StayRecordHistory)
	                .HasForeignKey(d => d.GuestNameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAY_RECORD_HISTORY_NAME_FK");
        });
	}
}
