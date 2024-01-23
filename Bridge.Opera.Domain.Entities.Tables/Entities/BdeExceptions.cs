namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BdeExceptions
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string ErrorMsg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BdeExceptions>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BDE_EXCEPTIONS");

            entity.Property(e => e.ErrorMsg)
                .HasColumnName("ERROR_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
