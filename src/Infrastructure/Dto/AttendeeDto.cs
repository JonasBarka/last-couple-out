namespace Infrastructure.Dto;

public record AttendeeDto
{
    public int? Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public AttendeeDto(int? id = null, string firstName = "", string lastName = "")
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public void Reset()
    {
        Id = null;
        FirstName = "";
        LastName = "";
    }
}
