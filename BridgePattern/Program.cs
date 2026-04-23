using Autofac;
using BridgePattern;


var containerBuilder = new ContainerBuilder();

containerBuilder.RegisterType<RasterRenderer>().As<IRenderer>().SingleInstance();
containerBuilder.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

using var container = containerBuilder.Build();

var circle = container.Resolve<Circle>(new PositionalParameter(0, 5.0f));

circle.Draw();
circle.Resize(2.0f);
circle.Draw();
