using Junk_Drawer.ViewModels;
using System.Windows.Controls;

namespace Junk_Drawer.Controls
{
    /// <summary>
    /// Interaction logic for BadIdeasControl.xaml
    /// </summary>
    public partial class BadIdeasControl : UserControl
    {
        public BadIdeasControl()
        {
            InitializeComponent();
            this.DataContext = new BadIdeasViewModel();
        }
    }
}
