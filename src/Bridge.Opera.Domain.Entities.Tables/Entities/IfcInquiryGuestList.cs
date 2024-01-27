namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcInquiryGuestList
{
    public decimal IfcCtrlId { get; set; }
    public string Workstation { get; set; }
    public string PostInformation { get; set; }
    public decimal? ListNum { get; set; }
    public string AcctType { get; set; }
    public decimal? GuestNum { get; set; }
    public string RoomNum { get; set; }
    public string LineNum { get; set; }
    public string Guestname { get; set; }
    public string Guestfirstname { get; set; }
    public string Track2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcInquiryGuestList>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_INQUIRY_GUEST_LIST");

            entity.HasIndex(e => new { e.IfcCtrlId, e.Workstation, e.PostInformation })
                .HasName("IFC_INQGSTLST_IDX");

            entity.Property(e => e.AcctType)
                .HasColumnName("ACCT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestNum)
                .HasColumnName("GUEST_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guestfirstname)
                .HasColumnName("GUESTFIRSTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Guestname)
                .HasColumnName("GUESTNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LineNum)
                .HasColumnName("LINE_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ListNum)
                .HasColumnName("LIST_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostInformation)
                .HasColumnName("POST_INFORMATION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RoomNum)
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Track2)
                .HasColumnName("TRACK2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Workstation)
                .HasColumnName("WORKSTATION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
