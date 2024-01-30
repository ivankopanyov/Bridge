namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestMessages
{
    public GuestMessages()
    {
        GuestRsvMessages = new HashSet<GuestRsvMessages>();
    }

    public decimal? Msgid { get; set; }
    public DateTime? MsgDate { get; set; }
    public string? Operator { get; set; }
    public string? MessageType { get; set; }
    public string? MessageText { get; set; }

    public virtual ICollection<GuestRsvMessages> GuestRsvMessages { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestMessages>(entity =>
        {
            entity.HasKey(e => e.Msgid)
                .HasName("GUEST_MESSAGES_PK");

            entity.ToTable("GUEST_MESSAGES");

            entity.Property(e => e.Msgid)
                .HasColumnName("MSGID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MessageText)
                .IsRequired()
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.MsgDate)
                .HasColumnName("MSG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Operator)
                .HasColumnName("OPERATOR")
                .HasMaxLength(40)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(GuestRsvMessages)))
				entity.Ignore(e => e.GuestRsvMessages);
		});
	}
}
