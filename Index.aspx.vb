
Partial Class Index
    Inherits System.Web.UI.Page
    'This code deals with the login click button
    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'declare variables for the email and password
        Dim Email As String = txtEmail.Text
        Dim Password As String = txtPassword.Text
        'declare a variable to store the results of the login function and call the function
        Dim ID As String = Login(Email, Password)
        'If the function returns a blank string
        If ID = "" Then
            'Display an error message
            lblError.Text = "Incorrect Username or Password"
        Else
            'Redirect to the correct page
            Response.Redirect(ID)
        End If
    End Sub
    'This code is the login function
    Function Login(ByVal Email As String, ByVal Password As String) As String
        'Create an instance of the dataconnection class
        Dim Staff As New DataConnection
        'add paramaters to use in the query
        Staff.AddParameter("@email", Email)
        Staff.AddParameter("@password", Password)
        'execute the query
        Staff.Execute("sp_StaffLogin")
        'check if there is one result from the query
        If Staff.Count = 1 Then
            'declare a variable to store the staffid
            Dim StaffID As Integer
            'retrieve the staff ID from the database
            StaffID = Staff.QueryResults.Rows(0)(0)
            'return a string that redirects to the staff page
            Return "Staff.aspx?StaffID=" & StaffID
        Else
            'create an instance of the dataconnection class
            Dim Techs As New DataConnection
            'add paramaters for use in the query
            Techs.AddParameter("@email", Email)
            Techs.AddParameter("@password", Password)
            'execute the query
            Techs.Execute("sp_TechLogin")
            'check if the query returns one result
            If Techs.Count = 1 Then
                'declare variables and retrieve data from the database
                Dim TechnicianID As Integer = Techs.QueryResults.Rows(0)(0)
                Dim Role As String = Techs.QueryResults.Rows(0)(3)
                'check what role the person has
                If Role = "Manager" Then
                    'return a string that directs to the manager page
                    Return "Manager.aspx"
                Else
                    'return a string that directs to the technicians page
                    Return "Technician.aspx?TechnicianID=" & TechnicianID
                End If
            Else
                'if no users found, return a blank string
                Return ""
            End If


        End If

    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
