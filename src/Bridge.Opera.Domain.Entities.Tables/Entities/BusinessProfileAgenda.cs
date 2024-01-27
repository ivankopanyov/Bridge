namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BusinessProfileAgenda
{
    public decimal AgendaId { get; set; }
    public decimal ProfileId { get; set; }
    public string AgendaName { get; set; }
    public string EvType { get; set; }
    public decimal? AgendaDay { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? FbaBudget { get; set; }
    public decimal? BudgetPerUnit { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public string RoomType { get; set; }
    public string RoomSetup { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }

    public virtual BusinessProfile Profile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileAgenda>(entity =>
        {
            entity.HasKey(e => e.AgendaId)
                .HasName("BPA_PK");

            entity.ToTable("BUSINESS$PROFILE_AGENDA");

            entity.HasIndex(e => e.ProfileId)
                .HasName("BPA_BP_FKI");

            entity.Property(e => e.AgendaId)
                .HasColumnName("AGENDA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgendaDay)
                .HasColumnName("AGENDA_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgendaName)
                .IsRequired()
                .HasColumnName("AGENDA_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetPerUnit)
                .HasColumnName("BUDGET_PER_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FbaBudget)
                .HasColumnName("FBA_BUDGET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(BusinessProfile)))
				entity.Ignore(e => e.Profile);
			else
	            entity.HasOne(d => d.Profile)
	                .WithMany(p => p.BusinessProfileAgenda)
	                .HasForeignKey(d => d.ProfileId)
	                .HasConstraintName("BPA_BP_FK");
        });
	}
}
