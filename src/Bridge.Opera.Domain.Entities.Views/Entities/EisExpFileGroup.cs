namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisExpFileGroup
{
    public string? FileGroupId { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisExpFileGroup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_EXP_FILE_GROUP");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FileGroupId)
                .IsRequired()
                .HasColumnName("FILE_GROUP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
