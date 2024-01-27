namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpMappingCodesToLink
{
    public string ConfigType { get; set; }
    public string Resort { get; set; }
    public string LinkedCode { get; set; }
    public string LinkedDesc { get; set; }
    public decimal? SeqNo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMappingCodesToLink>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_MAPPING_CODES_TO_LINK");

            entity.Property(e => e.ConfigType)
                .HasColumnName("CONFIG_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkedCode)
                .HasColumnName("LINKED_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LinkedDesc)
                .HasColumnName("LINKED_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
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
