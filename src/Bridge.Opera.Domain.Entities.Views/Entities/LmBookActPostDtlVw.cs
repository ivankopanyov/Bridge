namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookActPostDtlVw
{
    public decimal? BookedActId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookedElId { get; set; }
    public string? ResId { get; set; }
    public string? ResDesc { get; set; }
    public string? ResType { get; set; }
    public string? ResLongDesc { get; set; }
    public decimal? NameId { get; set; }
    public string? ResName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookActPostDtlVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOK_ACT_POST_DTL_VW");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedElId)
                .HasColumnName("BOOKED_EL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDesc)
                .IsRequired()
                .HasColumnName("RES_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResId)
                .IsRequired()
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResLongDesc)
                .HasColumnName("RES_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResName)
                .HasColumnName("RES_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .IsRequired()
                .HasColumnName("RES_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
