Imports CrystalDecisions.[Shared]

Public Class crystal_coding
  Private Sub crystal_coding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim ds As New DataSet1
    Dim ad As New DataSet1TableAdapters.tb1TableAdapter
    ad.Fill(ds.tb1)
    Dim rbt As New CrystalReport2
    rbt.SetDataSource(ds)
    CrystalReportViewer1.ReportSource = rbt
  End Sub
End Class