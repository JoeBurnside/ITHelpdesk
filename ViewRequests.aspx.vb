
Partial Class ViewRequests
    Inherits System.Web.UI.Page
    Dim StaffID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the staff menu
        Response.Redirect("Staff.aspx?StaffID=" & StaffID)
    End Sub
    'this code handles the click event for the view job button
    Protected Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        'check an item has been selected from the listbox
        If lstJobs.SelectedIndex <> -1 Then
            'declare a variable to store requestid and retrieve from the listbox
            Dim RequestID As Integer = lstJobs.SelectedValue
            'redirect to view job page passing requestid
            Response.Redirect("StaffViewJob.aspx?StaffID=" & StaffID & "&RequestID=" & RequestID)
        End If
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve staffid from previous page
        StaffID = Request.QueryString("StaffID")
        'check that this is the first time the page has loaded
        If IsPostBack = False Then
            'call displayjobs function
            Call DisplayJobs(StaffID)
        End If
    End Sub
    'this function fills the listbox with jobs
    Function DisplayJobs(ByVal StaffID As Integer) As Boolean
        'clear listbox
        lstJobs.Items.Clear()
        'declare variables to store the data
        Dim FullText, Description As String
        Dim RequestID, EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'add parameter for use in the query
        Requests.AddParameter("@staffid", StaffID)
        'execute the query
        Requests.Execute("sp_SelectStaffRequest")
        'loop through the results of the query
        For i = 0 To Requests.Count - 1
            'retrieve data from the database
            RequestID = Requests.QueryResults.Rows(i)(0)
            EquipmentID = Requests.QueryResults.Rows(i)(1)
            Description = Requests.QueryResults.Rows(i)(3)
            'concatenate data to use in listitem
            FullText = EquipmentID & " " & Description
            'create listitem
            Dim NewRequest As New ListItem(FullText, RequestID)
            'add item to listbox
            lstJobs.Items.Add(NewRequest)
        Next
        'return number of records found
        Return Requests.Count
    End Function

End Class
