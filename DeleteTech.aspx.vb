
Partial Class DeleteTech
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the manage technicians page
        Response.Redirect("ManageTechnicians.aspx")
    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'call the delete function
        Call DeleteTech(TechnicianID)
        'display a confirmation message
        lblConfirm.Text = "Record Deleted. Click Back to continue."
    End Sub
    'this function deletes a technician
    Function DeleteTech(ByVal TechnicianID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Techs As New DataConnection
        'add a parameter for use in the query
        Techs.AddParameter("@technicianid", TechnicianID)
        'execute the query
        Techs.Execute("sp_DeleteTechnician")
        'return a positive value
        Return True
    End Function
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'get the technicianid from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        'display a confirmation message
        lblConfirm.Text = "Are you sure you wish to delete record number " & TechnicianID & "?"
    End Sub
End Class
