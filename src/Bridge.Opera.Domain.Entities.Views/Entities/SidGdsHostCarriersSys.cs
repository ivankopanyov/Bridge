namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidGdsHostCarriersSys
{
    public string? GdsHost { get; set; }
    public string? GdsCarrier { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? SgaYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidGdsHostCarriersSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_GDS_HOST_CARRIERS_SYS");

            entity.Property(e => e.GdsCarrier)
                .IsRequired()
                .HasColumnName("GDS_CARRIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SgaYn)
                .HasColumnName("SGA_YN")
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
