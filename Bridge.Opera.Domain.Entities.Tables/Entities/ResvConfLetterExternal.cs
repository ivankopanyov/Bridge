namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvConfLetterExternal
{
    public decimal ExternalConfLetterId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string DestinationRole { get; set; }
    public string DestinationType { get; set; }
    public decimal? DestinationId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvConfLetterExternal>(entity =>
        {
            entity.HasKey(e => e.ExternalConfLetterId)
                .HasName("RESV_CLEXT_PK");

            entity.ToTable("RESV_CONF_LETTER_EXTERNAL");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.DestinationId })
                .HasName("RESV_CLEXT_RES_ID_DEST_IDX");

            entity.Property(e => e.ExternalConfLetterId)
                .HasColumnName("EXTERNAL_CONF_LETTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DestinationId)
                .HasColumnName("DESTINATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DestinationRole)
                .HasColumnName("DESTINATION_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DestinationType)
                .HasColumnName("DESTINATION_TYPE")
                .HasMaxLength(20)
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
