namespace Infrastructure.Dto;

public record ScoreDto
{
    public int? Id { get; set; }

    public int? ScorerId { get; set; }

    public int? ScoredId { get; set; }

    public int? Friendship { get; set; }

    public int? Attraction { get; set; }

    public int? Parenting { get; set; }


    public ScoreDto()
    {
    }

    public ScoreDto(int? id, int? scorerId, int? scoredId, int? friendship, int? attraction, int? parenting)
    {
        Id = id;
        ScorerId = scorerId;
        ScoredId = scoredId;
        Friendship = friendship;
        Attraction = attraction;
        Parenting = parenting;
    }

    public void Reset()
    {
        Id = null;
        ScorerId = null;
        ScoredId = null;
        Friendship = null;
        Attraction = null;
        Parenting = null;
    }
}
