using Volo.Abp.Modularity;
using Volo.Abp.Security;

namespace AbpTools
{
    [DependsOn(typeof(AbpSecurityModule))]
    public class AbpToolsModule : AbpModule
    {
    }
}
