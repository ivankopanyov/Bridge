namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiXmlLoadLogVw
{
    public decimal? XmlLoadid { get; set; }
    public decimal? XmlRecordid { get; set; }
    public DateTime? XmlDate { get; set; }
    public string XmlAw { get; set; }
    public string XmlMessage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiXmlLoadLogVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_XML_LOAD_LOG_VW");

            entity.Property(e => e.XmlAw)
                .HasColumnName("XML_AW")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XmlDate)
                .HasColumnName("XML_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.XmlLoadid)
                .HasColumnName("XML_LOADID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XmlMessage)
                .HasColumnName("XML_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.XmlRecordid)
                .HasColumnName("XML_RECORDID")
                .HasColumnType("NUMBER");
        });
	}
}
