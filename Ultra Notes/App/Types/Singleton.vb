Namespace App.Types
    
    Public MustInherit Class Singleton (Of T As { Class })
        Private Shared ReadOnly TheInstance As New Lazy(Of T)(
            Function() TryCast(Activator.CreateInstance(GetType(T), True), T)
            )

        Protected Sub New()
        End Sub

        Public Shared ReadOnly Property Instance As T
            Get
                Return TheInstance.Value
            End Get
        End Property
        
    End Class
    
End NameSpace