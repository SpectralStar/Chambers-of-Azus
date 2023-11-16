using Chambers_of_Azus;
using Terminal.Gui;

Application.Init();

try {
    Application.Run(new ChambersOfAzusView());
}
finally {
    Application.Shutdown();
}