using Blazored.LocalStorage;
using Infrastructure.Dto;

namespace Infrastructure.Repository;

public interface IAttendeeRepository
{
    Task<List<AttendeeDto>> LoadAsync();

    Task SaveAsync(IEnumerable<AttendeeDto> attendeeDto);
}


public class AttendeeRepository(ILocalStorageService _localStorageService) : IAttendeeRepository
{
    private const string AttendeeIdentifier = "attendee";

    public async Task<List<AttendeeDto>> LoadAsync()
    {
        return await _localStorageService.GetItemAsync<List<AttendeeDto>>(AttendeeIdentifier)
                     ?? [];
    }

    public async Task SaveAsync(IEnumerable<AttendeeDto> attendeeDto)
    {
        await _localStorageService.SetItemAsync(AttendeeIdentifier, attendeeDto);
    }
}
