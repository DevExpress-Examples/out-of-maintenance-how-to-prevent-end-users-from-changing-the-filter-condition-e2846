<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_CancelFilterChange/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_CancelFilterChange/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_CancelFilterChange/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_CancelFilterChange/Default.aspx.vb))
<!-- default file list end -->
# How to prevent end-users from changing the filter condition
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2846/)**
<!-- run online end -->


<p>The following example shows how to prevent end-users from changing the filter condition.</p><p>In this example, the FieldFilterChanging event is handled to prevent an end-user from hiding the 'Beverages' field value. If an end-user tries to hide the 'Beverages' field value, the event handler sets the event parameter's Cancel property to true to cancel changing the filter condition.<br />
</p>

<br/>


