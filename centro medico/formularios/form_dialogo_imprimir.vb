Public Class form_dialogo_imprimir


    Private Sub form_dialogo_imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rb_impresora.Checked = True
        chb_vista_previa.Checked = True

    End Sub

    Private Sub rb_impresora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_impresora.CheckedChanged
        If rb_impresora.Checked = True Then
            chb_vista_previa.Enabled = True
        Else
            chb_vista_previa.Enabled = False
        End If
    End Sub

    Private Sub rb_excel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_excel.CheckedChanged
        chb_vista_previa.Enabled = False
        chb_vista_previa.Checked = False
    End Sub

    Private Sub rb_pdf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_pdf.CheckedChanged
        chb_vista_previa.Enabled = False
        chb_vista_previa.Checked = False
    End Sub

    Public ReadOnly Property VistaPrevia() As Boolean
        Get
            Return chb_vista_previa.Checked
        End Get
    End Property

    Public ReadOnly Property Impresora() As Boolean
        Get
            Return rb_impresora.Checked
        End Get
    End Property

    Public ReadOnly Property Excel() As Boolean
        Get
            Return rb_excel.Checked
        End Get
    End Property

    Public ReadOnly Property Pdf() As Boolean
        Get
            Return rb_pdf.Checked
        End Get
    End Property

End Class