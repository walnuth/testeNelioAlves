Public Class frmAddPtw
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.PTopen'. Você pode movê-la ou removê-la conforme necessário.
        Me.PTopenTableAdapter.Fill(Me.DataSet1.PTopen)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
End Class
