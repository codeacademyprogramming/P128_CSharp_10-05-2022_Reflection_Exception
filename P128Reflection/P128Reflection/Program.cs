using System;
using System.Reflection;

namespace P128Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\hamid.mammadov\Desktop\P124DemoLibrary\P124DemoLibrary\bin\Debug\netcoreapp3.1\P124DemoLibrary.dll");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                //MemberInfo[] memberInfos = type.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

                //foreach (MemberInfo memberInfo in memberInfos)
                //{
                //    Console.WriteLine(memberInfo.Name);
                //}

                MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

                foreach (MethodInfo methodInfo in methodInfos)
                {
                    if (methodInfo.Name == "Info")
                    {
                        ParameterInfo[] parameterInfos = methodInfo.GetParameters();

                        foreach (ParameterInfo parameterInfo in parameterInfos)
                        {
                            Console.WriteLine(parameterInfo.ParameterType);
                        }

                        //var ins = Activator.CreateInstance(type);

                        //object[] paramers = { "" };

                        //object a = methodInfo.Invoke(ins, paramers);

                        //Console.WriteLine(a);
                    }
                }
            }

        }
    }
}
