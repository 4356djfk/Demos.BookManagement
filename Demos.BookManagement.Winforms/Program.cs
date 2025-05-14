using System;
using System.Windows.Forms;
using Autofac;
using Demos.BookManagement.IRepository;
using Demos.BookManagement.MsSqlRepository;

namespace Demos.BookManagement.Winforms
{
    static class Program
    {
        /// <summary>
        /// Ioc容器
        /// </summary>
        private static IContainer _container;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateContainer();
            SetDataDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = _container.Resolve<FrmBookManage>();
            Application.Run(form);
        }

        /// <summary>
        /// 初始化Autofac容器
        /// </summary>
        private static void CreateContainer()
        {
            //容器构造器
            var builder = new ContainerBuilder();
            //读取配置文件
            // var config = new ConfigurationSettingsReader("autofac");
            //配置文件注册组件，但是不支持Aop拦截，
            // builder.RegisterModule(config);

            //只能采用代码注册Aop拦截
            //builder.RegisterType<ProvinceRepository>()
            //    .As<IProvinceRepository>()
            //    .EnableInterfaceInterceptors()
            //    .InterceptedBy(typeof(RepositoryInterceptor));
            builder.RegisterType<BookRepository>()
                .As<IBookRepository>();

            //注册拦截器对象
            //builder.Register(c => new RepositoryInterceptor());

            //注册窗体，允许属性注入
            //只有用容器获取窗体，才会属性注入
            builder.RegisterType<FrmBookManage>().PropertiesAutowired();

            //创建容器
            _container = builder.Build();
        }
        /// <summary>
        /// 设置数据文件的存取路径
        /// </summary>
        private static void SetDataDirectory()
        {
            var dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\")
            || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName + "\\App_Data";
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }
        }
    }
}
