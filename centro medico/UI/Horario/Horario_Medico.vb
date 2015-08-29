Public Class Horario_Medico

    'Public DiasNoLaborables As Integer = 0
    'Public DiasNoLaborables_qNoCuentanVacaciones = 0
    'Public DiasNoLaborables_qSiCuentanVacaciones = 0
    'Public Fiestas As Integer = 0

    Public DiasNoLaborables As New List(Of DateContainer)

End Class




Public Class HorarioEntry

    Public Property Medico As String
    Public Property Usuario As String

    Public Property Tipo As ctrlHorarios.TipoFecha
    Public Property Fecha As Date
    Public Property Justificacion As String

    'Public Property DiasLaborables As List(Of DateContainer)
    'Public Property DiasNoLaborables_qNoCuentanVacaciones As List(Of DateContainer)
    'Public Property DiasNoLaborables_qSiCuentanVacaciones As List(Of DateContainer)
    'Public Property Fiestas As List(Of DateContainer)

End Class

'Public Class HorarioEntryCollection
'    Implements ICollection(Of HorarioEntry)

'    Private list As new List(Of HorarioEntry)

'    Public Sub New()

'    End Sub

'    Public Sub Add(item As HorarioEntry) Implements System.Collections.Generic.ICollection(Of HorarioEntry).Add
'        list.Add(item)
'    End Sub

'    Public Sub Clear() Implements System.Collections.Generic.ICollection(Of HorarioEntry).Clear
'        list.Clear()



'    End Sub

'    Public Function Contains(item As HorarioEntry) As Boolean Implements System.Collections.Generic.ICollection(Of HorarioEntry).Contains
'        Return list.Contains(item)
'    End Function

'    Public Sub CopyTo(array() As HorarioEntry, arrayIndex As Integer) Implements System.Collections.Generic.ICollection(Of HorarioEntry).CopyTo
'        list.CopyTo(array, arrayIndex)
'    End Sub

'    Public ReadOnly Property Count As Integer Implements System.Collections.Generic.ICollection(Of HorarioEntry).Count
'        Get
'            Return list.Count
'        End Get
'    End Property

'    Public ReadOnly Property IsReadOnly As Boolean Implements System.Collections.Generic.ICollection(Of HorarioEntry).IsReadOnly
'        Get
'            Return False
'        End Get
'    End Property

'    Public Function Remove(item As HorarioEntry) As Boolean Implements System.Collections.Generic.ICollection(Of HorarioEntry).Remove
'        list.Remove(item)
'    End Function

'    Public Function GetEnumerator() As System.Collections.Generic.IEnumerator(Of HorarioEntry) Implements System.Collections.Generic.IEnumerable(Of HorarioEntry).GetEnumerator
'        Return list.GetEnumerator()
'    End Function

'    Public Function GetEnumerator1() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
'        Return list.GetEnumerator()
'    End Function
'End Class

Public Class DateContainer
    Public Property Tipo As ctrlHorarios.TipoFecha
    Public Property DateItem As Pabo.Calendar.DateItem
    Public Property Justificacion As String

    Public Sub New(ByVal tipo As ctrlHorarios.TipoFecha, ByRef dateitem As Pabo.Calendar.DateItem, ByVal just As String)
        Me.Tipo = tipo
        Me.DateItem = dateitem
        Me.Justificacion = just
    End Sub
End Class