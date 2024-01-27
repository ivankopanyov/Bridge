namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSpaceSetup
{
    public decimal? RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public string BusinessDate { get; set; }
    public string SetupCode { get; set; }
    public string Room { get; set; }
    public decimal? OccMin { get; set; }
    public decimal? OccMax { get; set; }
    public byte? SetupTime { get; set; }
    public byte? SetdownTime { get; set; }
    public string SetupCodeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSpaceSetup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SPACE_SETUP");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OccMax)
                .HasColumnName("OCC_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccMin)
                .HasColumnName("OCC_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .IsRequired()
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime).HasColumnName("SETDOWN_TIME");

            entity.Property(e => e.SetupCode)
                .IsRequired()
                .HasColumnName("SETUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetupCodeDesc)
                .HasColumnName("SETUP_CODE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SetupTime).HasColumnName("SETUP_TIME");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");
        });
	}
}
