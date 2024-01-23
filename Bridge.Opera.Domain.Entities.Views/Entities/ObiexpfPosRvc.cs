namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpfPosRvc
{
    public string RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string Resort { get; set; }
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RvcKeyId { get; set; }
    public string RevCenter { get; set; }
    public string RevCenterDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? NumOfTables { get; set; }
    public decimal? AutoSvcCharge { get; set; }
    public string MasterRevCenter { get; set; }
    public string MasterRevcntrId { get; set; }
    public string MasterRevcntrDesc { get; set; }
    public string ResortId { get; set; }
    public string AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpfPosRvc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPF_POS_RVC");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.AutoSvcCharge)
                .HasColumnName("AUTO_SVC_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterRevCenter)
                .HasColumnName("MASTER_REV_CENTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterRevcntrDesc)
                .HasColumnName("MASTER_REVCNTR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MasterRevcntrId)
                .HasColumnName("MASTER_REVCNTR_ID")
                .IsUnicode(false);

            entity.Property(e => e.NumOfTables)
                .HasColumnName("NUM_OF_TABLES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevCenter)
                .IsRequired()
                .HasColumnName("REV_CENTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevCenterDesc)
                .IsRequired()
                .HasColumnName("REV_CENTER_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.RvcKeyId)
                .HasColumnName("RVC_KEY_ID")
                .HasMaxLength(41)
                .IsUnicode(false);
        });
	}
}
