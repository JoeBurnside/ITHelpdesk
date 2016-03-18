
Partial Class DeleteJob
    Inherits System.Web.UI.Page
    Dim RequestID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the managers menu
        Response.Redirect("ManageJobs.aspx")
    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'call delete job function
        Call DeleteJob(RequestID)
        'call the delete job function
        Call DeleteRequest(RequestID)
        'display a confirmation message
        lblConfirm.Text = "Request Deleted. Click Back to continue."
    End Sub
    'this code handels the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'get the request id from the previous page
        RequestID = Request.QueryString("RequestID")
        'display a confirmation message
        lblConfirm.Text = "Are you sure you wish to delete Request " & RequestID & "?"
    End Sub
    'this function will delete a job from the jobs table
    Function DeleteJob(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Jobs As New DataConnection
        'add a parameter for use in the query
        Jobs.AddParameter("@requestid", RequestID)
        'execut the query
        Jobs.Execute("sp_DeleteJob")
        'return a positive value
        Return True
    End Function
    'this function will delete a request from the request table
    Function DeleteRequest(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'add a parameter for use in the query
        Requests.AddParameter("@requestid", RequestID)
        'execute the query
        Requests.Execute("sp_DeleteRequest")
        'return a positive value
        Return True
    End Function
End Class
