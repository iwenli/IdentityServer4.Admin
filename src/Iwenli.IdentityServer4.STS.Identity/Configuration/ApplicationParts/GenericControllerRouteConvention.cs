using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Iwenli.IdentityServer4.STS.Identity.Configuration.ApplicationParts
{
    public class GenericControllerRouteConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType)
            {
                // 由于某些控制器具有通用参数，因此需要进行此更改
                // 并要求通过解析来消除类型中的arity
                // 以及删除字符串末尾的“控制器”
                
                var name = controller.ControllerType.Name;
                var nameWithoutArity = name.Substring(0, name.IndexOf('`'));
                controller.ControllerName = nameWithoutArity.Substring(0, nameWithoutArity.LastIndexOf("Controller"));
            }
        }
    }
}





