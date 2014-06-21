namespace Version_Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Method |
     AttributeTargets.Class | AttributeTargets.Interface,
    AllowMultiple = false)] // if = true => multiuse attribute

    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version
        {
            get;
            private set;
        }
    }

    [Version("2.11")]
    public class TestAttributeClass
    {
        static void Main()
        {
            Type type = typeof(TestAttributeClass);
            object[] allAttributes = type.GetCustomAttributes(false); // bool inherit
            foreach (VersionAttribute ver in allAttributes)
            {
                Console.WriteLine(ver.Version);
            }
        }
    }
}
