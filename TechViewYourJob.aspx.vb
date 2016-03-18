
Partial Class TechViewYourJob
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    Dim RequestID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to yourjobs page
        Response.Redirect("YourJobs.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the data from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        RequestID = Request.QueryString("RequestID")
        'call the displayrequest function
        Call DipslayRequest(RequestID)
    End Sub
    'this function displays the request information in the labels provided
    Function DipslayRequest(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'declare variables to store the data
        Dim Forename, Surname, FullName, PhoneNo As String
        'add a parameter for use in the query
        Requests.AddParameter("@requestid", RequestID)
        'execute the query
        Requests.Execute("sp_SelectRequest")
        'check that the query returns one result
        If Requests.Count = 1 Then
            'retrieve data from the database and fill in the labels
            lblEquipment.Text = "Equipment Number: " & Requests.QueryResults.Rows(0)(0)
            lblLocation.Text = "Location: " & Requests.QueryResults.Rows(0)(1)
            Forename = Requests.QueryResults.Rows(0)(2)
            Surname = Requests.QueryResults.Rows(0)(3)
            PhoneNo = Requests.QueryResults.Rows(0)(6)
            FullName = Forename & " " & Surname
            lblStaff.Text = "Staff: " & FullName & " PhoneNo: " & PhoneNo
            lblDescription.Text = "Description: " & Requests.QueryResults.Rows(0)(4)
            lblDate.Text = "Date Made: " & Requests.QueryResults.Rows(0)(5)
            'return a positive value
            Return True
        Else
            'return a negative value
            Return False
        End If
    End Function
    'this function fills out data in the jobs table
    Function CompleteJob(ByVal RequestID As Integer, ByVal Action As String) As Boolean
        'create an instance of the dataconnection class
        Dim Jobs As New DataConnection
        'add parameters for use in the query
        Jobs.AddParameter("@requestid", RequestID)
        Jobs.AddParameter("@action", Action)
        Jobs.AddParameter("@datecompleted", Date.Today)
        'execute the query
        Jobs.Execute("sp_CompleteJob")
        'return a positive value
        Return True
    End Function
    'this function changes the status of a request
    Function ChangeStatus(ByVal RequestID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Change As New DataConnection
        'add parameters for use in the query
        Change.AddParameter("@status", "Complete")
        Change.AddParameter("@requestid", RequestID)
        'execute the query
        Change.Execute("sp_ChangeStatus")
        'return a positive value
        Return True
    End Function
    'this code handles the click event for the complete job button
    Protected Sub btnComplete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComplete.Click
        'check that information has been entered into the action textbox
        If Len(txtAction.Text) > 0 Then
            'call the completejob function
            Call CompleteJob(RequestID, txtAction.Text)
            'call the changestatus function
            Call ChangeStatus(RequestID)
            'display a confirmation message
            lblConfirm.Text = "Job Completed. Click Back to continue"
        Else
            'display an error message
            lblConfirm.Text = "Please enter action."
        End If
    End Sub
End Class
