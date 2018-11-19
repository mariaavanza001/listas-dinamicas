Imports formulario_lista

Public Class lista
    Private primero As nodo

    Public Sub New()
        Me.primero = Nothing
    End Sub

    Public Sub insertar(nom As String, edad As Integer)

        Dim n As New nodo(nom, edad, Nothing)
        ' si la lista está vacia
        If (Me.primero Is Nothing) Then
            Me.primero = n

        Else 'sino
            Dim aux As nodo
            aux = primero
            While (aux.setsig() IsNot Nothing)

                aux = aux.setsig()
            End While
            aux.getsig(n)
        End If
    End Sub

    Public Sub mostrar()
        Dim aux As nodo = Me.primero
        While (aux IsNot Nothing)
            Dim nom As String = aux.setper()
            aux = aux.setsig()
            Interaction.MsgBox(nom)
        End While
    End Sub
End Class

