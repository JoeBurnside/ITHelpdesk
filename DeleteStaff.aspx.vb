
Partial Class DeleteStaff
    Inherits System.Web.UI.Page
    Dim StaffID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the manage staff page
        Response.Redirect("ManageStaff.aspx")
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the staffid from the previous page
        StaffID = Request.QueryString("StaffID")
        'display a confirmation message
        lblConfirm.Text = "Are you sure you wish to delete record number " & StaffID & "?"
    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'call delete function
        Call DeleteStaff(StaffID)
        'display a confirmation message
        lblConfirm.Text = "Record Deleted. Click Back to continue."
    End Sub
    'this function deletes a staff record
    Function DeleteStaff(ByVal StaffID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Staff As New DataConnection
        'add a parameter for use in the query
        Staff.AddParameter("@staffid", StaffID)
        'execute the query
        Staff.Execute("sp_DeleteStaff")
        'return a positive value
        Return True
    End Function
End Class
