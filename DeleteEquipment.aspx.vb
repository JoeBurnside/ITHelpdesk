
Partial Class DeleteEquipment
    Inherits System.Web.UI.Page
    Dim TechnicianID As Integer
    Dim EquipmentID As Integer
    'this code handles the click event of the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to equipment manager
        Response.Redirect("Equipment.aspx?TechnicianID=" & TechnicianID)
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve data from the previous screen
        TechnicianID = Request.QueryString("TechnicianID")
        EquipmentID = Request.QueryString("EquipmentID")
        'display a confirmation message
        lblConfirm.Text = "Are you sure you wish to delete Item " & EquipmentID & "?"
    End Sub
    'this function deletes equipment records
    Function DeleteEquipment(ByVal EquipmentID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim Equipment As New DataConnection
        'add a parameter for use in the query
        Equipment.AddParameter("@equipmentid", EquipmentID)
        'execute the query
        Equipment.Execute("sp_DeleteEquipment")
        'return a positive value
        Return True
    End Function
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'call the deleteequipment function
        Call DeleteEquipment(EquipmentID)
        'display a confirmation message
        lblConfirm.Text = "Item Deleted. Click Back to continue"
    End Sub
End Class
