
Partial Class TechViewJob
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    Dim RequestID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the technician menu
        Response.Redirect("TechJobs.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the data from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        RequestID = Request.QueryString("RequestID")
        'call the displayrequest function
        Call DisplayRequest(RequestID)
    End Sub
    'this function displays the request details in the labels provided
    Function DisplayRequest(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'declare variables to store the data
        Dim Forename, Surname, FullName As String
        'add a parameter for use in the query
        Requests.AddParameter("@requestid", RequestID)
        'execute the query
        Requests.Execute("sp_SelectRequest")
        'check that there is only one record
        If Requests.Count = 1 Then
            'retrieve data from the database and place into labels
            lblEquipment.Text = "Equipment Number: " & Requests.QueryResults.Rows(0)(0)
            lblLocation.Text = "Location: " & Requests.QueryResults.Rows(0)(1)
            Forename = Requests.QueryResults.Rows(0)(2)
            Surname = Requests.QueryResults.Rows(0)(3)
            FullName = Forename & " " & Surname
            lblStaff.Text = "Staff: " & FullName
            lblDescription.Text = "Description: " & Requests.QueryResults.Rows(0)(4)
            lblDate.Text = "Date Made: " & Requests.QueryResults.Rows(0)(5)
            'return a positive value
            Return True
        Else
            'return a negative value
            Return False
        End If
    End Function
    'this function creates a new job in the jobs table
    Function TakeJob(ByVal TechnicianID As Integer, ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Jobs As New DataConnection
        'add parameters for use in the query
        Jobs.AddParameter("@technicianid", TechnicianID)
        Jobs.AddParameter("@requestid", RequestID)
        'execute the query
        Jobs.Execute("sp_AddJob")
        'return a positive value
        Return True
    End Function
    'this function changes the status of a request
    Function ChangeStatus(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Change As New DataConnection
        'add parameters for use in the query
        Change.AddParameter("@status", "Active")
        Change.AddParameter("@requestid", RequestID)
        'execute the query
        Change.Execute("sp_ChangeStatus")
        'return a positive value
        Return True
    End Function
    'this is the click event for the take job button
    Protected Sub btnTake_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTake.Click
        'call the takejob function
        Call TakeJob(TechnicianID, RequestID)
        'call the changestatus function
        Call ChangeStatus(RequestID)
        'display a confirmation message
        lblConfirm.Text = "Job Taken. Click Back to Continue"
    End Sub
End Class
