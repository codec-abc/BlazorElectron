using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorRedux;
using FSharpLib;

namespace SampleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddReduxStore<MyState, MyMsg>(
                new MyState("", 0, null), 
                MyFuncs.MyReducer, 
                options =>
                {
                    options.LocationReducer = MyFuncs.LocationReducer;
                    options.GetLocation = state => state.Location;
                    options.StateSerializer = MyFuncs.StateSerializer;
                    options.StateDeserializer = MyFuncs.StateDeserializer;
}               );
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
