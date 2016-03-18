
Partial Class Staff
    Inherits System.Web.UI.Page
    Dim StaffID As Integer
    'this code handles the click event for the log fault button
    Protected Sub btnLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLog.Click
        'redirect to log fault page
        Response.Redirect("LogFault.aspx?StaffID=" & StaffID)
    End Sub
    'this button handles the click event for the view requests button
    Protected Sub btnRequests_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRequests.Click
        'redirect to requests page
        Response.Redirect("ViewRequests.aspx?StaffID=" & StaffID)
    End Sub
    'this code handles the click event for the change details button
    Protected Sub btnChange_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChange.Click
        'redirect to edit details page
        Response.Redirect("StaffEdit.aspx?StaffID=" & StaffID)
    End Sub
    'this code handles the click event for the logout button
    Protected Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        'redirect to index
        Response.Redirect("Index.aspx")
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve staffid from previous page
        StaffID = Request.QueryString("StaffID")
    End Sub
End Class
