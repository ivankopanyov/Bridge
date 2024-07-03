namespace Bridge.HostApi.Models;

public class TaskName : IComparable<TaskName>
{
    public string Id { get; set; }

    public DateTime DateTime { get; set; } = DateTime.Now;

    public override int GetHashCode() => HashCode.Combine(Id);

    public override bool Equals(object? obj) => obj is TaskName other && Id == other.Id;

    public int CompareTo(TaskName? other) => DateTime.CompareTo(other?.DateTime);
}
