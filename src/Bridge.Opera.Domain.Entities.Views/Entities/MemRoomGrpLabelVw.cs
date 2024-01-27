namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemRoomGrpLabelVw
{
    public string ChainCode { get; set; }
    public string MemRoomGroup { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string Label { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemRoomGrpLabelVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEM_ROOM_GRP_LABEL_VW");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .IsUnicode(false);

            entity.Property(e => e.MemRoomGroup)
                .IsRequired()
                .HasColumnName("MEM_ROOM_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
