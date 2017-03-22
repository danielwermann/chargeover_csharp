using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class LanguagesService : BaseService, ILanguagesService
	{
		public LanguagesService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public LanguagesService()
		{
		}

		/// <summary>
		/// List languages
		/// details: https://developer.chargeover.com/apidocs/rest/#list-language
		/// </summary>
		public IResponse<Language> ListLanguages()
		{
			return GetList<Language>("/language");
		}
	}
}
