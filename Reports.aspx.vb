
Partial Class Reports
    Inherits System.Web.UI.Page

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("Manager.aspx")
    End Sub

    Protected Sub btnStaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStaff.Click
        Response.Redirect("ReportForm.aspx")
    End Sub

    Protected Sub btnTech_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTech.Click
        Response.Redirect("ReportForm.aspx")
    End Sub

    Protected Sub btnStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStatus.Click
        Response.Redirect("ReportForm.aspx")
    End Sub

    Protected Sub btnEquipment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEquipment.Click
        Response.Redirect("ReportForm.aspx")
    End Sub
End Class
