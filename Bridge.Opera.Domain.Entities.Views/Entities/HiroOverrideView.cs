namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HiroOverrideView
{
    public string Resort { get; set; }
    public DateTime? OverrideDate { get; set; }
    public string CharOverrideDate { get; set; }
    public string OverrideTime { get; set; }
    public string ConfirmationNo { get; set; }
    public string ExternalReference { get; set; }
    public DateTime? Arrival { get; set; }
    public string CharArrival { get; set; }
    public string RoomType { get; set; }
    public decimal? Nights { get; set; }
    public string RateCode { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Hurdle { get; set; }
    public string GuestName { get; set; }
    public string Id { get; set; }
    public string OverrideAction { get; set; }
    public string ActionDescription { get; set; }
    public decimal? RateableValue { get; set; }
    public string BlockCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HiroOverrideView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HIRO_OVERRIDE_VIEW");

            entity.Property(e => e.ActionDescription)
                .IsRequired()
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CharArrival)
                .HasColumnName("CHAR_ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CharOverrideDate)
                .HasColumnName("CHAR_OVERRIDE_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.OverrideAction)
                .HasColumnName("OVERRIDE_ACTION")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.OverrideDate)
                .HasColumnName("OVERRIDE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OverrideTime)
                .HasColumnName("OVERRIDE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Rate)
                .HasColumnName("RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateableValue)
                .HasColumnName("RATEABLE_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);
        });
	}
}
