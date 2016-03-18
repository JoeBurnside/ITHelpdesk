
Partial Class ManageStaff
    Inherits System.Web.UI.Page
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to manage users page
        Response.Redirect("ManageUsers.aspx")
    End Sub
    'this code handles the click event for the add button
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'redirect to add/edit page sending a primary key value of -1
        Response.Redirect("AddEditStaff.aspx?StaffID=-1")
    End Sub
    'this button handles the click event for the edit button
    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'declare a variable to store the staffid
        Dim StaffID As Integer
        'make sure an item has been selected from the listbox
        If lstStaff.SelectedIndex <> -1 Then
            'get the staffid from the listbox
            StaffID = lstStaff.SelectedValue
            'redirect to the add/edit page passing the staffid
            Response.Redirect("AddEditStaff.aspx?StaffID=" & StaffID)
        Else
            'display an error message
            lblError.Text = "You must select a staff member from the list."
        End If
    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'declare a variable to store the staffid
        Dim StaffID As Integer
        'make sure an item has been selected from the listbox
        If lstStaff.SelectedIndex <> -1 Then
            'get the staffid from the listbox
            StaffID = lstStaff.SelectedValue
            'redirect to the delete page passing the staffid
            Response.Redirect("DeleteStaff.aspx?StaffID=" & StaffID)
        Else
            'display an error message
            lblError.Text = "You must select a staff member from the list."
        End If
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'check if it is the first time the page has been loaded
        If IsPostBack = False Then
            'fill the listbox using the displaystaff function
            Call DisplayStaff()
        End If
    End Sub
    'this function fills the listbox
    Function DisplayStaff() As Integer
        'clear the listbox
        lstStaff.Items.Clear()
        'declare variables to store the data
        Dim FullText, Forename, Surname As String
        Dim StaffID As Integer
        'create an instance of the dataconnection class
        Dim Staff As New DataConnection
        'execute the query
        Staff.Execute("sp_SelectAllStaff")
        'loop through the results
        For i = 0 To Staff.Count - 1
            'retrieve data from the database
            StaffID = Staff.QueryResults.Rows(i)(0)
            Forename = Staff.QueryResults.Rows(i)(1)
            Surname = Staff.QueryResults.Rows(i)(2)
            'concatenate the data to form a listitem
            FullText = Forename & " " & Surname
            'create a listitem
            Dim NewStaff As New ListItem(FullText, StaffID)
            'add item to the listbox
            lstStaff.Items.Add(NewStaff)
        Next
        'return the number of records
        Return Staff.Count
    End Function
End Class
