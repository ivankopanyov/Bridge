namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RequestSendMethods
{
    public string? SendMethod { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RequestSendMethods>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REQUEST_SEND_METHODS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.SendMethod)
                .HasColumnName("SEND_METHOD")
                .HasMaxLength(5)
                .IsUnicode(false);
        });
	}
}
