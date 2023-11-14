using Volo.Abp.AspNetCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Security;

namespace AbpTools
{
    [DependsOn(typeof(AbpSecurityModule), typeof(AbpAspNetCoreModule), typeof(AbpAutofacModule))]
    public class AbpToolsModule : AbpModule
    {
    }
}
