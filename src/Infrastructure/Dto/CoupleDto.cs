namespace Infrastructure.Dto;

public record CoupleDto
{
    public required int TotalScore { get; init; }

    public required string FirstAttendeeName { get; init; }

    public required string FirstAttendeeScores { get; init; }

    public required string SecondAttendeeName { get; init; }

    public required string SecondAttendeeScores { get; init; }
}
