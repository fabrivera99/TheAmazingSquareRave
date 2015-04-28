Public Class Form1


    'No eliminar siguiente linea, esta linea ayudara para futuros cambios a agregar las flechas y que se puedan usar multiples teclas a la vez.
    Dim keysPressed As New HashSet(Of Keys)

    'Este es el valor unico que se le asigna a cada nueva bala, ayuda para poder diferenciarlas y utilizar de forma independiente.
    Dim bulletName = 1


    '---------!Esto es parte del codigo de la simulacion de barreras, no quitar!---------------
    'Estas siguientes variables son las que determinan si el jugador puede seguir avanzando a determinada direccion.
    'Esto ayuda para poder bloquear que el jugador siga avanzando solo con cambiar la variable deseada a "False".
    Dim moveup As Boolean = True
    Dim movedown As Boolean = True
    Dim moveleft As Boolean = True
    Dim moveright As Boolean = True

    'Esta variable es la direccion de la flecha que se acaba de presionar. Se vera mas adelante la funcion
    Dim bulletDirection = "left"


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Keydown clasico. Obviamente estas cuantas lineas solo mueven al jugador 20 pixeles.
        Select Case e.KeyCode
            Case Keys.W
                If moveup = True Then
                    player.Top -= 20
                End If

            Case Keys.S
                If movedown = True Then
                    player.Top += 20
                End If

            Case Keys.D
                If moveright = True Then
                    player.Left += 20
                End If

            Case Keys.A
                If moveleft = True Then
                    player.Left -= 20
                End If



                'Estas son las teclas que activan el disparo, aqui se cambia la variable "bulletDirection".
            Case Keys.J
                bulletDirection = "left"

                'En realidad no pasa nada importante en "XbulletCreator" pero igual lo voy a explicar en el sub.
                'Bajar un cacho mas para ver.
                XbulletCreator()

            Case Keys.L
                bulletDirection = "right"
                XbulletCreator()


            Case Keys.I
                bulletDirection = "top"
                YbulletCreator()

            Case Keys.K
                bulletDirection = "down"
                YbulletCreator()


        End Select
    End Sub


    '----------ESTOS DOS SUBS SON ESCENSIALES PARA EL CODIGO, NO MODIFICAR NI QUITAR---------
    Sub XbulletCreator()
        'Okay, vamos a lo serio.        
        'Los objetos creados del lado del codigo es un objeto "dinamico", los creados del lado del disenador se llaman "estaticos"


        '"BulletX" es una variable? No, en realidad no, "bulletX" es un objeto.
        'Los objetos dinamicos se conforman de la misma manera que un objeto estatico
        Dim bulletX As Panel = New Panel

        'Se coloca "New" porque yo quiero que se cree un nuevo objeto cada vez que vaya a "XbulletCreator".
        'Si no se coloca "New" solo creara un panel.

        With bulletX
            'Le digo las propiedades de "bulletX"

            .Top = player.Top + 50
            .Left = player.Left + 50


            'Aqui es donde se coloca el nombre, para evitar errores se tiene que hacer que el nombre sea unico cada vez que el objeto sea creado
            'Yo coloque que el nombre estuviera basado en su codigo unico y direccion.
            .Name = "bulletX" & bulletName & bulletDirection


            .BackColor = Color.Yellow
            .Width = 30
            .Height = 15
        End With

        '-------------Esta linea es importate------------
        'Esta linea agrega el control recien creado a nuestra ventana.
        Me.Controls.Add(bulletX)

        'Le suma uno al numero que identifica cada bala
        bulletName += 1
    End Sub


    '------------Lo mismo que en XbulletCreator pero con Y------------
    '(duh!)
    Sub YbulletCreator()
        Dim bulletX As Panel = New Panel
        With bulletX
            .Top = player.Top + 50
            .Left = player.Left + 50
            .Name = "bulletY" & bulletName & bulletDirection
            .BackColor = Color.Yellow
            .Width = 15
            .Height = 30
        End With

        Me.Controls.Add(bulletX)
        bulletName += 1
    End Sub


    '--------------- ESTE TICK Y ESTE RELOJ SON ESCENCIALES PARA EL FUNCIONAMIENTO DEL DISPARO, NO QUITAR NI EDITAR----------------------
    'Esta parte es por mucho la parte mas confusa, intente hacerlo lo mas simple pero igual esta algo trabado.
    Private Sub moveBullet_Tick(sender As Object, e As EventArgs) Handles moveBullet.Tick

        'Mas creacion de nuevos objetos. (!yeii!)

        '"bullet" se va a explicar mas adelante
        Dim bullet

        'Estos nuevos controles son para poder diferenciar con mucha mas facilidad entre cada direccion y sentido.
        'Creo que esta bastante claro que direccion y que sentido representa cada control; pero igual lo voy a explicar
        'X = Sentido; right = Direccion.
        Dim bulletXright = New Panel
        Dim bulletXleft = New Panel

        Dim bulletYtop = New Panel
        Dim bulletYdown = New Panel



        'Aqui viene la parte complicada
        '"For Each" es literalmente lo que su traduccion dice.

        'En Espanol podriamos decir que la siguiente linea dice:
        '           Por cada control (oControl) que yo tenga (Me) entonces haga esto.
        '           Cada control que yo tenga es igual a "oControl".        
        For Each oControl In Me.Controls

            'En Espanol:
            '       Si el control que estoy leyendo en este instante es un panel hago lo siguiente
            If TypeOf (oControl) Is Panel Then

                'Okay, aqui explico "bullet"
                '"bullet" es un string, aqui es donde examina y toma la decicion a cual direccion debera de ir.
                bullet = DirectCast(oControl, Panel).Name
                '"DirectCast" en Espanol:
                '       El control que esta leyendo en este instante, cuenteme mas de el.

                'En este cast yo le pido que me de la informacion del nombre. Recordar que el nombre es unico y se le asigna en los Subs "Creator"


                'Como en el nombre coloque la direccion, entonces le pregunto si en el nombre de lo escaneado en este instante contiene "right"
                'Si contiene "right" entonces al control "bulletXright" que creamos hace un rato sera igual al creado, ...
                '... esto nos ayudara a tratar a todos los "right" como una sola clase que hacen todos unanimamente lo mismo
                If bullet.ToString.Contains("right") Then
                    bulletXright = oControl
                End If

                'lo mismo que lo anterior pero con left
                '(duh!)
                If bullet.ToString.Contains("left") Then
                    bulletXleft = oControl
                End If


                'Aqui es donde nos ayuda crearlo como un objeto distinto a "oControl"
                'Si se usara "oControl" para poder mover el control tendriamos que usar un cast y muchos "If".
                '(Me gustaria profundizar mas como ses podria hacer sin usar otro objeto pero me temo que tomaria muchas lineas).
                bulletXright.Left += 20
                bulletXleft.Left -= 20







                'Lo mismo que en "right" y "left pero con "top" y down"
                '(duh!)
                If bullet.ToString.Contains("top") Then
                    bulletYtop = oControl
                End If


                If bullet.ToString.Contains("down") Then
                    bulletYdown = oControl
                End If


                bulletYtop.Top -= 20
                bulletYdown.Top += 20




                'Estas lineas son bastantes obvias y ya me aburri de explicar mi codigo
                'Les dejo para analizar, supongo.
                'PISTA: Evaluan las barrearas de la pantalla.

                If bullet.ToString.Contains("bullet") Then

                    If DirectCast(oControl, Panel).Top > Me.Height Then
                        Me.Controls.Remove(DirectCast(oControl, Panel))
                        bulletName -= 1
                    End If

                    If DirectCast(oControl, Panel).Left > Me.Width Then
                        Me.Controls.Remove(DirectCast(oControl, Panel))
                        bulletName -= 1
                    End If




                    If DirectCast(oControl, Panel).Top < -30 Then
                        Me.Controls.Remove(DirectCast(oControl, Panel))
                        bulletName -= 1
                    End If

                    If DirectCast(oControl, Panel).Left < -30 Then
                        Me.Controls.Remove(DirectCast(oControl, Panel))
                        bulletName -= 1
                    End If

                End If
            End If
        Next



    End Sub
End Class