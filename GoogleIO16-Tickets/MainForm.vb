Public Class MainForm

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click

        Dim precio As Integer = 1500
        Dim imp As Integer = precio * 0.1
        Dim total As Integer = precio + imp

        lblPrecioTitulo.Text = precio.ToString("$ ##0,000")
        lblPrecio.Text = precio.ToString
        lblImp.Text = imp.ToString
        lblTotal.Text = total.ToString

    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click
        Dim precio As Integer = 2000
        Dim imp As Integer = precio * 0.1
        Dim total As Integer = precio + imp

        lblPrecioTitulo.Text = precio.ToString("$ ##0,000")
        lblPrecio.Text = precio.ToString
        lblImp.Text = imp.ToString
        lblTotal.Text = total.ToString
    End Sub

    Private Sub btnFull_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        Dim precio As Integer = 2500
        Dim imp As Integer = precio * 0.1
        Dim total As Integer = precio + imp

        lblPrecioTitulo.Text = precio.ToString("$ ##0,000")
        lblPrecio.Text = precio.ToString
        lblImp.Text = imp.ToString
        lblTotal.Text = total.ToString
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        MsgBox("¡ENTRADAS ADQUIRIDAS SATISFACTORIAMENTE! ;)")
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblPrecioTitulo.Text = "seleccione..."
        lblPrecio.Text = "-"
        lblImp.Text = "-"
        lblTotal.Text = "-"

    End Sub


End Class