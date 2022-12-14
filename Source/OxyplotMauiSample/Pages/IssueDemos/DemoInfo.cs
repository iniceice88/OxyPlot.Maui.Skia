namespace OxyplotMauiSample
{
    using System;
    using System.Reflection;

    public class DemoInfo
    {
        private readonly DemoPageAttribute dpa;
        private readonly Type type;

        public DemoInfo(Type type)
        {
            this.type = type;
            this.dpa = type.GetTypeInfo().GetCustomAttribute<DemoPageAttribute>();
        }

        public Page CreatePage()
        {
            return (Page)Activator.CreateInstance(this.type);
        }

        public string Title => this.dpa.Title;

        public string Details => this.dpa.Details;
    }
}