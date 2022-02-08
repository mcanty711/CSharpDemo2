<Window x:Class="WPF_Intro.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WPF_Intro"
        mc:Ignorable="d"
        Title="MainWindow" Height="350" Width="525">
    <!-- XAML - Extensible Application Markup Language -->
    
    <Grid>
        <Button>
            <Button.Width>200</Button.Width>
            <Button.Height>100</Button.Height>
            <Button.FontSize>24</Button.FontSize>
            <Button.Content>
                <WrapPanel>
                    <TextBlock Foreground="Blue"> Multi</TextBlock>
                    <TextBlock Foreground ="Red">Color</TextBlock>
                    <TextBlock Foreground="Green">Button</TextBlock>
                </WrapPanel>
            </Button.Content>
        </Button>

    </Grid>
    
</Window>

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Intro //code behind for the XAML code above
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 26;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            wrapPanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button";
            txt.Foreground = Brushes.Green;
            wrapPanel.Children.Add(txt);

            btn.Content = wrapPanel;
            grid.Children.Add(btn);


        }
    }
}
