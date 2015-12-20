using Junk_Drawer.ViewModels;
using System.Windows.Controls;

namespace Junk_Drawer.Controls
{
    /// <summary>
    /// Interaction logic for GoodIdeasControl.xaml
    /// </summary>
    public partial class GoodIdeasControl : UserControl
    {
        public GoodIdeasControl()
        {
            InitializeComponent();

            this.DataContext = new GoodIdeasViewModel();
        }
    }
}
