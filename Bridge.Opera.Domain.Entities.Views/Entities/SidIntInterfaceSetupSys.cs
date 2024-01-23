namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntInterfaceSetupSys
{
    public string InterfaceId { get; set; }
    public string IntDescription { get; set; }
    public string PmsResort { get; set; }
    public string ExternalResort { get; set; }
    public string ActiveYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? ImageId { get; set; }
    public string InterfaceType { get; set; }
    public string DeltachangesYn { get; set; }
    public string MessageFormat { get; set; }
    public string ColumnDeleteIndicator { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string ChainCode { get; set; }
    public string DeleteCharInd { get; set; }
    public decimal? DeleteNumberInd { get; set; }
    public DateTime? DeleteDateInd { get; set; }
    public string KeepingCharInd { get; set; }
    public decimal? KeepingNumberInd { get; set; }
    public DateTime? KeepingDateInd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntInterfaceSetupSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_INTERFACE_SETUP_SYS");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ColumnDeleteIndicator)
                .HasColumnName("COLUMN_DELETE_INDICATOR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeleteCharInd)
                .HasColumnName("DELETE_CHAR_IND")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeleteDateInd)
                .HasColumnName("DELETE_DATE_IND")
                .HasColumnType("DATE");

            entity.Property(e => e.DeleteNumberInd)
                .HasColumnName("DELETE_NUMBER_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeltachangesYn)
                .HasColumnName("DELTACHANGES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExternalResort)
                .IsRequired()
                .HasColumnName("EXTERNAL_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImageId)
                .HasColumnName("IMAGE_ID")
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

            entity.Property(e => e.IntDescription)
                .HasColumnName("INT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceType)
                .HasColumnName("INTERFACE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.KeepingCharInd)
                .HasColumnName("KEEPING_CHAR_IND")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.KeepingDateInd)
                .HasColumnName("KEEPING_DATE_IND")
                .HasColumnType("DATE");

            entity.Property(e => e.KeepingNumberInd)
                .HasColumnName("KEEPING_NUMBER_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageFormat)
                .HasColumnName("MESSAGE_FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PmsResort)
                .IsRequired()
                .HasColumnName("PMS_RESORT")
                .HasMaxLength(20)
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
