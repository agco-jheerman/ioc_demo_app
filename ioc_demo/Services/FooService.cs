using System;

namespace ioc_demo
{
    public class FooService: IFooService
    {
        public FooService() 
        {
        }
        
        public string GetFoo() 
        {
            return "Foo! Foo!";
        }
    }
}
