namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvCustomizeConfLetter
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal ResvConfLetterId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public byte[] ConfLetter { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvCustomizeConfLetter>(entity =>
        {
            entity.HasKey(e => e.ResvConfLetterId)
                .HasName("RESV_CUSTOMIZE_CONF_LETTER_PK");

            entity.ToTable("RESV_CUSTOMIZE_CONF_LETTER");

            entity.Property(e => e.ResvConfLetterId)
                .HasColumnName("RESV_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfLetter)
                .HasColumnName("CONF_LETTER")
                .HasColumnType("BLOB");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
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
