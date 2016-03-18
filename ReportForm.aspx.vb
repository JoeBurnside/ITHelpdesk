
Partial Class ReportForm
    Inherits System.Web.UI.Page

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("Reports.aspx")
    End Sub
End Class
