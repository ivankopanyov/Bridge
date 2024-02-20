namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrxClasses1
{
    public string? Resort { get; set; }
    public string? TclCode { get; set; }
    public string? TctType { get; set; }
    public string? Description { get; set; }
    public string? Class1MandatoryYn { get; set; }
    public string? Class2MandatoryYn { get; set; }
    public string? ResultIncludedInSumArray { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxClasses1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRX_CLASSES");

            entity.Property(e => e.Class1MandatoryYn)
                .HasColumnName("CLASS_1_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Class2MandatoryYn)
                .HasColumnName("CLASS_2_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResultIncludedInSumArray)
                .HasColumnName("RESULT_INCLUDED_IN_SUM_ARRAY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TclCode)
                .IsRequired()
                .HasColumnName("TCL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TctType)
                .IsRequired()
                .HasColumnName("TCT_TYPE")
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
