
Partial Class YourJobs
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the technicians menu
        Response.Redirect("Technician.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the click event for the view job button
    Protected Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        ''check a job has been selected from the list
        If lstJobs.SelectedIndex <> -1 Then
            'retrieve the requestid from the listbox
            Dim RequestID As Integer = lstJobs.SelectedValue
            'redirect to the view job page passing the requestid
            Response.Redirect("TechViewYourJob.aspx?TechnicianID=" & TechnicianID & "&RequestID=" & RequestID)
        Else
            'display an error message
            lblError.Text = "You must select a job from the list."
        End If
    End Sub
    'this function fills the listbox with technicians jobs
    Function DisplayJobs(ByVal TechnicianID As Integer) As Boolean
        'clear the listbox
        lstJobs.Items.Clear()
        'declare variables to store the data
        Dim FullText, Description As String
        Dim RequestID, EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'add a parameter for use in the query
        Requests.AddParameter("@technicianid", TechnicianID)
        'execute the query
        Requests.Execute("sp_SelectTechJobs")
        'loop though the query results
        For i = 0 To Requests.Count - 1
            'retrieve data from the database
            RequestID = Requests.QueryResults.Rows(i)(0)
            EquipmentID = Requests.QueryResults.Rows(i)(1)
            Description = Requests.QueryResults.Rows(i)(2)
            'concatenate data to use in a listitem
            FullText = EquipmentID & " " & Description
            'create a listitem
            Dim NewRequest As New ListItem(FullText, RequestID)
            'add item to the listbox
            lstJobs.Items.Add(NewRequest)
        Next
        'return number of records returned
        Return Requests.Count
    End Function
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'get the technicianid from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        'check if this is the first time the page has been loaded
        If IsPostBack = False Then
            'call the displayjobs function
            Call DisplayJobs(TechnicianID)
        End If
    End Sub
End Class
