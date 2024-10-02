Imports System.Data.SqlClient

Public Class Medicine
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Abdelrahman\Documents\PharmcyDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from CompanyTbl ", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CompCb.DataSource = Tbl
        CompCb.DisplayMember = "CompName"
        CompCb.ValueMember = "CompName"

        Con.Close()
    End Sub
    Public Sub populate()
        Con.Open()
        Dim sql = "select * from MedicineTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        MedicineGV.DataSource = ds.Tables(0)

        Con.Close()

    End Sub






    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Con.Open()
        Dim query As String
        query = "insert into MedicineTbl values('" & MedicineTb.Text & "," & BuyerPriceTb.Text & "," & SellerPriceTb.Text & "," & QtTb.Text & ",'" & ExpDate.Text & "','" & CompCb.SelectedValue.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Medicine Successfully Added")
        Con.Close()
        populate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MedicineTb.Text = "" Then
            MsgBox("No Medicine Selected")
        Else
            Con.Open()
            Dim query As String
            query = "delete from MedicineTbl where MedName = '" & MedicineTb.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Deleted")
            Con.Close()
            populate()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MedicineTb.Text = "" Or BuyerPriceTb.Text = "" Or SellerPriceTb.Text = "" Or QtTb.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim cmd As SqlCommand("Update MedicineTbl set BuyerPrice = " & BuyerPriceTb.Text & " , SellerPrice = " & SellerPriceTb.Text & ", MedQty = " & QtTb.Text & ", ExpDate = '" & ExpDate.Text & "', Company = '" & CompCb.SelectedValue.ToString & "' where MedName='" & MedicineTb.Text & "' ", Con)
            cmd.ExecuteNonQuery()
            MsgBox("Medicine Successfully Updated")
            Con.Close()
            populate()

        End If
    End Sub
End Class