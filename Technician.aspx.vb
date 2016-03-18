
Partial Class Technician
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    'this code handles the click event for the available jobs button
    Protected Sub btnAvailable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAvailable.Click
        Response.Redirect("TechJobs.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the click event for the your jobs button
    Protected Sub btnYour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYour.Click
        'redirect to your jobs page
        Response.Redirect("YourJobs.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the click event for the equipment button
    Protected Sub btnEquipment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEquipment.Click
        'redirect to equipment page
        Response.Redirect("Equipment.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the click event for the logout button
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        'redirect to index
        Response.Redirect("Index.aspx")
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the technicianid from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
    End Sub
End Class
