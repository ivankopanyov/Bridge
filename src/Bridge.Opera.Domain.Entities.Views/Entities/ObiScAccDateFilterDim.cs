namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScAccDateFilterDim
{
    public string LevelId { get; set; }
    public string KeyId { get; set; }
    public DateTime? DStayDate { get; set; }
    public decimal? DStayMonth { get; set; }
    public decimal? DStayYear { get; set; }
    public string CStayDate { get; set; }
    public string CStayMonth { get; set; }
    public string CStayYear { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScAccDateFilterDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_ACC_DATE_FILTER_DIM");

            entity.Property(e => e.CStayDate)
                .HasColumnName("C_STAY_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CStayMonth)
                .HasColumnName("C_STAY_MONTH")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CStayYear)
                .HasColumnName("C_STAY_YEAR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.DStayDate)
                .HasColumnName("D_STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DStayMonth)
                .HasColumnName("D_STAY_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DStayYear)
                .HasColumnName("D_STAY_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyId)
                .HasColumnName("KEY_ID")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.LevelId)
                .HasColumnName("LEVEL_ID")
                .HasColumnType("CHAR(1)");
        });
	}
}
