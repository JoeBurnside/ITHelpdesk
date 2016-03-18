
Partial Class ManageTechnicians
    Inherits System.Web.UI.Page
    ' this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect back to the user management page
        Response.Redirect("ManageUsers.aspx")
    End Sub
    'this button handles the click event for the add button
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'redirect to the add/edit screen using the primary key value of -1
        Response.Redirect("AddEditTechs.aspx?TechnicianID=-1")
    End Sub
    'this code handles the click event for the edit button
    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'declare a variable to store the technicianid
        Dim TechnicianID As Integer
        'check that a record has been selected from the listbox
        If lstTechnicians.SelectedIndex <> -1 Then
            'take the technicianid from the listbox
            TechnicianID = lstTechnicians.SelectedValue
            'redirect to the add/edit page using the technicianid as a primary key
            Response.Redirect("AddEditTechs.aspx?TechnicianID=" & TechnicianID)
        Else
            'display an error message
            lblError.Text = "You must select a technician from the list."
        End If
    End Sub
    'this code handles the click event fore the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'declare a variable to store the technicianid
        Dim TechnicianID As Integer
        'check that a record has been selected from the listbox
        If lstTechnicians.SelectedIndex <> -1 Then
            'take the technicianid from the listbox
            TechnicianID = lstTechnicians.SelectedValue
            'redirect to the delete page passing the technicianid
            Response.Redirect("DeleteTech.aspx?TechnicianID=" & TechnicianID)
        Else
            'display an error message
            lblError.Text = "You must select a technician from the list."
        End If
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'check if this is the first time the page has been loaded
        If IsPostBack = False Then
            'fill the listbox with data
            Call DisplayTechs()
        End If
    End Sub
    'this function displays the technicians in the listbox
    Function DisplayTechs() As Integer
        'clear the listbox
        lstTechnicians.Items.Clear()
        'declare variables to store the data
        Dim FullText, Surname, Forename, Role As String
        Dim TechnicianID As Integer
        'create an instance of the dataconnection class
        Dim Techs As New DataConnection
        'execute the query
        Techs.Execute("sp_SelectAllTechs")
        'loop through the results
        For i = 0 To Techs.Count - 1
            'retrieve data from the database
            TechnicianID = Techs.QueryResults.Rows(i)(0)
            Forename = Techs.QueryResults.Rows(i)(1)
            Surname = Techs.QueryResults.Rows(i)(2)
            Role = Techs.QueryResults.Rows(i)(3)
            'concatenate the data to create a listitem
            FullText = Forename & " " & Surname & " " & Role
            'create a listitem
            Dim NewTech As New ListItem(FullText, TechnicianID)
            'add the listitem to the listbox
            lstTechnicians.Items.Add(NewTech)
        Next
        'return the number of records found
        Return Techs.Count
    End Function
End Class
