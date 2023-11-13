using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CriaFolhetoOferta
{
    internal static class ExibirInformacoes
    {
        public static void Exibir(MemberInfo[] members, string title)
        {
            Console.WriteLine(title);

            foreach (var item in members)
            {
                if (item is ConstructorInfo constructorInfo)
                {
                    var parametros = constructorInfo.GetParameters();
                    Console.WriteLine($"Construtor - Número de Parametros: {parametros.Count()} - {constructorInfo.IsPublic}");
                    foreach (var param in parametros)
                    {
                        Console.WriteLine($"{param.Name}, {param.ParameterType}, {param.DefaultValue}");
                    }
                }

                if (item is PropertyInfo propertyInfo)
                    Console.WriteLine($"Propriedade - Nome: {propertyInfo.Name} -  Member Type: {propertyInfo.MemberType} - Property Type: {propertyInfo.PropertyType}");
            }
        }
    }
}
