Imports System.Collections.Generic
Imports System.Windows.Forms

<Runtime.CompilerServices.Extension()> _
Module DraggableExtensionModule

    Public Class ControlExtension


        ' TKey is control to drag, TValue is a flag used while dragging
        Private Shared draggables As New Dictionary(Of Control, Boolean)()
        Private Shared mouseOffset As System.Drawing.Size

        ''' <summary>
        ''' Enabling/disabling dragging for control
        ''' </summary>

        Public Shared Sub Draggable(control As Control, Enable As Boolean)
            If Enable Then
                ' enabling drag feature
                If draggables.ContainsKey(control) Then
                    ' return if control is already draggable
                    Return
                End If
                draggables.Add(control, False)
                ' 'false' - initial state is 'not dragging'
                ' assign required event handlers
                AddHandler control.MouseDown, New MouseEventHandler(AddressOf control_MouseDown)
                AddHandler control.MouseUp, New MouseEventHandler(AddressOf control_MouseUp)
                AddHandler control.MouseMove, New MouseEventHandler(AddressOf control_MouseMove)
            Else
                ' disabling drag feature
                If Not draggables.ContainsKey(control) Then
                    ' return if control is not draggable
                    Return
                End If
                ' remove event handlers
                RemoveHandler control.MouseDown, AddressOf control_MouseDown
                RemoveHandler control.MouseUp, AddressOf control_MouseUp
                RemoveHandler control.MouseMove, AddressOf control_MouseMove
                draggables.Remove(control)
            End If
        End Sub

        Private Shared Sub control_MouseDown(sender As Object, e As MouseEventArgs)
            mouseOffset = New System.Drawing.Size(e.Location)
            ' turning on dragging
            draggables(DirectCast(sender, Control)) = True
        End Sub

        Private Shared Sub control_MouseUp(sender As Object, e As MouseEventArgs)
            ' turning off dragging
            draggables(DirectCast(sender, Control)) = False
        End Sub

        Private Shared Sub control_MouseMove(sender As Object, e As MouseEventArgs)
            ' only if dragging is turned on
            If draggables(DirectCast(sender, Control)) = True Then
                ' calculations of control's new position
                Dim newLocationOffset As System.Drawing.Point = e.Location - mouseOffset
                DirectCast(sender, Control).Left += newLocationOffset.X
                DirectCast(sender, Control).Top += newLocationOffset.Y

                If Not DirectCast(sender, Control).Parent Is Nothing Then
                    DirectCast(sender, Control).Refresh()
                End If
            End If
        End Sub
    End Class
End Module



