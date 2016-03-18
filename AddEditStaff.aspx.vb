
Partial Class AddEditStaff
    Inherits System.Web.UI.Page
    Dim StaffID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the manage staff page
        Response.Redirect("ManageStaff.aspx")
    End Sub
    'this code handles the click event for the submit button
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'clear the error message
        lblError.Text = ""
        'declare variables to store data and retrieve from textboxes
        Dim Forename As String = txtForename.Text
        Dim Surname As String = txtSurname.Text
        Dim Email As String = txtEmail.Text
        Dim PhoneNo As String = txtPhoneNo.Text
        Dim Password As String = txtPassword.Text
        Dim Confirm As String = txtConfirm.Text
        'call the validation function
        Dim Errormessage As String = Validation(Forename, Surname, Email, PhoneNo, Password, Confirm)
        'check if errormessage is blank
        If Errormessage = "" Then
            'check if this is a new record
            If StaffID = -1 Then
                'call the addstaff function
                Call AddStaff(Forename, Surname, Email, PhoneNo, Password)
            Else
                'call the updatestaff function
                Call UpdateStaff(Forename, Surname, Email, PhoneNo, Password, StaffID)
            End If
        Else
            'display the errormessage
            lblError.Text = Errormessage
        End If
    End Sub
    'this function adds a member of staff to the database
    Function AddStaff(ByVal Forename As String, ByVal Surname As String, ByVal Email As String, ByVal PhoneNo As String, ByVal Password As String) As Boolean
        'create an instance of the dataconnection class
        Dim Staff As New DataConnection
        'declare a variable to store the success
        Dim Success As Boolean
        'add paramaters for use in the query
        Staff.AddParameter("@forename", Forename)
        Staff.AddParameter("@surname", Surname)
        Staff.AddParameter("@phoneno", PhoneNo)
        Staff.AddParameter("@email", Email)
        Staff.AddParameter("@password", Password)
        'execute the query
        Success = Staff.Execute("sp_AddStaff")
        'display a confirmation(message)
        lblError.Text = "Record Added. Click Back to continue."
        'return success value
        Return Success
    End Function
    'this function updates a staff record
    Function UpdateStaff(ByVal Forename As String, ByVal Surname As String, ByVal PhoneNo As String, ByVal Email As String, ByVal Password As String, ByVal StaffID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Staff As New DataConnection
        'declare a variable to store the success value
        Dim Success As Boolean
        'add parameters for use in the query
        Staff.AddParameter("@forename", Forename)
        Staff.AddParameter("@surname", Surname)
        Staff.AddParameter("@phoneno", PhoneNo)
        Staff.AddParameter("@email", Email)
        Staff.AddParameter("@password", Password)
        Staff.AddParameter("@staffid", StaffID)
        'execute the query
        Success = Staff.Execute("sp_EditStaff")
        'display a confirmation message
        lblError.Text = "Record Updated. Click Back to continue."
        'return success value
        Return Success
    End Function
    'this function fills the textboxes ready for editing
    Function DisplayStaff(ByVal StaffID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim DispStaff As New DataConnection
        'add a parameter for use in the query
        DispStaff.AddParameter("@staffid", StaffID)
        'execute the query
        DispStaff.Execute("sp_SelectStaff")
        'check that the query returns a single result
        If DispStaff.Count = 1 Then
            'retrieve the data from the database and display in textboxes
            txtForename.Text = DispStaff.QueryResults.Rows(0)(1)
            txtSurname.Text = DispStaff.QueryResults.Rows(0)(2)
            txtPhoneNo.Text = DispStaff.QueryResults.Rows(0)(3)
            txtEmail.Text = DispStaff.QueryResults.Rows(0)(4)
            txtPassword.Text = DispStaff.QueryResults.Rows(0)(5)
            txtConfirm.Text = DispStaff.QueryResults.Rows(0)(5)
            'return a positive value
            Return True
        Else
            'return a negative value
            Return False
        End If
    End Function
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the staffid from the previous page
        StaffID = Request.QueryString("StaffID")
        'check if this is the first time the page has loaded
        If IsPostBack = False Then
            'check if this is a new record
            If StaffID <> -1 Then
                'fill the textboxes ready for editing
                Call DisplayStaff(StaffID)
            End If
        End If

    End Sub
    'this function validates the data
    Function Validation(ByVal Forename As String, ByVal Surname As String, ByVal Email As String, ByVal PhoneNo As String, ByVal Password As String, ByVal Confirm As String) As String
        'declare a variable to store the errormessage and assign a blank string
        Dim ErrorMessage As String = ""
        'check forename has been entered
        If Len(Forename) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Forename cannot be blank: "
        End If
        'check surname has been entered
        If Len(Surname) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Surname cannot be blank: "
        End If
        'check email is valid
        If Email.Contains("@") = False Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Invalid Email: "
        End If
        'check phone number has been entered
        If Len(PhoneNo) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Phone Number cannot be blank: "
        End If
        'check password has been entered
        If Len(Password) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Password cannot be blank: "
        End If
        'check confirm matches password
        If Password <> Confirm Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Passwords do not match: "
        End If
        'return an errormessage
        Return ErrorMessage
    End Function
End Class
