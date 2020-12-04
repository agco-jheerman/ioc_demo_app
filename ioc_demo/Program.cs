using System;
using Microsoft.Extensions.DependencyInjection;

namespace ioc_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ServiceCollection();
            container.AddScoped<IFooService, FooService>();
            container.AddScoped<DemoApp>();

            var provider = container.BuildServiceProvider(); 
            var app = provider.GetService<DemoApp>();

            app.Run();
        }
    }

    class DemoApp
    {
        private readonly IFooService _fooService;

        public DemoApp (IFooService fooService)
        {
            _fooService = fooService;
        }

        public void Run()
        {
            Console.WriteLine("Running the demo app! Now, let's print some foo");

            var foo = _fooService.GetFoo();
            Console.WriteLine(foo);
        }
    }
}
