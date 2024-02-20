namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FbAgendaResource
{
    public decimal? FbaId { get; set; }
    public string? ResourceCode { get; set; }
    public string? ResourceName { get; set; }
    public decimal? Quantity { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual FbAgenda Fba { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FbAgendaResource>(entity =>
        {
            entity.HasKey(e => new { e.FbaId, e.ResourceCode })
                .HasName("FBARES_PK");

            entity.ToTable("FB$AGENDA_RESOURCE");

            entity.Property(e => e.FbaId)
                .HasColumnName("FBA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceCode)
                .HasColumnName("RESOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceName)
                .IsRequired()
                .HasColumnName("RESOURCE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(FbAgenda)))
				entity.Ignore(e => e.Fba);
			else
	            entity.HasOne(d => d.Fba)
	                .WithMany(p => p.FbAgendaResource)
	                .HasForeignKey(d => d.FbaId)
	                .HasConstraintName("FBARES_FBA_FK");
        });
	}
}
