namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsAvailabilityVw
{
    public string Resort { get; set; }
    public DateTime? RecordDate { get; set; }
    public string Code1 { get; set; }
    public decimal? Value1 { get; set; }
    public string Code2 { get; set; }
    public decimal? Value2 { get; set; }
    public string Code3 { get; set; }
    public decimal? Value3 { get; set; }
    public decimal? OrderSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAvailabilityVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_AVAILABILITY_VW");

            entity.Property(e => e.Code1)
                .HasColumnName("CODE1")
                .HasMaxLength(31)
                .IsUnicode(false);

            entity.Property(e => e.Code2)
                .HasColumnName("CODE2")
                .HasMaxLength(27)
                .IsUnicode(false);

            entity.Property(e => e.Code3)
                .HasColumnName("CODE3")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.OrderSeq)
                .HasColumnName("ORDER_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Value1)
                .HasColumnName("VALUE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Value2)
                .HasColumnName("VALUE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Value3)
                .HasColumnName("VALUE3")
                .HasColumnType("NUMBER");
        });
	}
}
