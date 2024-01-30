namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPdChannelDimVw
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? ChannelCode { get; set; }
    public string? ChannelDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ResortId { get; set; }
    public string? ChannelCodeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPdChannelDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PD_CHANNEL_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ChannelCodeKey)
                .HasColumnName("CHANNEL_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ChannelDesc)
                .HasColumnName("CHANNEL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
