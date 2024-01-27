namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRoomOwnerDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string Resort { get; set; }
    public string SrepCode { get; set; }
    public decimal? NameId { get; set; }
    public string FullName { get; set; }
    public string SrepTitle { get; set; }
    public string SrepPhone { get; set; }
    public string SrepEmail { get; set; }
    public string SrepFax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRoomOwnerDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ROOM_OWNER_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SrepEmail)
                .HasColumnName("SREP_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.SrepFax)
                .HasColumnName("SREP_FAX")
                .IsUnicode(false);

            entity.Property(e => e.SrepPhone)
                .HasColumnName("SREP_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.SrepTitle)
                .HasColumnName("SREP_TITLE")
                .IsUnicode(false);
        });
	}
}
