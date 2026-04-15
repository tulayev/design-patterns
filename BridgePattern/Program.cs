using Autofac;
using BridgePattern;

// The Bridge design pattern is a structural pattern that decouples an abstraction (high-level logic) from its implementation (low-level platform-specific code)
// so that the two can vary independently.
Console.WriteLine("The Bridge design pattern is a structural pattern that decouples an abstraction (high-level logic) from its implementation (low-level platform-specific code) " +
    "so that the two can vary independently.\r\n");

var containerBuilder = new ContainerBuilder();

containerBuilder.RegisterType<RasterRenderer>().As<IRenderer>().SingleInstance();
containerBuilder.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

using var container = containerBuilder.Build();

var circle = container.Resolve<Circle>(new PositionalParameter(0, 5.0f));

circle.Draw();
circle.Resize(2.0f);
circle.Draw();
