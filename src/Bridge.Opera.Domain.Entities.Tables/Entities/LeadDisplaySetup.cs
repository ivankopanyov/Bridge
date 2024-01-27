namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LeadDisplaySetup
{
    public string Resort { get; set; }
    public string LeadStatus { get; set; }
    public string ContactYn { get; set; }
    public string BusblockYn { get; set; }
    public string RoomnightsYn { get; set; }
    public string RoomgridYn { get; set; }
    public string MeetingagendaYn { get; set; }
    public string BusblockNotesYn { get; set; }
    public string BusblockNoteTypes { get; set; }
    public string LeadNotesYn { get; set; }
    public string LeadNoteTypes { get; set; }
    public string RespondYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string LeadType { get; set; }
    public string AccountYn { get; set; }
    public string AgentYn { get; set; }
    public string AgentContactYn { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LeadDisplaySetup>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.LeadStatus, e.LeadType })
                .HasName("LDS_PK");

            entity.ToTable("LEAD$DISPLAY_SETUP");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LeadStatus)
                .HasColumnName("LEAD_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.LeadType)
                .HasColumnName("LEAD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountYn)
                .HasColumnName("ACCOUNT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentContactYn)
                .HasColumnName("AGENT_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AgentYn)
                .HasColumnName("AGENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusblockNoteTypes)
                .HasColumnName("BUSBLOCK_NOTE_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusblockNotesYn)
                .HasColumnName("BUSBLOCK_NOTES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusblockYn)
                .HasColumnName("BUSBLOCK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContactYn)
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadNoteTypes)
                .HasColumnName("LEAD_NOTE_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LeadNotesYn)
                .HasColumnName("LEAD_NOTES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MeetingagendaYn)
                .HasColumnName("MEETINGAGENDA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RespondYn)
                .HasColumnName("RESPOND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomgridYn)
                .HasColumnName("ROOMGRID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomnightsYn)
                .HasColumnName("ROOMNIGHTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.LeadDisplaySetup)
	                .HasForeignKey(d => d.Resort)
	                .HasConstraintName("LDS_RESORT_FK");
        });
	}
}
