Imports formulario_lista

Public Class nodo

    Private persona As persona
    Private siguiente As nodo

    Public Sub New()
        Me.persona = Nothing
        Me.siguiente = Nothing
    End Sub

    Public Sub New(persona As persona, siguiente As nodo)
        Me.persona = persona
        Me.siguiente = siguiente
    End Sub

    Public Sub New(nom As String, ed As Integer, siguiemte As nodo)

        Me.persona = New persona(nom, ed)
        Me.siguiente = siguiente
    End Sub

    Public Sub getsig(n As nodo)

        Me.siguiente = n
    End Sub

    Function setper() As String

        Return Me.persona.setnom()

    End Function

    Function setsig() As nodo

        Return Me.siguiente

    End Function



End Class

