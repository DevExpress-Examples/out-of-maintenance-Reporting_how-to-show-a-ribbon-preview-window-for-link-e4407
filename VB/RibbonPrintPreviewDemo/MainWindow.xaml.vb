Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core

Namespace RibbonPrintPreviewDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXWindow
		Public Sub New()
			InitializeComponent()
		End Sub

		'static MainWindow() {
		'    BarManager.CheckBarItemNames = false;
		'}

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link As New SimpleLink(CType(Resources("rowTemplate"), DataTemplate), 1000)
			Dim model As New LinkPreviewModel()
			model.Link = link
			viewer.Model = model
			link.CreateDocument(True)
		End Sub
	End Class
End Namespace
