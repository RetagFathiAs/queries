Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Form2
  Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\test\Desktop\adel-sql\db1.accdb;Persist Security Info=False"
  Dim conn As New OleDbConnection(constr)
  Dim dataset1 As New DataSet
  Dim saveinto As New OleDbCommand
  Dim i As New Integer

  Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
    conn.Open()
    Dim sqlstr As String = "Select * from tb1 where mobile=('" & Me.mobtext.Text & "')"
    Dim dataadapter1 As New OleDbDataAdapter(sqlstr, conn)
    dataadapter1.Fill(dataset1, "tb1")
    conn.Close()
    If Me.BindingContext(dataset1, "tb1").Count = 0 Then
      saveinto.Connection = conn
      saveinto.CommandType = CommandType.Text
      saveinto.CommandText = "insert into tb1(name,city,mobile)" & " values ('" & nametext.Text &
        "','" & citytext.Text & "','" & mobtext.Text & "')"
      conn.Open()
      saveinto.ExecuteNonQuery()
      MsgBox("ok")
    Else
      MsgBox("exist")

    End If
    conn.Close()
  End Sub

  Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
    conn.Open()
    Dim sqlstr As String = "Select * from tb1 where mobile=('" & Me.mobtext.Text & "')"
    Dim dataadapter1 As New OleDbDataAdapter(sqlstr, conn)
    dataadapter1.Fill(dataset1, "tb1")
    conn.Close()
    If Me.BindingContext(dataset1, "tb1").Count = 0 Then
      MsgBox("Doesn't exist")

    Else
      saveinto.Connection = conn
      saveinto.CommandType = CommandType.Text
      saveinto.CommandText = "delete * from tb1 where names='" & nametext.Text & "'"
      conn.Open()
      saveinto.ExecuteNonQuery()
      dataset1.Clear()
      conn.Close()

      dataadapter1.Fill(dataset1, "tb1")
      MsgBox("done")

    End If

  End Sub

  Private Sub codingbtn_Click(sender As Object, e As EventArgs) Handles codingbtn.Click
    Dim cr As New crystal_coding()
    cr.Show()
    Me.Hide()
  End Sub

  Private Sub noncodingbtn_Click(sender As Object, e As EventArgs) Handles noncodingbtn.Click
    Dim f As New form
    f.Show()
    Me.Hide()
  End Sub
End Class