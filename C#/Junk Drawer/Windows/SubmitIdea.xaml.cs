using Junk_Drawer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Junk_Drawer.Windows
{
    /// <summary>
    /// Interaction logic for SubmitIdea.xaml
    /// </summary>
    public partial class SubmitIdea : Window
    {
        private SubmitViewModel _viewModel;



        public SubmitIdea()
        {
            InitializeComponent();
        }

        public void Initialize(string name){

            _viewModel = new SubmitViewModel(name);
            this.DataContext = _viewModel;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.TrySubmit(can => {

                if (can)
                {
                    ActionService service = ActionService.GetInstance();
                    service.PerformAction(typeof(BadIdeasViewModel));
                    service.PerformAction(typeof(GoodIdeasViewModel));
                    
                    this.Close();
                }
            
            });
        }

       



        
    }
}
