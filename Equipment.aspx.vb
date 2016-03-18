
Partial Class Equipment
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the technician menu
        Response.Redirect("Technician.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the click event for the add button
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'redirect to the add/edit page with the id value -1
        Response.Redirect("AddEditEquipment.aspx?TechnicianID=" & TechnicianID & "&EquipmentID=-1")
    End Sub
    'this code handles the click event for the edit button
    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'declare a variable to store the equipmentid
        Dim EquipmentID As Integer
        'check that an item has been selected from the listbox
        If lstEquipment.SelectedIndex <> -1 Then
            'get the equipmentid from the listbox
            EquipmentID = lstEquipment.SelectedValue
            'redirect to the add/edit page passing the equipmentid
            Response.Redirect("AddEditEquipment.aspx?TechnicianID=" & TechnicianID & "&EquipmentID=" & EquipmentID)
        Else
            'display an error message
            lblError.Text = "You must select an item from the list."
        End If

    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'declare a variable for the equipmentid
        Dim EquipmentID As Integer
        'check that an item has been selected from the listbox
        If lstEquipment.SelectedIndex <> -1 Then
            'get the equipmentid from the listbox
            EquipmentID = lstEquipment.SelectedValue
            'redirect to the delete page passing the equipmentid
            Response.Redirect("DeleteEquipment.aspx?TechnicianID=" & TechnicianID & "&EquipmentID=" & EquipmentID)
        Else
            'display an error message
            lblError.Text = "You must select an item from the list."
        End If
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the technicianid from the previous page
        TechnicianID = Request.QueryString("TechnicianID")
        'chack this is the first time the page has been loaded
        If IsPostBack = False Then
            'call the displayequipment function
            Call DisplayEquipment()
        End If
    End Sub
    'thic function displays the equipment in the listbox
    Function DisplayEquipment() As Integer
        'clear the listbox
        lstEquipment.Items.Clear()
        'declare variables to store the data
        Dim FullText, Location, Description As String
        Dim EquipmentID As Integer
        'create an instance of the dataconnection class
        Dim Equipment As New DataConnection
        'execute the query
        Equipment.Execute("sp_SelectAllEquipment")
        'loop through the query results
        For i = 0 To Equipment.Count - 1
            'retrieve the data from the database
            EquipmentID = Equipment.QueryResults.Rows(i)(0)
            Location = Equipment.QueryResults.Rows(i)(1)
            Description = Equipment.QueryResults.Rows(i)(4)
            'concatenate the data for use in a listitem
            FullText = EquipmentID & " " & Location & " " & Description
            'create a listitem
            Dim NewEquipment As New ListItem(FullText, EquipmentID)
            'add item to the listbox
            lstEquipment.Items.Add(NewEquipment)
        Next
        'return the number of results
        Return Equipment.Count
    End Function
End Class
