﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControlTemplatesDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void btnEnable_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.chkSample.IsEnabled = true;
		}

		private void btnDisable_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.chkSample.IsEnabled = false;
		}
	}
}