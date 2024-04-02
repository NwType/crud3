namespace Crud3.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new PedidoVista.PedidoListarVista());

            Application.Run(new ClienteVista.ClienteListarVista());
            //Application.Run(new PedidoVista.PedidoInsertarVista());
            //Application.Run(new PedidoVista.PedidoListarVista());

        }
    }
}