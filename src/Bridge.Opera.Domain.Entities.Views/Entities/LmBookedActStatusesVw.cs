namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookedActStatusesVw
{
    public string? BookedActStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedActStatusesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOKED_ACT_STATUSES_VW");

            entity.Property(e => e.BookedActStatus)
                .HasColumnName("BOOKED_ACT_STATUS")
                .IsUnicode(false);
        });
	}
}
