
Partial Class LogFault
    Inherits System.Web.UI.Page
    Dim StaffID As Integer
    Dim RequestID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to staff menu
        Response.Redirect("Staff.aspx?StaffID=" & StaffID)
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve data from the previous page
        StaffID = Request.QueryString("StaffID")
        RequestID = Request.QueryString("RequestID")
        'check this is the first time the page has been loaded
        If IsPostBack = False Then
            'call the displayequipment function
            Call DisplayEquipment()
        End If
    End Sub
    'this function fills the dropdown list with equipment
    Function DisplayEquipment() As Integer
        'clear the dropdown list
        ddlMachine.Items.Clear()
        'declare a variable to store the equipmentid
        Dim EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Machines As New DataConnection
        'execute the query
        Machines.Execute("sp_SelectAllEquipment")
        'loop through the query results
        For i = 0 To Machines.Count - 1
            'retrieve data from the database
            EquipmentID = Machines.QueryResults.Rows(i)(0)
            'create a new listitem
            Dim NewMachine As New ListItem(EquipmentID, EquipmentID)
            'add item to dropdown list
            ddlMachine.Items.Add(NewMachine)
        Next
        'return the number of results
        Return Machines.Count
    End Function
    'this function adds a new request
    Function AddRequest(ByVal EquipmentID As Integer, ByVal StaffID As Integer, ByVal Description As String) As Boolean
        'create an instance of the dataconnection class
        Dim NewRequest As New DataConnection
        'add parameters for use in the query
        NewRequest.AddParameter("@equipmentid", EquipmentID)
        NewRequest.AddParameter("@staffid", StaffID)
        NewRequest.AddParameter("@description", Description)
        NewRequest.AddParameter("@datemade", Date.Today)
        'execute the query
        NewRequest.Execute("sp_AddRequest")
        'display a confirmation message
        lblError.Text = "Request added. Click Back to continue."
        'return a positive value
        Return True
    End Function
    'this code handles the click event for the submit button
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'check there is data in the description textbox
        If Len(txtDescription.Text) > 0 Then
            'call the addrequest function
            Call AddRequest(ddlMachine.SelectedValue, StaffID, txtDescription.Text)
        Else
            'display an errormessage
            lblError.Text = "Please enter a description."
        End If
    End Sub
End Class
