
Partial Class StaffViewJob
    Inherits System.Web.UI.Page
    Dim StaffID As Integer
    Dim RequestID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to view requests
        Response.Redirect("ViewRequests.aspx?StaffID=" & StaffID)
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve data from previous page
        StaffID = Request.QueryString("StaffID")
        RequestID = Request.QueryString("RequestID")
        'call the viewjob function
        Call ViewJob(RequestID)
    End Sub
    'this function retrieves data from the database and fills the labels provided
    Function ViewJob(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Request As New DataConnection
        'declare variables to store the data
        Dim Forename, Surname, FullName As String
        'add parameter for use in the query
        Request.AddParameter("@requestid", RequestID)
        'execute the query
        Request.Execute("sp_SelectDetails")
        'check the query returns one result
        If Request.Count = 1 Then
            'retrieve data from the database and insert into labels provided
            lblMachine.Text = "Machine: " & Request.QueryResults.Rows(0)(0)
            lblLocation.Text = "Location: " & Request.QueryResults.Rows(0)(1)
            lblDaterequested.Text = "Date Requested: " & Request.QueryResults.Rows(0)(2)
            Forename = Request.QueryResults.Rows(0)(3)
            Surname = Request.QueryResults.Rows(0)(4)
            FullName = Forename & " " & Surname
            lblTechnician.Text = "Technician: " & FullName
            lblStatus.Text = "Status: " & Request.QueryResults.Rows(0)(5)
            lblAction.Text = "Action: " & Request.QueryResults.Rows(0)(6)
            lblDatecompleted.Text = "Date Completed: " & Request.QueryResults.Rows(0)(7)
            'return positive value
            Return True
        Else
            'return negative value
            Return False
        End If
    End Function
End Class
