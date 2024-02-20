namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoutingInstructions
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? ToResvNameId { get; set; }
    public string? FromText { get; set; }
    public string? ToText { get; set; }
    public string? RoutingType { get; set; }
    public decimal? BillToNameId { get; set; }
    public string? Comments { get; set; }
    public string? RoutingDecode { get; set; }
    public decimal? FolioView { get; set; }
    public string? RoomName { get; set; }
    public string? FromRoomName { get; set; }
    public string? AddressName { get; set; }
    public string? DateRange { get; set; }
    public string? BillingInstrnCode { get; set; }
    public string? FromText2 { get; set; }
    public string? ToText2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoutingInstructions>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROUTING_INSTRUCTIONS");

            entity.Property(e => e.AddressName)
                .HasColumnName("ADDRESS_NAME")
                .IsUnicode(false);

            entity.Property(e => e.BillToNameId)
                .HasColumnName("BILL_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingInstrnCode)
                .HasColumnName("BILLING_INSTRN_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DateRange)
                .HasColumnName("DATE_RANGE")
                .HasMaxLength(154)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromRoomName)
                .HasColumnName("FROM_ROOM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FromText)
                .HasColumnName("FROM_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.FromText2)
                .HasColumnName("FROM_TEXT2")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomName)
                .HasColumnName("ROOM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.RoutingDecode)
                .HasColumnName("ROUTING_DECODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RoutingType)
                .HasColumnName("ROUTING_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ToResvNameId)
                .HasColumnName("TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToText)
                .HasColumnName("TO_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.ToText2)
                .HasColumnName("TO_TEXT2")
                .IsUnicode(false);
        });
	}
}
