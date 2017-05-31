using Abp.Web.Mvc.Views;

namespace PxAbp.Web.Views
{
    public abstract class PxAbpWebViewPageBase : PxAbpWebViewPageBase<dynamic>
    {

    }

    public abstract class PxAbpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PxAbpWebViewPageBase()
        {
            LocalizationSourceName = PxAbpConsts.LocalizationSourceName;
        }
    }
}