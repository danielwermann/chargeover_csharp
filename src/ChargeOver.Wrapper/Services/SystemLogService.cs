using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class SystemLogService : BaseService, ISystemLogService
	{
		public SystemLogService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public SystemLogService()
		{
		}

		/// <summary>
		/// Retrieve the system log
		/// details: https://developer.chargeover.com/apidocs/rest/#list-syslog
		/// </summary>
		public IResponse<Log> RetrieveTheSystemLog()
		{
			return GetList<Log>("_log_system");
		}
	}
}
