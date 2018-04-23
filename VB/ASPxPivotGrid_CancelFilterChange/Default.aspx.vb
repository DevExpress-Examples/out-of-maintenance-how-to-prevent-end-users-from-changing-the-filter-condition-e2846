Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace ASPxPivotGrid_CancelFilterChange
	Partial Public Class _Default
		Inherits Page
		Protected Sub ASPxPivotGrid1_FieldFilterChanging(ByVal sender As Object, _
				ByVal e As PivotFieldFilterChangingEventArgs)
			If Equals(e.Field, fieldCategoryName) Then
				If (e.Field.FilterValues.FilterType = PivotFilterType.Excluded AndAlso _
						e.Values.Contains("Beverages")) OrElse _
					(e.Field.FilterValues.FilterType = PivotFilterType.Included AndAlso _
						(Not e.Values.Contains("Beverages"))) Then
					e.Cancel = True
				End If
			End If
		End Sub
	End Class
End Namespace
