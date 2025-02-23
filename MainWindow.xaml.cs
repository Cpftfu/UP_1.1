﻿using System;
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

namespace UP_1._1
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MagazineEntities context = new MagazineEntities();

		public MainWindow()
		{
			InitializeComponent();			
		}

		private void forFirstGrid_Click(object sender, RoutedEventArgs e)
		{
			first_frame.Content = new FirstGrid();
		}

		private void forSecondGrid_Click(object sender, RoutedEventArgs e)
		{
			second_frame.Content = new SecondGrid();
		}

		private void forThirdGrid_Click(object sender, RoutedEventArgs e)
		{
			third_frame.Content = new ThirdGrid();
		}
	}
}
