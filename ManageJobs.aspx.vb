
Partial Class ManageJobs
    Inherits System.Web.UI.Page
    'This code handles the click event for the Back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Redirect back to the manager menu
        Response.Redirect("Manager.aspx")
    End Sub
    'This code handles the Click Event for the Delete Button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'declare a variable to store the requestid
        Dim RequestID As Integer
        'make sure an item has been selected from the jobs list
        If lstJobs.SelectedIndex <> -1 Then
            'select the items ID from the jobs list
            RequestID = lstJobs.SelectedValue
            'redirect to the delete page, sending the requestid
            Response.Redirect("DeleteJob.aspx?RequestID=" & RequestID)
        Else
            'display an error message
            lblError.Text = "You must select an request from the list"
        End If
    End Sub
    'this code is the displayall function. It fills the listbox lstJobs.
    Function DisplayAll() As Integer
        'clear all items from the list box
        lstJobs.Items.Clear()
        'declare variables to store the retrieved data
        Dim FullText, Status, Description As String
        Dim RequestID, EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'execute the query
        Requests.Execute("sp_SelectAllRequests")
        'loop through the query results
        For i = 0 To Requests.Count - 1
            'retrieve data from the database
            RequestID = Requests.QueryResults.Rows(i)(0)
            EquipmentID = Requests.QueryResults.Rows(i)(1)
            Description = Requests.QueryResults.Rows(i)(3)
            Status = Requests.QueryResults.Rows(i)(5)
            'concatenate the data to create a listitem
            FullText = EquipmentID & " " & Description & " " & Status
            'create a listitem
            Dim NewRequest As New ListItem(FullText, RequestID)
            'add the listitem to the listbox
            lstJobs.Items.Add(NewRequest)
        Next
        'return the number of rows returned from the database
        Return Requests.Count
    End Function
    'This function displayes all requests from a certain category
    Function DisplayStatus(ByVal StatusSelected As String) As Integer
        'clear the listbox
        lstJobs.Items.Clear()
        'declare variables to store the data
        Dim FullText, Status, Description As String
        Dim RequestID, EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Requests As New DataConnection
        'add a parameter for use in the query
        Requests.AddParameter("@status", StatusSelected)
        'execute the query
        Requests.Execute("sp_SelectRequestStatus")
        'loop through query results
        For i = 0 To Requests.Count - 1
            'retrieve data from the database
            RequestID = Requests.QueryResults.Rows(i)(0)
            EquipmentID = Requests.QueryResults.Rows(i)(1)
            Description = Requests.QueryResults.Rows(i)(3)
            Status = Requests.QueryResults.Rows(i)(5)
            'concatenate the data for use in a listitem
            FullText = EquipmentID & " " & Description & " " & Status
            'create a listitem
            Dim NewRequest As New ListItem(FullText, RequestID)
            'add lititem to the listbox
            lstJobs.Items.Add(NewRequest)
        Next
        'return number of rows returned from the database
        Return Requests.Count
    End Function
    'This function fills the dropdown list with technicians names
    Function DisplayTechs() As Integer
        'clear the dropdown list
        ddlTechs.Items.Clear()
        'declare variables to store the data
        Dim FullText, Surname, Forename As String
        Dim TechnicianID As Integer
        'create an instance of the dataconnection class
        Dim Techs As New DataConnection
        'execute the query
        Techs.Execute("sp_SelectAllTech")
        'loop through the query results
        For i = 0 To Techs.Count - 1
            'retrieve data from the database
            TechnicianID = Techs.QueryResults.Rows(i)(0)
            Forename = Techs.QueryResults.Rows(i)(1)
            Surname = Techs.QueryResults.Rows(i)(2)
            'concatenate the technicians names
            FullText = Forename & " " & Surname
            'create a listitem
            Dim NewTech As New ListItem(FullText, TechnicianID)
            'add listitem to the dropdown list
            ddlTechs.Items.Add(NewTech)
        Next
        Return Techs.Count
    End Function
    'this function creates a new job
    Function AssignJob(ByVal RequestID As Integer, ByVal TechnicianID As Integer) As Boolean
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
    'This function changes the status of a request
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
    'this code handles the click event for the assign button
    Protected Sub btnAssign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        'declare variables to store data
        Dim RequestID, TechnicianID As Integer
        'check that a record has been selected from the listbox
        If lstJobs.SelectedIndex <> -1 Then
            'take the requestid from the listbox
            RequestID = lstJobs.SelectedValue
            'take the technicianid from the dropdown list
            TechnicianID = ddlTechs.SelectedValue
            'call the assignjob function
            Call AssignJob(RequestID, TechnicianID)
            'call the changestatus function
            Call ChangeStatus(RequestID)
            'display a message
            lblError.Text = "Job Assigned"
            'update the listbox
            Call DisplayAll()
        Else
            'display an error message
            lblError.Text = "You must select a request from the list"
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Call DisplayTechs()
            Call DisplayAll()
        End If
    End Sub
    'this code handles the page load event
    Protected Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click
        'check if the "all" option is selected
        If ddlStatus.SelectedIndex = 0 Then
            'display all records
            Call DisplayAll()
        Else
            'display selected status
            Call DisplayStatus(ddlStatus.SelectedValue)
        End If
    End Sub
End Class
