namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailServerView
{
    public decimal? Seq { get; set; }
    public string Id { get; set; }
    public string Changekey { get; set; }
    public string Subject { get; set; }
    public string Toname { get; set; }
    public string Toemailaddress { get; set; }
    public string Ccname { get; set; }
    public string Ccemailaddress { get; set; }
    public string Fromemailaddress { get; set; }
    public decimal? Esize { get; set; }
    public string Sensitivity { get; set; }
    public string Bodytype { get; set; }
    public string Body { get; set; }
    public DateTime? Datetimesent { get; set; }
    public DateTime? Datetimecreated { get; set; }
    public string Forwarditem { get; set; }
    public string Hasattachments { get; set; }
    public string Isreadreceiptrequested { get; set; }
    public string Isread { get; set; }
    public string Forwarditemx { get; set; }
    public string Hasattachmentsx { get; set; }
    public string Isreadreceiptrequestedx { get; set; }
    public string Isreadx { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailServerView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAIL_SERVER_VIEW");

            entity.Property(e => e.Body)
                .HasColumnName("BODY")
                .HasColumnType("CLOB");

            entity.Property(e => e.Bodytype)
                .HasColumnName("BODYTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Ccemailaddress)
                .HasColumnName("CCEMAILADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Ccname)
                .HasColumnName("CCNAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Changekey)
                .HasColumnName("CHANGEKEY")
                .IsUnicode(false);

            entity.Property(e => e.Datetimecreated)
                .HasColumnName("DATETIMECREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.Datetimesent)
                .HasColumnName("DATETIMESENT")
                .HasColumnType("DATE");

            entity.Property(e => e.Esize)
                .HasColumnName("ESIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Forwarditem)
                .HasColumnName("FORWARDITEM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Forwarditemx)
                .HasColumnName("FORWARDITEMX")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Fromemailaddress)
                .HasColumnName("FROMEMAILADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Hasattachments)
                .HasColumnName("HASATTACHMENTS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Hasattachmentsx)
                .HasColumnName("HASATTACHMENTSX")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .IsUnicode(false);

            entity.Property(e => e.Isread)
                .HasColumnName("ISREAD")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Isreadreceiptrequested)
                .HasColumnName("ISREADRECEIPTREQUESTED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Isreadreceiptrequestedx)
                .HasColumnName("ISREADRECEIPTREQUESTEDX")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Isreadx)
                .HasColumnName("ISREADX")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sensitivity)
                .HasColumnName("SENSITIVITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Subject)
                .HasColumnName("SUBJECT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Toemailaddress)
                .HasColumnName("TOEMAILADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Toname)
                .HasColumnName("TONAME")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
