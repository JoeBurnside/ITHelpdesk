
Partial Class AvailableJobs
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    'this code handles the back button click event
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to technician menu
        Response.Redirect("Technician.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the view job button click event
    Protected Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        'check that a record has been selected from the list
        If lstJobs.SelectedIndex <> -1 Then
            'declare requestid and retrieve the value from the listbox
            Dim RequestID As Integer = lstJobs.SelectedValue
            'redirect to the view job page passing the requestid
            Response.Redirect("TechViewJob.aspx?TechnicianID=" & TechnicianID & "&RequestID=" & RequestID)
        Else
            'display an error message
            lblError.Text = "You must select a job from the list."
        End If

    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the technicianid from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        'check if this is the first time the page has been loaded
        If IsPostBack = False Then
            'fill the listbox
            Call DisplayJobs()
        End If
    End Sub
    'this function fills the listbox with available jobs
    Function DisplayJobs() As Boolean
        'clear the listbox
        lstJobs.Items.Clear()
        'declare variables to store the data
        Dim FullText, Description As String
        Dim RequestID, EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'add a parameter for use in the query
        Requests.AddParameter("@status", "Pending")
        'execute the query
        Requests.Execute("sp_SelectRequestStatus")
        'loop through the results of the query
        For i = 0 To Requests.Count - 1
            'retrieve data from the database
            RequestID = Requests.QueryResults.Rows(i)(0)
            EquipmentID = Requests.QueryResults.Rows(i)(1)
            Description = Requests.QueryResults.Rows(i)(3)
            'concatenate data for use in a listitem
            FullText = EquipmentID & " " & Description
            'create a listitem
            Dim NewRequest As New ListItem(FullText, RequestID)
            'add item to the list
            lstJobs.Items.Add(NewRequest)
        Next
        'return number of records found
        Return Requests.Count
    End Function
End Class
