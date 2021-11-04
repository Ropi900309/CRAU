Public Class Stylo
    Inherits ToolStripProfessionalRenderer
    Public Structure RGBColors
        Public Shared azul As Color = Color.FromArgb(0, 51, 153)
        Public Shared blanco As Color = Color.FromArgb(255, 255, 255)
        Public Shared naranja As Color = Color.FromArgb(255, 87, 51)
        Public Shared negro As Color = Color.FromArgb(0, 0, 0)
        Public Shared rojo As Color = Color.FromArgb(221, 19, 19)
        Public Shared barraTitilo As Color = Color.FromArgb(34, 33, 32)

    End Structure

    Public Shared Sub cambiarColor(menu As MenuStrip)
        With menu
            .BackColor = RGBColors.blanco
            .ForeColor = RGBColors.negro
        End With
    End Sub



    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim backC As Color = CType(IIf(e.Item.Selected, RGBColors.naranja, RGBColors.blanco), Color)
        Dim foreC As Color = CType(IIf(e.Item.Selected, RGBColors.blanco, RGBColors.negro), Color)
        Using brush As New SolidBrush(backC)
            e.Graphics.FillRectangle(brush, rc)
        End Using
        e.Item.ForeColor = foreC
        ' e.Item.Font = menufont
    End Sub
End Class