using Profile.dtos;

namespace Profile.Interface
{
    public interface IPersonService
    {
     Task<PersonResponse> CreateAsync(PersonRequest personRequest);
    }
}
