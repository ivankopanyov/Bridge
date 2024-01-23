namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccountInfoView
{
    public decimal NameId { get; set; }
    public DateTime? LastStay { get; set; }
    public decimal? LastRate { get; set; }
    public string LastGroup { get; set; }
    public string LastSource { get; set; }
    public string LastRoom { get; set; }
    public DateTime? NextStay { get; set; }
    public decimal? NextResvnameid { get; set; }
    public decimal? TotalStays { get; set; }
    public decimal? TotalRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccountInfoView>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("ACCOUNT_INFO_VIEW");

				entity.Property(e => e.LastGroup)
					.HasColumnName("LAST_GROUP")
					.IsUnicode(false);

				entity.Property(e => e.LastRate)
					.HasColumnName("LAST_RATE")
					.HasColumnType("NUMBER");

				entity.Property(e => e.LastRoom)
					.HasColumnName("LAST_ROOM")
					.IsUnicode(false);

				entity.Property(e => e.LastSource)
					.HasColumnName("LAST_SOURCE")
					.IsUnicode(false);

				entity.Property(e => e.LastStay)
					.HasColumnName("LAST_STAY")
					.HasColumnType("DATE");

				entity.Property(e => e.NameId)
					.HasColumnName("NAME_ID")
					.HasColumnType("NUMBER");

				entity.Property(e => e.NextResvnameid)
					.HasColumnName("NEXT_RESVNAMEID")
					.HasColumnType("NUMBER");

				entity.Property(e => e.NextStay)
					.HasColumnName("NEXT_STAY")
					.HasColumnType("DATE");

				entity.Property(e => e.TotalRevenue)
					.HasColumnName("TOTAL_REVENUE")
					.HasColumnType("NUMBER");

				entity.Property(e => e.TotalStays)
					.HasColumnName("TOTAL_STAYS")
					.HasColumnType("NUMBER");
			});
	}
}
