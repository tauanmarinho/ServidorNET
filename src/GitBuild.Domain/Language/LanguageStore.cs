using GitBuild.Domain;
using GitBuild.Domain.Dtos;
using GitBuild.Domain.Language;

namespace LanguageStore.Domain.language
{
    public class LanguageStore
    {

        private readonly IRepository<Language> _languageRepository;
        
        public LanguageStore(IRepository<Language> languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public void Store(LanguageDto dto)
        {
            var language = _languageRepository.GetById(dto.Id);
            if (language == null)
            {
                language = new Language( dto.Id, dto.Name);
                _languageRepository.Save(language);
            }
            else
            {
                language.Update(dto.Id,dto.Name);
            }
        }
    }
}