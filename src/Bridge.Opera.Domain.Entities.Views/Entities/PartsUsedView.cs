namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PartsUsedView
{
    public decimal PartsUsedSeqNo { get; set; }
    public string Resort { get; set; }
    public string PartCode { get; set; }
    public string PartDesc { get; set; }
    public decimal WoNumber { get; set; }
    public decimal Qty { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? PartsCost { get; set; }
    public decimal UserId { get; set; }
    public string UserName { get; set; }
    public DateTime PartsUsedDate { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PartsUsedView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PARTS_USED_VIEW");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PartCode)
                .IsRequired()
                .HasColumnName("PART_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartDesc)
                .HasColumnName("PART_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PartsCost)
                .HasColumnName("PARTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartsUsedDate)
                .HasColumnName("PARTS_USED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartsUsedSeqNo)
                .HasColumnName("PARTS_USED_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
