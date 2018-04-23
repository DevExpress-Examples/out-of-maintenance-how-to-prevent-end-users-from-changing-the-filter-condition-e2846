using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;

namespace ASPxPivotGrid_CancelFilterChange {
    public partial class _Default : Page {
        protected void ASPxPivotGrid1_FieldFilterChanging(object sender, 
                                    PivotFieldFilterChangingEventArgs e) {
            if (Equals(e.Field, fieldCategoryName)) {
                if ((e.Field.FilterValues.FilterType == PivotFilterType.Excluded &&
                        e.Values.Contains("Beverages")) ||
                    (e.Field.FilterValues.FilterType == PivotFilterType.Included &&
                        !e.Values.Contains("Beverages"))) {
                    e.Cancel = true;
                }
            }
        }
    }
}
