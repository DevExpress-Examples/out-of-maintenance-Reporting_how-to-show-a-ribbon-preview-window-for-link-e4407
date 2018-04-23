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

Namespace RibbonPrintPreviewDemo
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			InitializeComponent()
		End Sub

		Shared Sub New()
			BarManager.CheckBarItemNames = False
		End Sub

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim link As New SimpleLink(CType(Resources("rowTemplate"), DataTemplate), 1000)
			CType(preview.Model, LinkPreviewModel).Link = link
			link.CreateDocument(True)
		End Sub
	End Class
End Namespace
