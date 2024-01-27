namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrsResvNameAudit
{
    public decimal ActionInstanceId { get; set; }
    public decimal DmlSeqNo { get; set; }
    public string IudFlag { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string OldResort { get; set; }
    public string NewResort { get; set; }
    public DateTime? OldArrival { get; set; }
    public DateTime? NewArrival { get; set; }
    public decimal? OldNights { get; set; }
    public decimal? NewNights { get; set; }
    public DateTime? OldCancelDate { get; set; }
    public DateTime? NewCancelDate { get; set; }
    public decimal? OldRooms { get; set; }
    public decimal? NewRooms { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ConfirmationNo { get; set; }
    public string OldRateCode { get; set; }
    public string NewRateCode { get; set; }
    public decimal? OldRate { get; set; }
    public decimal? NewRate { get; set; }
    public string ShareLabel { get; set; }
    public string OldOriginOfBooking { get; set; }
    public string NewOriginOfBooking { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsResvNameAudit>(entity =>
        {
            entity.HasKey(e => new { e.ActionInstanceId, e.DmlSeqNo, e.IudFlag, e.Resort, e.ResvNameId })
                .HasName("ORS_RESV_NAME_AUDIT_PK");

            entity.ToTable("ORS_RESV_NAME_AUDIT");

            entity.HasIndex(e => e.ConfirmationNo)
                .HasName("ORS_RESV_NAME_AUDIT_IDX3");

            entity.HasIndex(e => new { e.InsertDate, e.Resort })
                .HasName("ORS_RESV_NAME_AUDIT_IDX2");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.ActionInstanceId })
                .HasName("ORS_RESV_NAME_AUDIT_IDX1");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IudFlag)
                .HasColumnName("IUD_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewArrival)
                .HasColumnName("NEW_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.NewCancelDate)
                .HasColumnName("NEW_CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NewNights)
                .HasColumnName("NEW_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewOriginOfBooking)
                .HasColumnName("NEW_ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewRate)
                .HasColumnName("NEW_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewRateCode)
                .HasColumnName("NEW_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewResort)
                .HasColumnName("NEW_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewRooms)
                .HasColumnName("NEW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldArrival)
                .HasColumnName("OLD_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.OldCancelDate)
                .HasColumnName("OLD_CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OldNights)
                .HasColumnName("OLD_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldOriginOfBooking)
                .HasColumnName("OLD_ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldRate)
                .HasColumnName("OLD_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldRateCode)
                .HasColumnName("OLD_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldResort)
                .HasColumnName("OLD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldRooms)
                .HasColumnName("OLD_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareLabel)
                .HasColumnName("SHARE_LABEL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
