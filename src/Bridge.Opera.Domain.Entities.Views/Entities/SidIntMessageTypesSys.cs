namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIntMessageTypesSys
{
    public string? MessageType { get; set; }
    public string? DataMartYn { get; set; }
    public string? MaintainOrderYn { get; set; }
    public decimal? Priority { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIntMessageTypesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INT_MESSAGE_TYPES_SYS");

            entity.Property(e => e.DataMartYn)
                .IsRequired()
                .HasColumnName("DATA_MART_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaintainOrderYn)
                .IsRequired()
                .HasColumnName("MAINTAIN_ORDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .IsRequired()
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
