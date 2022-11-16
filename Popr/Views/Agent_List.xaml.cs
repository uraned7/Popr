
using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace Popr
{
    /// <summary>
    /// Логика взаимодействия для Agent_List.xaml
    /// </summary>
    public partial class Agent_List : Window
    {
        private Agent _currentAgent = new Agent();
        public Agent_List()
        {
            InitializeComponent();

            try
            {
                var allTypes = popr2Entities.GetContext().AgentType.ToList();
                allTypes.Insert(0, new AgentType
                {
                    Title = "Все типы"
                });

                ComboFiltration.ItemsSource = allTypes;
                ComboFiltration.SelectedIndex = 0;

                var currentAgent = popr2Entities.GetContext().Agent.ToList();
                LVAgents.ItemsSource = currentAgent;
                DataContext = _currentAgent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UpdateAgents()
        {
            var currentAgent = popr2Entities.GetContext().Agent.ToList();

            //if (ComboFiltration.SelectedIndex > 0)
            //    currentAgent = currentAgent.Where(p => p.Title.Contains(ComboFiltration.SelectedItem as AgentType)).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TBoxSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void ComboSort_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
