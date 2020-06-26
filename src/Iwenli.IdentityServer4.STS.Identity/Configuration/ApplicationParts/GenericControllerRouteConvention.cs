using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Iwenli.IdentityServer4.STS.Identity.Configuration.ApplicationParts
{
    public class GenericControllerRouteConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType)
            {
                // ����ĳЩ����������ͨ�ò����������Ҫ���д˸���
                // ��Ҫ��ͨ�����������������е�arity
                // �Լ�ɾ���ַ���ĩβ�ġ���������
                
                var name = controller.ControllerType.Name;
                var nameWithoutArity = name.Substring(0, name.IndexOf('`'));
                controller.ControllerName = nameWithoutArity.Substring(0, nameWithoutArity.LastIndexOf("Controller"));
            }
        }
    }
}





