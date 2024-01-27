namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoomStatusSumm
{
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public string Label { get; set; }
    public decimal? ClOcc { get; set; }
    public decimal? DiOcc { get; set; }
    public decimal? ClVac { get; set; }
    public decimal? DiVac { get; set; }
    public decimal? OoVac { get; set; }
    public decimal? OsVac { get; set; }
    public decimal? Arr { get; set; }
    public decimal? Darr { get; set; }
    public decimal? Dep { get; set; }
    public decimal? Ddep { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoomStatusSumm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROOM_STATUS_SUMM");

            entity.Property(e => e.Arr)
                .HasColumnName("ARR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClOcc)
                .HasColumnName("CL_OCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClVac)
                .HasColumnName("CL_VAC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Darr)
                .HasColumnName("DARR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ddep)
                .HasColumnName("DDEP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dep)
                .HasColumnName("DEP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiOcc)
                .HasColumnName("DI_OCC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiVac)
                .HasColumnName("DI_VAC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OoVac)
                .HasColumnName("OO_VAC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsVac)
                .HasColumnName("OS_VAC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
