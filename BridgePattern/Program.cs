using Autofac;
using BridgePattern;

Console.WriteLine("The Bridge design pattern is a structural pattern that decouples an abstraction (high-level logic) from its implementation (low-level platform-specific code) " +
    "so that the two can vary independently.\r\n" +
    "Structure:\r\n" +
    "The pattern consists of four key components:\r\n" +
    "Abstraction: A high-level interface that defines the control logic. It maintains a reference to an object of the Implementer type.\r\n" +
    "Refined Abstraction: An extension of the Abstraction that provides more specific variants of the high-level logic.\r\n" +
    "Implementer: An interface common to all concrete implementations. It typically defines primitive operations that the Abstraction uses to perform its tasks.\r\n" +
    "Concrete Implementations: Specific classes that implement the Implementer interface.\r\n");

var containerBuilder = new ContainerBuilder();

containerBuilder.RegisterType<RasterRenderer>().As<IRenderer>().SingleInstance();
containerBuilder.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

using var container = containerBuilder.Build();

var circle = container.Resolve<Circle>(new PositionalParameter(0, 5.0f));

circle.Draw();
circle.Resize(2.0f);
circle.Draw();
