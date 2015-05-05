Public Class Form1


    'No eliminar siguiente linea, esta linea ayudara para futuros cambios a agregar las flechas y que se puedan usar multiples teclas a la vez.
    Dim keysPressed As New HashSet(Of Keys)

    'Este es el valor unico que se le asigna a cada nueva bala, ayuda para poder diferenciarlas y utilizar de forma independiente.
    Dim bulletName = 1

    Dim life = 3

    Public life1
    Public life2
    Public life3
    Public life4

    Public bulletCounter = False
    Dim maxBullet = 125

    Dim times = 5
    Dim direction

    Public i = 4

    '---------!Esto es parte del codigo de la simulacion de barreras, no quitar!---------------
    'Estas siguientes variables son las que determinan si el jugador puede seguir avanzando a determinada direccion.
    'Esto ayuda para poder bloquear que el jugador siga avanzando solo con cambiar la variable deseada a "False".    
    Dim moveup As Boolean = True
    Dim movedown As Boolean = True
    Dim moveleft As Boolean = True
    Dim moveright As Boolean = True

    'Esta variable es la direccion de la flecha que se acaba de presionar. Se vera mas adelante la funcion
    Dim bulletDirection = "left"

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        titlescreen.Close()
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Environment.Exit(0)
        End If
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

                bulletShower()

            Case Keys.L
                bulletDirection = "right"
                XbulletCreator()

                bulletShower()

            Case Keys.I
                bulletDirection = "top"
                YbulletCreator()

                bulletShower()

            Case Keys.K
                bulletDirection = "down"
                YbulletCreator()

                bulletShower()
        End Select
    End Sub

    Sub bulletShower()
        If bulletCounter = True Then
            maxBullet -= 1
            Label1.Text = "Disparos disponibles: " & maxBullet
        End If
    End Sub

    Sub boundariesPlayer()
        If player.Top >= Me.Height - (player.Height + Panel1.Height) Then
            movedown = False
            player.Top = Me.Height - (player.Height + Panel1.Height)
        Else
            movedown = True
        End If
        If player.Top <= Panel1.Height Then
            player.Top = Panel1.Height
            moveup = False
        Else
            moveup = True
        End If


        If player.Left >= Me.Width - (player.Width + Panel3.Width) Then
            moveright = False
            player.Left = Me.Width - (player.Width + Panel3.Width)
        Else
            moveright = True
        End If
        If player.Left <= Panel3.Width Then
            player.Left = Panel3.Width
            moveleft = False
        Else
            moveleft = True
        End If

    End Sub

    Sub colision()
        Dim name As String
        Dim bullet As Panel

        For Each oControl In Me.Controls

            'En Espanol:
            '       Si el control que estoy leyendo en este instante es un panel hago lo siguiente
            If TypeOf (oControl) Is Panel Then
                name = DirectCast(oControl, Panel).Name

                If name.Contains("bullet") Then
                    bullet = oControl
                    If bullet.Left > villian1.Left And bullet.Left < villian1.Left + villian1.Width And bullet.Top > villian1.Top And bullet.Top < villian1.Top + villian1.Height Then
                        life1 -= 1
                        Me.Controls.Remove(bullet)

                        If life1 < 1 Then
                            villian1.Left = My.Computer.Screen.Bounds.Width * 2
                        End If
                    End If


                    If bullet.Left > villian2.Left And bullet.Left < villian2.Left + villian1.Width And bullet.Top > villian2.Top And bullet.Top < villian2.Top + villian2.Height Then
                        life2 -= 1
                        Me.Controls.Remove(bullet)

                        If life2 < 1 Then
                            villian2.Left = My.Computer.Screen.Bounds.Width * 2
                        End If
                    End If


                    If bullet.Left > villian3.Left And bullet.Left < villian3.Left + villian3.Width And bullet.Top > villian3.Top And bullet.Top < villian3.Top + villian3.Height Then
                        life3 -= 1
                        Me.Controls.Remove(bullet)

                        If life3 < 1 Then
                            villian3.Left = My.Computer.Screen.Bounds.Width * 2
                        End If
                    End If


                    If bullet.Left > villian4.Left And bullet.Left < villian4.Left + villian4.Width And bullet.Top > villian4.Top And bullet.Top < villian4.Top + villian4.Height Then
                        life4 -= 1
                        Me.Controls.Remove(bullet)

                        If life4 < 1 Then
                            villian4.Left = My.Computer.Screen.Bounds.Width * 2
                        End If
                    End If

                End If

            End If
        Next

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
            .Width = 15
            .Height = 7
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
            .Width = 7
            .Height = 15
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

        Dim bulletIntersect = New Panel

        Dim villian = New Panel

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
                bulletXright.Left += 5
                bulletXleft.Left -= 5







                'Lo mismo que en "right" y "left pero con "top" y down"
                '(duh!)
                If bullet.ToString.Contains("top") Then
                    bulletYtop = oControl
                End If


                If bullet.ToString.Contains("down") Then
                    bulletYdown = oControl
                End If


                bulletYtop.Top -= 5
                bulletYdown.Top += 5


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

    Public userlife As Integer
    Sub evilcolision()
        If player.Bounds.IntersectsWith(villian1.Bounds) Or player.Bounds.IntersectsWith(villian2.Bounds) Or player.Bounds.IntersectsWith(villian3.Bounds) Or player.Bounds.IntersectsWith(villian4.Bounds) Then
            userlife = userlife - 1
            buscarunpuntopararevivir() 'El nombre es bastante sugestivo en lo que se hace a continuación
        End If
        Select Case userlife
            Case 0
                vida1.Visible = False
            Case 1
                vida2.Visible = False
            Case 2
                vida3.Visible = False
        End Select
        'El proceso de arriba elimina solo las vidas que se muestran en el formulario. En el timer de collision se define lo que se hace cuando se pierde
    End Sub

    Private Sub collision_Tick(sender As Object, e As EventArgs) Handles collision.Tick
        If maxBullet <= 0 Then
            maxBullet = 0
            userlife = 0
        End If

        If userlife = 0 Then
            gameover()
            collision.Enabled = False
        Else
            colision()
            boundariesPlayer()
            evilcolision() 'Choque con un "malo"
        End If
    End Sub

    Sub gameover()
        'Agregar acá la pantalla de perder...        
        PictureBox1.Image = My.Resources.dead
        movedown = False
        moveleft = False
        moveright = False
        moveup = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name
        life1 = life
        life2 = life
        life3 = life
        life4 = life


        Panel2.Width = Me.Width * 0.04
        Panel3.Width = Me.Width * 0.04
        Panel4.Height = Me.Width * 0.04
        Panel1.Height = Me.Width * 0.04

        doorLeft.Width = Me.Width * 0.04
        doorRight.Width = Me.Width * 0.04
        doorTop.Height = Me.Width * 0.04
        doorBottom.Height = Me.Width * 0.04

        player.Width = Me.Width * 0.04
        player.Height = Me.Width * 0.04

        For Each oControl In Me.Controls
            If TypeOf (oControl) Is Panel Then
                name = DirectCast(oControl, Panel).Name

                If name.Contains("villian") Then
                    DirectCast(oControl, Panel).Width = Me.Width * 0.04
                    DirectCast(oControl, Panel).Height = Me.Width * 0.04
                End If
            End If
        Next

        randomVillian()

        doorLeft.Top = (Me.Height / 2 - doorLeft.Height / 2) - Panel1.Height
        doorRight.Top = (Me.Height / 2 - doorLeft.Height / 2) - Panel1.Height

        doorTop.Left = Me.Width / 2 - doorTop.Width / 2
        doorBottom.Left = (Me.Width / 2 - doorTop.Width / 2) - Panel1.Height

        userlife = 3
    End Sub

    Private Sub Rnd_Tick(sender As Object, e As EventArgs) Handles Rand.Tick
        If times > i Then
            Randomize()
            direction = CInt(Int((5 * Rnd()) + 1))
            times = 0
        End If

        Select Case direction
            Case 1
                '1-Right
                villian1.Left = 10 + villian1.Left

                '2-Left
                villian2.Left = villian2.Left - 10

                '3-Right
                villian3.Left = 10 + villian3.Left

                '4-Bottom
                villian4.Top = 10 + villian4.Top

            Case 2
                '1-Left
                villian1.Left = villian1.Left - 10

                '2-Right
                villian2.Left = villian2.Left + 10

                '3-Left
                villian3.Left = villian3.Left - 10

                '4-Left
                villian4.Left = villian4.Left - 10

            Case 3
                '1-Top
                villian1.Top = villian1.Top - 10

                '2-Bottom
                villian2.Top = 10 + villian2.Top

                '3-Top
                villian3.Top = villian3.Top - 10

                '4-Right
                villian4.Left = 10 + villian4.Left

            Case 4
                '1-Bottom
                villian1.Top = villian1.Top + 10

                '2-Top
                villian2.Top = villian2.Top - 10

                '3-Bottom
                villian3.Top = 10 + villian3.Top

                '4-Top
                villian4.Top = villian4.Top - 10
        End Select
        times += 1
    End Sub

    Private Sub villianBorder_Tick(sender As Object, e As EventArgs) Handles villianBorder.Tick
        Dim cName As String

        For Each cControl In Me.Controls

            If TypeOf (cControl) Is Panel Then
                cName = DirectCast(cControl, Panel).Name

                If cName.Contains("villian") Then

                    Select Case DirectCast(cControl, Panel).Left
                        Case Is >= Me.Width - (DirectCast(cControl, Panel).Width + Panel2.Width)
                            If cName.Contains("1") And life1 > 0 Then
                                villian1.Left = Me.Width - (villian1.Width + Panel2.Width)
                            End If
                            If cName.Contains("2") And life2 > 0 Then
                                villian2.Left = Me.Width - (villian1.Width + Panel2.Width)
                            End If
                            If cName.Contains("3") And life3 > 0 Then
                                villian3.Left = Me.Width - (villian1.Width + Panel2.Width)
                            End If
                            If cName.Contains("4") And life4 > 0 Then
                                villian4.Left = Me.Width - (villian1.Width + Panel2.Width)
                            End If

                        Case Is <= Panel3.Width
                            If cName.Contains("1") And life1 > 0 Then
                                villian1.Left = Panel3.Width
                                'moveleft1 = False
                            End If

                            If cName.Contains("2") And life2 > 0 Then
                                villian2.Left = Panel3.Width
                                'moveleft2 = False
                            End If

                            If cName.Contains("3") And life3 > 0 Then
                                villian2.Left = Panel3.Width
                                'moveleft3 = False
                            End If

                            If cName.Contains("4") And life4 > 0 Then
                                villian2.Left = Panel3.Width
                                'moveleft4 = False
                            End If

                        Case Else
                            'moveright1 = True
                            'moveright2 = True
                            'moveright3 = True
                            'moveright4 = True

                            'moveleft1 = True
                            'moveleft2 = True
                            'moveleft3 = True
                            'moveleft4 = True
                    End Select

                    Select Case DirectCast(cControl, Panel).Top
                        Case Is >= Me.Height - (DirectCast(cControl, Panel).Height + Panel4.Height)
                            If cName.Contains("1") And life1 > 0 Then
                                villian1.Top = Me.Height - (DirectCast(cControl, Panel).Height + Panel4.Height)
                            End If
                            If cName.Contains("2") And life2 > 0 Then
                                villian2.Top = Me.Height - (DirectCast(cControl, Panel).Height + Panel4.Height)
                            End If

                            If cName.Contains("3") And life3 > 0 Then
                                villian3.Top = Me.Height - (DirectCast(cControl, Panel).Height + Panel4.Height)
                            End If

                            If cName.Contains("4") And life4 > 0 Then
                                villian4.Top = Me.Height - (DirectCast(cControl, Panel).Height + Panel4.Height)
                            End If

                        Case Is <= Panel1.Height
                            If cName.Contains("1") And life1 > 0 Then
                                villian1.Top = Panel1.Height
                            End If

                            If cName.Contains("2") And life2 > 0 Then
                                villian2.Top = Panel1.Height
                            End If

                            If cName.Contains("3") And life3 > 0 Then
                                villian3.Top = Panel1.Height
                            End If

                            If cName.Contains("4") And life4 > 0 Then
                                villian4.Top = Panel1.Height
                            End If
                    End Select
                End If
            End If
        Next
    End Sub

    Sub randomVillian()
        Dim topNew = 0
        Dim leftNew = 0

        For Each oControl In Me.Controls

            'En Espanol:
            '       Si el control que estoy leyendo en este instante es un panel hago lo siguiente
            If TypeOf (oControl) Is Panel Then
                Name = DirectCast(oControl, Panel).Name

                If Name.Contains("villian") Then
                    Randomize()                    
                    topNew = CInt(Int(((Me.Height - Panel4.Height) * Rnd()) + Panel4.Height))
                    leftNew = CInt(Int(((Me.Width - Panel2.Width) * Rnd()) + Panel2.Width))
                    DirectCast(oControl, Panel).Left = leftNew
                    DirectCast(oControl, Panel).Top = topNew
                End If
            End If
        Next
    End Sub

    Private Sub buscarunpuntopararevivir()
        'La función es sencilla: Evitar el posible error de revivir en la posición de un malo y perder así por siempre
        'La explicación: Hay 5 puntos definidos y 4 malos. Se verá donde están los malos y se revivirá en el punto que no
        'Los puntos son las 4 esquinas y el centro de la pantalla
        'La lógica: Se revisa que cada malo no esté en las posiciones. Si están, se desabilita la opción de salir ahí.
        Dim esquinasi, esquinasd, esquinaii, esquinaid As Boolean
        'Primero se revisa el "villano 1"
        Select Case villian1.Location.X
            Case Is <= 255   'Esquinas del lado derecho
                Select Case villian1.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255  'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasi = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaii = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado izquierdo...solo que no afecta al jugador
                End Select
            Case Is >= (Me.Width - 355)  'Esquinas del lado izquierdo
                Select Case villian1.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasd = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaid = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado derecho...solo que no afecta al jugador
                End Select
            Case Else
                'Esto significa que no afecta ningún punto desde el inicio (facilitaría mucho trabajo poder asegurar que todos siempre estarán ...excepto que no)
        End Select
        'Ahora lo mismo de antes, solo que aplicado al "villano 2"
        Select Case villian2.Location.X
            Case Is <= 255   'Esquinas del lado derecho
                Select Case villian2.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255  'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasi = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaii = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado izquierdo...solo que no afecta al jugador
                End Select
            Case Is >= (Me.Width - 355)  'Esquinas del lado izquierdo
                Select Case villian2.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasd = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaid = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado derecho...solo que no afecta al jugador
                End Select
            Case Else
                'Esto significa que no afecta ningún punto desde el inicio (facilitaría mucho trabajo poder asegurar que todos siempre estarán ...excepto que no)
        End Select
        'Ahora con el villano 3
        Select Case villian3.Location.X
            Case Is <= 255   'Esquinas del lado derecho
                Select Case villian3.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255  'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasi = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaii = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado izquierdo...solo que no afecta al jugador
                End Select
            Case Is >= (Me.Width - 355)  'Esquinas del lado izquierdo
                Select Case villian3.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasd = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaid = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado derecho...solo que no afecta al jugador
                End Select
            Case Else
                'Esto significa que no afecta ningún punto desde el inicio (facilitaría mucho trabajo poder asegurar que todos siempre estarán ...excepto que no)
        End Select
        'Finalmente con el último malo
        Select Case villian4.Location.X
            Case Is <= 255   'Esquinas del lado derecho
                Select Case villian4.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255  'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasi = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaii = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado izquierdo...solo que no afecta al jugador
                End Select
            Case Is >= (Me.Width - 355)  'Esquinas del lado izquierdo
                Select Case villian4.Location.Y 'Esto significa que el villano está en la posición en X, sin embargo, no sabemos si realmente obstruye la salida del jugador. Por eso ahora se revisa la coordenada Y
                    Case Is <= 255 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinasd = True 'Después de revisar todos los puntos será útil este valor
                    Case Is >= (Me.Height - 355) 'Conclusión: Obstruye al jugador. Necesitamos evitar que reviva en esta esquina
                        esquinaid = True 'Después de revisar todos los puntos será útil este valor
                    Case Else
                        'Significa que el malo está en cerca de los puntos de salida del lado derecho...solo que no afecta al jugador
                End Select
            Case Else
                'Esto significa que no afecta ningún punto desde el inicio (facilitaría mucho trabajo poder asegurar que todos siempre estarán ...excepto que no)
        End Select
        'Finalmente se hace que el jugador reviva
        Select Case False
            Case Is = esquinasd
                player.Location = New Point((Me.Width - 200), 100)
            Case Is = esquinaii
                player.Location = New Point(100, (Me.Height - 200))
            Case Is = esquinasi
                player.Location = New Point(100, 100)
            Case Is = esquinaid
                player.Location = New Point((Me.Width - 200), (Me.Height - 200))
            Case Else
                player.Location = New Point((Me.Width / 2), (Me.Height / 2))
        End Select
    End Sub
End Class