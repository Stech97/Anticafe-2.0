using DBRepository.Logger;
using System;
using System.Windows;

namespace Anticafe
{
    public partial class SmenaEnd : Window
    {
        private static readonly ILog _log = LogManager.CreateLogger("Desktop", "trace");
        public SmenaEnd() =>  InitializeComponent();

        private void BEnd_Click(object sender, RoutedEventArgs e)
        {
            _log.Trace("Смена закрыта");
            _log.Trace("Приложение закрыто с кодом 0");
            _log.Trace("Exit");
            Environment.Exit(0);
        }
    }
}
