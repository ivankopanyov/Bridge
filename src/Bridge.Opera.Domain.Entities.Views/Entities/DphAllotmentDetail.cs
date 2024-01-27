namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphAllotmentDetail
{
    public string DelphiId { get; set; }
    public string AllotmentDate { get; set; }
    public string RoomType { get; set; }
    public string NoRoomsBlocked { get; set; }
    public string SingleRoomsBlock { get; set; }
    public string DoubleRoomsBlock { get; set; }
    public string TripleRoomsBlock { get; set; }
    public string QuadRoomsBlock { get; set; }
    public string SingleRate { get; set; }
    public string DoubleRate { get; set; }
    public string TripleRate { get; set; }
    public string QuadRate { get; set; }
    public string NoRoomsAgreed { get; set; }
    public string SingleRoomsAgreed { get; set; }
    public string DoubleRoomsAgreed { get; set; }
    public string TripleRoomsAgreed { get; set; }
    public string QuadRoomsAgreed { get; set; }
    public string Dummy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphAllotmentDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_ALLOTMENT_DETAIL");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.DelphiId)
                .HasColumnName("DELPHI_ID")
                .HasMaxLength(54)
                .IsUnicode(false);

            entity.Property(e => e.DoubleRate)
                .HasColumnName("DOUBLE_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.DoubleRoomsAgreed)
                .HasColumnName("DOUBLE_ROOMS_AGREED")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.DoubleRoomsBlock)
                .HasColumnName("DOUBLE_ROOMS_BLOCK")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.Dummy)
                .HasColumnName("DUMMY")
                .HasMaxLength(48)
                .IsUnicode(false);

            entity.Property(e => e.NoRoomsAgreed)
                .HasColumnName("NO_ROOMS_AGREED")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.NoRoomsBlocked)
                .HasColumnName("NO_ROOMS_BLOCKED")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.QuadRate)
                .HasColumnName("QUAD_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.QuadRoomsAgreed)
                .HasColumnName("QUAD_ROOMS_AGREED")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.QuadRoomsBlock)
                .HasColumnName("QUAD_ROOMS_BLOCK")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SingleRate)
                .HasColumnName("SINGLE_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.SingleRoomsAgreed)
                .HasColumnName("SINGLE_ROOMS_AGREED")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.SingleRoomsBlock)
                .HasColumnName("SINGLE_ROOMS_BLOCK")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.TripleRate)
                .HasColumnName("TRIPLE_RATE")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.TripleRoomsAgreed)
                .HasColumnName("TRIPLE_ROOMS_AGREED")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.TripleRoomsBlock)
                .HasColumnName("TRIPLE_ROOMS_BLOCK")
                .HasMaxLength(21)
                .IsUnicode(false);
        });
	}
}
