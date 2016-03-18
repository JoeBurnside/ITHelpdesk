
Partial Class ManageUsers
    Inherits System.Web.UI.Page
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the management menu
        Response.Redirect("Manager.aspx")
    End Sub
    'this code handles the click event for the technicians button
    Protected Sub btnTechs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTechs.Click
        'redirect to the technician management screen
        Response.Redirect("ManageTechnicians.aspx")
    End Sub
    'this code handles the click event for the staff button
    Protected Sub btnStaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStaff.Click
        'redirect to the staff management screen
        Response.Redirect("ManageStaff.aspx")
    End Sub
End Class
