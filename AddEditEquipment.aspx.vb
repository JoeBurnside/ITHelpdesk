
Partial Class AddEditEquipment
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    Dim EquipmentID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the equipment manager
        Response.Redirect("Equipment.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the data from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        EquipmentID = Request.QueryString("EquipmentID")
        'check if this is the first time the page has been loaded
        If IsPostBack = False Then
            'check if this is a new piece of equipment
            If EquipmentID <> -1 Then
                'call the displayequipment function
                Call DisplayEquipment(EquipmentID)
            End If
        End If
    End Sub
    'this function adds new equipment
    Function AddEquipment(ByVal Location As String, ByVal Make As String, ByVal Model As String, ByVal Description As String) As Boolean
        'create an instance of the dataconneciton class
        Dim Equipment As New DataConnection
        'declare a variable to store the success
        Dim Success As Boolean
        'add parameters for use in the query
        Equipment.AddParameter("@location", Location)
        Equipment.AddParameter("@make", Make)
        Equipment.AddParameter("@model", Model)
        Equipment.AddParameter("@description", Description)
        'execute the query
        Success = Equipment.Execute("sp_AddEquipment")
        'display a confirmation message
        lblError.Text = "Record Added. Click Back to continue."
        'return success value
        Return Success
    End Function
    'this function updates equipment records
    Function UpdateEquipment(ByVal Location As String, ByVal Make As String, ByVal Model As String, ByVal Description As String, ByVal EquipmentID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Equipment As New DataConnection
        'declare a variable to store the success value
        Dim Success As Boolean
        'add parameters for use in the query
        Equipment.AddParameter("@location", Location)
        Equipment.AddParameter("@make", Make)
        Equipment.AddParameter("@model", Model)
        Equipment.AddParameter("@description", Description)
        Equipment.AddParameter("@equipmentid", EquipmentID)
        'execute the query
        Success = Equipment.Execute("sp_EditEquipment")
        'display a confirmation message
        lblError.Text = "Record Updated. Click Back to continue."
        'return success value
        Return Success
    End Function
    'this function fills the textboxes with data ready for editing
    Function DisplayEquipment(ByVal EquipmentID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim DispEquipment As New DataConnection
        'add a parameter for use in the query
        DispEquipment.AddParameter("@equipmentid", EquipmentID)
        'execute the query
        DispEquipment.Execute("sp_SelectEquipment")
        'loop through the query results
        If DispEquipment.Count = 1 Then
            'retrieve data from the database and place in the textboxes
            txtLocation.Text = DispEquipment.QueryResults.Rows(0)(1)
            txtMake.Text = DispEquipment.QueryResults.Rows(0)(2)
            txtModel.Text = DispEquipment.QueryResults.Rows(0)(3)
            txtDescription.Text = DispEquipment.QueryResults.Rows(0)(4)
            'return positive value
            Return True
        Else
            'return negative value
            Return False
        End If
    End Function
    'this code handles the click event for the submit button
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'clear the error message
        lblError.Text = ""
        'declare variables to store the data and retrieve from textboxes
        Dim Location As String = txtLocation.Text
        Dim Make As String = txtMake.Text
        Dim Model As String = txtModel.Text
        Dim Description As String = txtDescription.Text
        'check data id valid
        Dim Errormessage As String = Validation(Location, Make, Model, Description)
        'check there is no errormessage
        If Errormessage = "" Then
            'check if this is a new record
            If EquipmentID = -1 Then
                'call addequipment function
                Call AddEquipment(Location, Make, Model, Description)
            Else
                'call updateequipment function
                Call UpdateEquipment(Location, Make, Model, Description, EquipmentID)
            End If
        Else
            'display an error message
            lblError.Text = Errormessage
        End If
    End Sub
    'this function checks that data is valid
    Function Validation(ByVal Location As String, ByVal Make As String, ByVal Model As String, ByVal Description As String) As String
        'declare a variable to store the errormessage and assign a blank string
        Dim ErrorMessage As String = ""
        'check location has content
        If Len(Location) = 0 Then
            'add to error message
            ErrorMessage = ErrorMessage & "Location cannot be blank: "
        End If
        'check make has content
        If Len(Make) = 0 Then
            'add to error message
            ErrorMessage = ErrorMessage & "Make cannot be blank: "
        End If
        'check model has content
        If Len(Model) = 0 Then
            'add to error message
            ErrorMessage = ErrorMessage & "Model cannot be blank: "
        End If
        'check description has content
        If Len(Description) = 0 Then
            'add to error message
            ErrorMessage = ErrorMessage & "Description cannot be blank: "
        End If
        'return the errormessage
        Return ErrorMessage
    End Function
End Class
