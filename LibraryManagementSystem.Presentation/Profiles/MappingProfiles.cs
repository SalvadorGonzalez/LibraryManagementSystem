using AutoMapper;
using LibraryManagementSystem.Application.Models;
using LibraryManagementSystem.Presentation.Models;

namespace LibraryManagementSystem.Presentation.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<BookModel, BookViewModel>();
        }
    }
}
