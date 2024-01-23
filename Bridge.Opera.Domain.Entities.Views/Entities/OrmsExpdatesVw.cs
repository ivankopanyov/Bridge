namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsExpdatesVw
{
    public decimal Seq { get; set; }
    public DateTime? ExpDate { get; set; }
    public string DateDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsExpdatesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_EXPDATES_VW");

            entity.Property(e => e.DateDesc)
                .HasColumnName("DATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ExpDate)
                .HasColumnName("EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
