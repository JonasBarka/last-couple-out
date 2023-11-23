using Blazored.LocalStorage;
using Infrastructure.Dto;

namespace Infrastructure.Repository;

public interface IScoreRepository
{
    Task<List<ScoreDto>> LoadAsync();

    Task SaveAsync(IEnumerable<ScoreDto> ScoreDto);

    Task ClearAsync();
}


public class ScoreRepository(ILocalStorageService _localStorageService) : IScoreRepository
{
    private const string ScoresKey = "scores";

    public async Task<List<ScoreDto>> LoadAsync()
    {
        return await _localStorageService.GetItemAsync<List<ScoreDto>>(ScoresKey)
                     ?? [];
    }

    public async Task SaveAsync(IEnumerable<ScoreDto> scoreDto)
    {
        await _localStorageService.SetItemAsync(ScoresKey, scoreDto);
    }

    public async Task ClearAsync()
    {
        await _localStorageService.RemoveItemAsync(ScoresKey);
    }
}
