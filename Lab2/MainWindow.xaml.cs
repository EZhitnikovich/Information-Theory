using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace TI2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncButton_Click(object sender, RoutedEventArgs e)
        {
            FinalText1.Text = MainTextEditor.EncryptText(KeyTextBox.Text, ModuleTextBox.Text, SourceText1.Text);
        }

        private void DecButton_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<char, double> analysed = TextDecryptor.AnalysText(SourceText2.Text);
            FillTable(2, 3, analysed);
            Dictionary<string, string> toRaplace;
            toRaplace = GetCharReplace(2, 4);
            FinalText2.Text = MainTextEditor.ReplaceChars(SourceText2.Text.ToLower(), toRaplace);
        }

        private void analysButton_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<char, double> analysed = TextDecryptor.AnalysText(SourceText2.Text);

            FillTable(2, 3, analysed);
        }

        private void tryHard_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<char, double> analysed = TextDecryptor.AnalysText(SourceText2.Text);
            FillTable(2, 3, analysed);
            Dictionary<string, string> toReplace = GetCharReplace(2, 0);
            FinalText2.Text = MainTextEditor.ReplaceChars(SourceText2.Text.ToLower(), toReplace);

            FillTable(4, toReplace);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = TablePattern.CreateTable(6, 26);
            dataGrid.FontSize = 17;
            dataGrid.Columns[0].Header = "Дано";
            dataGrid.Columns[1].Header = "в %";
            dataGrid.Columns[2].Header = "В тексте";
            dataGrid.Columns[3].Header = "в %";
            dataGrid.Columns[4].Header = "Заменить на";

            FillTable(0, 1, TextDecryptor.FreqTable);
        }

        private Dictionary<string, string> GetCharReplace(int source, int ch)
        {
            Dictionary<string, string> toRaplace = new Dictionary<string, string>();
            foreach (DataRowView item in dataGrid.Items)
            {
                var row = item.Row.ItemArray;
                toRaplace.Add(row[source].ToString(), row[ch].ToString());
            }

            return toRaplace;
        }

        private void FillTable(int pos1, int pos2, Dictionary<char, double> dict)
        {
            int i = 0;

            foreach (var item in dict)
            {
                DataRowView rowView = (dataGrid.Items[i] as DataRowView);
                rowView.BeginEdit();
                rowView[pos1] = item.Key;
                rowView[pos2] = item.Value;
                rowView.EndEdit();
                dataGrid.Items.Refresh();
                i++;
            }
        }

        private void FillTable(int pos, Dictionary<string, string> dict)
        {
            int i = 0;

            foreach (var item in dict)
            {
                DataRowView rowView = (dataGrid.Items[i] as DataRowView);
                rowView.BeginEdit();
                rowView[pos] = item.Value;
                rowView.EndEdit();
                dataGrid.Items.Refresh();
                i++;
            }
        }
    }
}
