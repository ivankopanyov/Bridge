namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Room
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string Floor { get; set; }
    public string OooYn { get; set; }
    public string VacantYn { get; set; }
    public string CondoInd { get; set; }
    public string ProgramStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Room>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_ROOM");

            entity.Property(e => e.CondoInd)
                .HasColumnName("CONDO_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OooYn)
                .HasColumnName("OOO_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ProgramStatus)
                .HasColumnName("PROGRAM_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VacantYn)
                .HasColumnName("VACANT_YN")
                .IsUnicode(false);
        });
	}
}
