using Blazored.LocalStorage;
using Infrastructure.Dto;

namespace Infrastructure.Repository;

public interface IAttendeeRepository
{
    Task<List<AttendeeDto>> LoadAsync();

    Task SaveAsync(IEnumerable<AttendeeDto> attendeeDto);

    Task ClearAsync();
}


public class AttendeeRepository(ILocalStorageService _localStorageService) : IAttendeeRepository
{
    private const string AttendeesKey = "attendees";

    public async Task<List<AttendeeDto>> LoadAsync()
    {
        return await _localStorageService.GetItemAsync<List<AttendeeDto>>(AttendeesKey)
                     ?? [];
    }

    public async Task SaveAsync(IEnumerable<AttendeeDto> attendeeDto)
    {
        await _localStorageService.SetItemAsync(AttendeesKey, attendeeDto);
    }

    public async Task ClearAsync()
    {
        await _localStorageService.RemoveItemAsync(AttendeesKey);
    }
}
