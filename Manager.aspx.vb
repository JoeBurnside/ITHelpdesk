
Partial Class Manager
    Inherits System.Web.UI.Page
    'this code handles the click event for the logout button
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        'redirect back to the index page
        Response.Redirect("Index.aspx")
    End Sub
    'This code handles the click event for the Manage Jobs button
    Protected Sub btnJobs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJobs.Click
        'redirect to the manage jobs page
        Response.Redirect("ManageJobs.aspx")
    End Sub
    'This code handles the click event for the Manage Users button
    Protected Sub btnUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        'redirect to the manage jobs page
        Response.Redirect("ManageUsers.aspx")
    End Sub
    'This code handles the click event for the reports button
    Protected Sub btnReports_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReports.Click
        'redirect to the reports page
        Response.Redirect("Reports.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
