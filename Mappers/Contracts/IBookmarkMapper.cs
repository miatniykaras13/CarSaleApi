using Models.DTO;
using Models.Models;

namespace Mappers.Contracts;

public interface IBookmarkMapper
{
    Bookmark MapToBookmark(BookmarkDto bookmarkDto);
    BookmarkDto MapToBookmarkDto(Bookmark bookmark);
}