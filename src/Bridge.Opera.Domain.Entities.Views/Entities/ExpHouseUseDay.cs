namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpHouseUseDay
{
    public DateTime? BusinessDate { get; set; }
    public string? GuestLastName { get; set; }
    public string? Room { get; set; }
    public decimal? Sequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpHouseUseDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_HOUSE_USE_DAY");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
