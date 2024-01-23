namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcRoomStatus
{
    public string Resort { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public string Suiteroom { get; set; }
    public string Room { get; set; }
    public string Extn { get; set; }
    public decimal? ResvNameId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string VideoCoYn { get; set; }
    public string XlatId { get; set; }
    public string Type { get; set; }
    public string Mask { get; set; }
    public string Status { get; set; }
    public string CosRight { get; set; }
    public string MsgRight { get; set; }
    public string DndRight { get; set; }
    public string MinibarRight { get; set; }
    public string VideoRight { get; set; }
    public string TvRight { get; set; }
    public string GameRight { get; set; }
    public string WebRight { get; set; }
    public string PhoneDisplayNameYn { get; set; }
    public string SharedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcRoomStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_ROOM_STATUS");

            entity.Property(e => e.CosRight)
                .HasColumnName("COS_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.DndRight)
                .HasColumnName("DND_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.Extn)
                .HasColumnName("EXTN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GameRight)
                .HasColumnName("GAME_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Mask)
                .HasColumnName("MASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinibarRight)
                .HasColumnName("MINIBAR_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.MsgRight)
                .HasColumnName("MSG_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.PhoneDisplayNameYn)
                .HasColumnName("PHONE_DISPLAY_NAME_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Suiteroom)
                .HasColumnName("SUITEROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TvRight)
                .HasColumnName("TV_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VideoCoYn)
                .HasColumnName("VIDEO_CO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VideoRight)
                .HasColumnName("VIDEO_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.WebRight)
                .HasColumnName("WEB_RIGHT")
                .IsUnicode(false);

            entity.Property(e => e.XlatId)
                .HasColumnName("XLAT_ID")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
