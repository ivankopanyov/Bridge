namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookedActivitiesVw
{
    public decimal BookedActId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string ActCode { get; set; }
    public decimal? TrxNo { get; set; }
    public string Status { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string PriceCode { get; set; }
    public decimal Price { get; set; }
    public DateTime? CancelDate { get; set; }
    public string ActDesc { get; set; }
    public string ActType { get; set; }
    public string PostOnEvent { get; set; }
    public string ActLongDesc { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string DisplayName { get; set; }
    public string Sname { get; set; }
    public string Sfirst { get; set; }
    public decimal? NoOfPeople { get; set; }
    public string PriceColor { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public decimal? Balance { get; set; }
    public string LmRoomCategory { get; set; }
    public string LmRoomLabel { get; set; }
    public string IsResvLmYn { get; set; }
    public string ConfirmationNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedActivitiesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOKED_ACTIVITIES_VW");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActDesc)
                .IsRequired()
                .HasColumnName("ACT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActLongDesc)
                .HasColumnName("ACT_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ActType)
                .IsRequired()
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsResvLmYn)
                .HasColumnName("IS_RESV_LM_YN")
                .IsUnicode(false);

            entity.Property(e => e.LmRoomCategory)
                .HasColumnName("LM_ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.LmRoomLabel)
                .HasColumnName("LM_ROOM_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfPeople)
                .HasColumnName("NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostOnEvent)
                .HasColumnName("POST_ON_EVENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriceColor)
                .HasColumnName("PRICE_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
