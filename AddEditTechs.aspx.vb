
Partial Class AddEditTechs
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the manage technicians screen
        Response.Redirect("ManageTechnicians.aspx")
    End Sub
    'this code handles the click event for the submit button
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'clear the errormessage
        lblError.Text = ""
        'declare variables and retrieve data from the textboxes and dropdown list
        Dim Forename As String = txtForename.Text
        Dim Surname As String = txtSurname.Text
        Dim Role As String = ddlPosition.SelectedValue
        Dim Email As String = txtEmail.Text
        Dim Password As String = txtPassword.Text
        Dim Confirm As String = txtConfirm.Text
        'declare a variable for the errormessage and run the validation function
        Dim Errormessage As String = Validation(Forename, Surname, Email, Password, Confirm)
        'check to see if the errormessage is blank
        If Errormessage = "" Then
            'check if the primary key value is -1 for a new record
            If TechnicianID = -1 Then
                'call the add technician function
                Call AddTech(Forename, Surname, Role, Email, Password)
            Else
                'call the update technician function
                Call UpdateTech(Forename, Surname, Role, Email, Password, TechnicianID)
            End If
        Else
            'display the errormessage
            lblError.Text = Errormessage
        End If

    End Sub
    'this function adds a new technician
    Function AddTech(ByVal Forename As String, ByVal Surname As String, ByVal Role As String, ByVal Email As String, ByVal Password As String) As Boolean
        'create an instance of the dataconnection class
        Dim Techs As New DataConnection
        'declare a variable to store the success of the function
        Dim Success As Boolean
        'add parameters for use in the query
        Techs.AddParameter("@forename", Forename)
        Techs.AddParameter("@surname", Surname)
        Techs.AddParameter("@role", Role)
        Techs.AddParameter("@email", Email)
        Techs.AddParameter("@password", Password)
        'execute the query
        Success = Techs.Execute("sp_AddTechnician")
        'display a confirmation message
        lblError.Text = "Record Added. Click Back to continue."
        'return success value
        Return Success
    End Function
    'this function updates a technicians details
    Function UpdateTech(ByVal Forename As String, ByVal Surname As String, ByVal Role As String, ByVal Email As String, ByVal Password As String, ByVal TechnicianID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Techs As New DataConnection
        'declare a variable to store the success of the function
        Dim Success As Boolean
        'add parameters for use in the query
        Techs.AddParameter("@forename", Forename)
        Techs.AddParameter("@surname", Surname)
        Techs.AddParameter("@role", Role)
        Techs.AddParameter("@email", Email)
        Techs.AddParameter("@password", Password)
        Techs.AddParameter("@technicianid", TechnicianID)
        'execute the query
        Success = Techs.Execute("sp_EditTechnician")
        'display a confirmation message
        lblError.Text = "Record Updated. Click Back to continue."
        'return the success value
        Return Success
    End Function
    'this function displays details in the textboxes ready for editing
    Function DisplayTechDetails(ByVal TechnicianID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim DispTechs As New DataConnection
        'add a parameter for use in the query
        DispTechs.AddParameter("@technicianid", TechnicianID)
        'execute the query
        DispTechs.Execute("sp_SelectTechnician")
        'check the query returns a single result
        If DispTechs.Count = 1 Then
            'retrieve data from the database and display in the textboxes
            txtForename.Text = DispTechs.QueryResults.Rows(0)(1)
            txtSurname.Text = DispTechs.QueryResults.Rows(0)(2)
            ddlPosition.SelectedValue = DispTechs.QueryResults.Rows(0)(3)
            txtEmail.Text = DispTechs.QueryResults.Rows(0)(4)
            txtPassword.Text = DispTechs.QueryResults.Rows(0)(5)
            txtConfirm.Text = DispTechs.QueryResults.Rows(0)(5)
            'return a positive value
            Return True
        Else
            'return a negative value
            Return False
        End If
    End Function
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the technicianid from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        'check if this is the first time the age has been loaded
        If IsPostBack = False Then
            'check if this is an update
            If TechnicianID <> -1 Then
                'display details for updating
                Call DisplayTechDetails(TechnicianID)
            End If
        End If
    End Sub
    'this function checks if there are any errors with the data
    Function Validation(ByVal Forename As String, ByVal Surname As String, ByVal Email As String, ByVal Password As String, ByVal Confirm As String) As String
        'declare a variable to hold the errormessage and assign it a blank string
        Dim ErrorMessage As String = ""
        'check a forename has been entered
        If Len(Forename) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Forename cannot be blank: "
        End If
        'check a surname has been entered
        If Len(Surname) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Surname cannot be blank: "
        End If
        'check if email is valid
        If Email.Contains("@") = False Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Invalid Email: "
        End If
        'check password has been entered
        If Len(Password) = 0 Then
            'add to erromessage
            ErrorMessage = ErrorMessage & "Password cannot be blank: "
        End If
        'check that confirm matches password
        If Password <> Confirm Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Passwords do not match: "
        End If
        'return the errormessage
        Return ErrorMessage
    End Function
End Class
