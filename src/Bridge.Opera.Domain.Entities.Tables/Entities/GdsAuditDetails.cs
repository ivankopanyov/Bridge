namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAuditDetails
{
    public string? GdsMessageNo { get; set; }
    public string? MessageType { get; set; }
    public string? MessageSwitch { get; set; }
    public string? ChannelName { get; set; }
    public string? GdsProperty { get; set; }
    public string? GdsRateCode { get; set; }
    public string? GdsRoomCategory { get; set; }
    public string? Corpacctnos { get; set; }
    public string? Creditcardinfo { get; set; }
    public string? Specialrequest { get; set; }
    public string? Guestinfo { get; set; }
    public DateTime? Arrivaldate { get; set; }
    public DateTime? Departuredate { get; set; }
    public string? EventStatus { get; set; }
    public string? Eventdescription { get; set; }
    public string? Errormessage { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? TransactionDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAuditDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_AUDIT_DETAILS");

            entity.HasIndex(e => e.TransactionDate)
                .HasName("GDS_AUDIT_DETAILS_IND1");

            entity.Property(e => e.Arrivaldate)
                .HasColumnName("ARRIVALDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChannelName)
                .IsRequired()
                .HasColumnName("CHANNEL_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Corpacctnos)
                .HasColumnName("CORPACCTNOS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Creditcardinfo)
                .HasColumnName("CREDITCARDINFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Departuredate)
                .HasColumnName("DEPARTUREDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Errormessage)
                .HasColumnName("ERRORMESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Eventdescription)
                .HasColumnName("EVENTDESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.GdsMessageNo)
                .HasColumnName("GDS_MESSAGE_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GdsProperty)
                .IsRequired()
                .HasColumnName("GDS_PROPERTY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCode)
                .IsRequired()
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Guestinfo)
                .HasColumnName("GUESTINFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageSwitch)
                .HasColumnName("MESSAGE_SWITCH")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .IsRequired()
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Specialrequest)
                .HasColumnName("SPECIALREQUEST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");
        });
	}
}
