namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TmpReservationPersonList
{
    public decimal? ResvNameId { get; set; }
    public string? SessionId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TmpReservationPersonList>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TMP_RESERVATION_PERSON_LIST");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
