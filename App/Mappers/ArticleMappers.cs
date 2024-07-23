using AutoMapper;
using ContentManagementSystem.App.GlobalDTOs;
using ContentManagementSystem.Controllers.Article.DTOs;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.App.Mappers
{
    public class ArticleMappers : Profile
    {
        public ArticleMappers()
        {

            CreateMap<Article, ArticleSearchDTO>()
                .ForMember(x => x.Author, opt => opt.MapFrom((src, dest) =>
                {
                    if (src.Author == null)
                        return default;
                    return IdTitlePair<int>.Create(src.Author.Id, src.Author.Username);
                }))
                .ForMember(x => x.Abbr, opt => opt.MapFrom((src, dest) =>
                {
                    if (string.IsNullOrWhiteSpace(src.Content))
                        return string.Empty;

                    var length = src.Content.Length;
                    if (length > 100)
                        return src.Content.Substring(0, 100);
                        else
                        return src.Content.Substring(0);


                }));
        }
    }
}
