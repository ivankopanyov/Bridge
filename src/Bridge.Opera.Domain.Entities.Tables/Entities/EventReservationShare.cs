namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventReservationShare
{
    public string Resort { get; set; }
    public decimal EvResIdLink { get; set; }
    public decimal ResvId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Attendees { get; set; }

    public virtual EventReservation EventReservation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventReservationShare>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.EvResIdLink })
                .HasName("RS_PK");

            entity.ToTable("EVENT$RESERVATION_SHARE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EvResIdLink)
                .HasColumnName("EV_RES_ID_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvId)
                .HasColumnName("RESV_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(EventReservation)))
				entity.Ignore(e => e.EventReservation);
			else
	            entity.HasOne(d => d.EventReservation)
	                .WithOne(p => p.EventReservationShare)
	                .HasForeignKey<EventReservationShare>(d => new { d.Resort, d.EvResIdLink })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RS_ER_FK");
        });
	}
}
