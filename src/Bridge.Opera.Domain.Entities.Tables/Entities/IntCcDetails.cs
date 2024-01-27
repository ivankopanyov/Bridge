namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntCcDetails
{
    public decimal CcdSeqNo { get; set; }
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string ConversionCode { get; set; }
    public string PmsValue { get; set; }
    public string ExtValue { get; set; }
    public string PmsDefaultYn { get; set; }
    public string CrsDefaultYn { get; set; }
    public string ActiveYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string MasterValue { get; set; }

    public virtual IntInterfaceSetup IntInterfaceSetup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntCcDetails>(entity =>
        {
            entity.HasKey(e => e.CcdSeqNo)
                .HasName("INT_ICD_PK");

            entity.ToTable("INT_CC_DETAILS");

            entity.HasIndex(e => e.ConversionCode)
                .HasName("INT_CC_DETAILS_IND2");

            entity.HasIndex(e => new { e.InterfaceId, e.ConversionCode, e.ExtValue })
                .HasName("INT_CC_DETAILS_EXT");

            entity.HasIndex(e => new { e.InterfaceId, e.ConversionCode, e.PmsValue })
                .HasName("INT_CC_DETAILS_PMS");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.ConversionCode, e.PmsValue })
                .HasName("INT_CC_DETAILS_IND");

            entity.Property(e => e.CcdSeqNo)
                .HasColumnName("CCD_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConversionCode)
                .IsRequired()
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CrsDefaultYn)
                .HasColumnName("CRS_DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExtValue)
                .HasColumnName("EXT_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MasterValue)
                .HasColumnName("MASTER_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PmsDefaultYn)
                .HasColumnName("PMS_DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PmsValue)
                .HasColumnName("PMS_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(IntInterfaceSetup)))
				entity.Ignore(e => e.IntInterfaceSetup);
			else
	            entity.HasOne(d => d.IntInterfaceSetup)
	                .WithMany(p => p.IntCcDetails)
	                .HasForeignKey(d => new { d.InterfaceId, d.Resort })
	                .HasConstraintName("INT_ICD_INT_IC_FK");
        });
	}
}
