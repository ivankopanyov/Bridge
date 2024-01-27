namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LaborUsedView
{
    public decimal LaborUsedSeqNo { get; set; }
    public string Resort { get; set; }
    public decimal UserId { get; set; }
    public string UserName { get; set; }
    public decimal WoNumber { get; set; }
    public decimal DurationWorked { get; set; }
    public string UotCode { get; set; }
    public string UotDesc { get; set; }
    public decimal? HourlyRate { get; set; }
    public decimal? LaborCost { get; set; }
    public DateTime LaborUsedDate { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaborUsedView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LABOR_USED_VIEW");

            entity.Property(e => e.DurationWorked)
                .HasColumnName("DURATION_WORKED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HourlyRate)
                .HasColumnName("HOURLY_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LaborCost)
                .HasColumnName("LABOR_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LaborUsedDate)
                .HasColumnName("LABOR_USED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LaborUsedSeqNo)
                .HasColumnName("LABOR_USED_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UotCode)
                .IsRequired()
                .HasColumnName("UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UotDesc)
                .HasColumnName("UOT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
