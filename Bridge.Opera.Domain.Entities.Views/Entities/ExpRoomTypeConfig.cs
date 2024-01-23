namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpRoomTypeConfig
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string Label { get; set; }
    public string RoomClass { get; set; }
    public string ShortDescription { get; set; }
    public string RoomClassDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpRoomTypeConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ROOM_TYPE_CONFIG");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .IsRequired()
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDescription)
                .HasColumnName("ROOM_CLASS_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");
        });
	}
}
