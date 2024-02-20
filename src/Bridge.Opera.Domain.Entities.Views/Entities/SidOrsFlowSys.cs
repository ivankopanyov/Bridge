namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOrsFlowSys
{
    public string? CroCode { get; set; }
    public string? Screen { get; set; }
    public string? DisplayYn { get; set; }
    public decimal? Sequence { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ConfigMode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOrsFlowSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ORS_FLOW_SYS");

            entity.Property(e => e.ConfigMode)
                .IsRequired()
                .HasColumnName("CONFIG_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroCode)
                .IsRequired()
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplayYn)
                .HasColumnName("DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Screen)
                .IsRequired()
                .HasColumnName("SCREEN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
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
