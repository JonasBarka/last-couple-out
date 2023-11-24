namespace Infrastructure.Dto;

public record CoupleDto
{
    public required int CoupleScore { get; init; }

    public required int FirstAttendeeId { get; init; }

    public required string FirstAttendeeName { get; init; }

    public required string FirstAttendeeScores { get; init; }

    public required int SecondAttendeeId { get; init; }

    public required string SecondAttendeeName { get; init; }

    public required string SecondAttendeeScores { get; init; }
}
