namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPsRevcntrBase
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RvcKeyId { get; set; }
    public string RevCenter { get; set; }
    public string Resort { get; set; }
    public string RevCenterDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? NumOfTables { get; set; }
    public decimal? AutoSvcCharge { get; set; }
    public string MasterRevCenter { get; set; }
    public string MasterRevcntrId { get; set; }
    public string MasterRevcntrDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPsRevcntrBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PS_REVCNTR_BASE");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AutoSvcCharge)
                .HasColumnName("AUTO_SVC_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

            entity.Property(e => e.RvcKeyId)
                .HasColumnName("RVC_KEY_ID")
                .HasMaxLength(41)
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
