Imports System
Module evaluacion_de_conocimientos
    Sub Main(args As String())
        Dim ids(19) As Integer
        Dim preguntas(19) As String
        Dim opcionA(19) As String
        Dim opcionB(19) As String
        Dim opcionC(19) As String
        Dim opcionD(19) As String
        Dim respuestasCorrectas(19) As String
        Dim respuestasEstudiante(19) As String
        Dim estados(19) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------------'
        '--|menu_principal_evaluacion_de_conocimientos|--'
        '------------------------------------------------'
        Do
            Console.WriteLine("menu principal evaluacion de conocimientos")
            Console.WriteLine("1) Registrar pregunta")
            Console.WriteLine("2) Editar pregunta")
            Console.WriteLine("3) Listar preguntas")
            Console.WriteLine("4) Buscar pregunta")
            Console.WriteLine("5) Eliminar pregunta")
            Console.WriteLine("6) Realizar evaluacion")
            Console.WriteLine("7) Ver resultados")
            Console.WriteLine("8) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '------------------------'
                '--|registrar_pregunta|--'
                '------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas preguntas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Ingrese la pregunta: ")
                        preguntas(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion A: ")
                        opcionA(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion B: ")
                        opcionB(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion C: ")
                        opcionC(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la opcion D: ")
                        opcionD(cantidad) = Console.ReadLine()
                        Console.Write("Ingrese la respuesta correcta (A/B/C/D): ")
                        Dim respuesta As String = Console.ReadLine().ToUpper()
                        If respuesta = "A" OrElse respuesta = "B" OrElse respuesta = "C" OrElse respuesta = "D" Then
                            respuestasCorrectas(cantidad) = respuesta
                            respuestasEstudiante(cantidad) = "Sin responder"
                            estados(cantidad) = "Pendiente"
                            cantidad += 1
                            Console.WriteLine("Pregunta registrada correctamente.")
                            Console.WriteLine("ID: " & ids(cantidad - 1) & " | Pregunta: " & preguntas(cantidad - 1) & " | A: " & opcionA(cantidad - 1) & " | B: " & opcionB(cantidad - 1) & " | C: " & opcionC(cantidad - 1) & " | D: " & opcionD(cantidad - 1) & " | Correcta: " & respuestasCorrectas(cantidad - 1))
                        Else
                            Console.WriteLine("La respuesta correcta debe ser A, B, C o D.")
                        End If
                    End If
                '---------------------'
                '--|editar_pregunta|--'
                '---------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la pregunta a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nueva pregunta: ")
                            preguntas(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion A: ")
                            opcionA(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion B: ")
                            opcionB(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion C: ")
                            opcionC(posicion) = Console.ReadLine()
                            Console.Write("Nueva opcion D: ")
                            opcionD(posicion) = Console.ReadLine()
                            Console.Write("Nueva respuesta correcta (A/B/C/D): ")
                            Dim nuevaRespuesta As String = Console.ReadLine().ToUpper()
                            If nuevaRespuesta = "A" OrElse nuevaRespuesta = "B" OrElse nuevaRespuesta = "C" OrElse nuevaRespuesta = "D" Then
                                respuestasCorrectas(posicion) = nuevaRespuesta
                                respuestasEstudiante(posicion) = "Sin responder"
                                estados(posicion) = "Pendiente"
                                Console.WriteLine("Pregunta actualizada correctamente.")
                                Console.WriteLine("ID: " & ids(posicion) & " | Pregunta: " & preguntas(posicion) & " | A: " & opcionA(posicion) & " | B: " & opcionB(posicion) & " | C: " & opcionC(posicion) & " | D: " & opcionD(posicion) & " | Correcta: " & respuestasCorrectas(posicion) & " | Respuesta estudiante: " & respuestasEstudiante(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("La respuesta correcta debe ser A, B, C o D.")
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|listar_preguntas|--'
                '----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '---------------------'
                '--|buscar_pregunta|--'
                '---------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por pregunta")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID de la pregunta: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Pregunta: " & preguntas(posicion) & " | A: " & opcionA(posicion) & " | B: " & opcionB(posicion) & " | C: " & opcionC(posicion) & " | D: " & opcionD(posicion) & " | Correcta: " & respuestasCorrectas(posicion) & " | Respuesta estudiante: " & respuestasEstudiante(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el texto de la pregunta: ")
                            Dim preguntaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If preguntas(i).ToLower().Contains(preguntaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron preguntas.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '-----------------------'
                '--|eliminar_pregunta|--'
                '-----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | A: " & opcionA(i) & " | B: " & opcionB(i) & " | C: " & opcionC(i) & " | D: " & opcionD(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la pregunta a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                preguntas(i) = preguntas(i + 1)
                                opcionA(i) = opcionA(i + 1)
                                opcionB(i) = opcionB(i + 1)
                                opcionC(i) = opcionC(i + 1)
                                opcionD(i) = opcionD(i + 1)
                                respuestasCorrectas(i) = respuestasCorrectas(i + 1)
                                respuestasEstudiante(i) = respuestasEstudiante(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            preguntas(cantidad) = ""
                            opcionA(cantidad) = ""
                            opcionB(cantidad) = ""
                            opcionC(cantidad) = ""
                            opcionD(cantidad) = ""
                            respuestasCorrectas(cantidad) = ""
                            respuestasEstudiante(cantidad) = ""
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Pregunta eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|realizar_evaluacion|--'
                '-------------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen preguntas para realizar la evaluacion.")
                    Else
                        Dim correctas As Integer = 0
                        Dim incorrectas As Integer = 0
                        Console.WriteLine("========================================")
                        Console.WriteLine("       EVALUACION DE CONOCIMIENTOS")
                        Console.WriteLine("========================================")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine()
                            Console.WriteLine("Pregunta " & (i + 1) & ": " & preguntas(i))
                            Console.WriteLine("A) " & opcionA(i))
                            Console.WriteLine("B) " & opcionB(i))
                            Console.WriteLine("C) " & opcionC(i))
                            Console.WriteLine("D) " & opcionD(i))
                            Dim respuestaEstudiante As String = ""
                            Do
                                Console.Write("Seleccione su respuesta (A/B/C/D): ")
                                respuestaEstudiante = Console.ReadLine().ToUpper()
                                If respuestaEstudiante <> "A" AndAlso respuestaEstudiante <> "B" AndAlso respuestaEstudiante <> "C" AndAlso respuestaEstudiante <> "D" Then
                                    Console.WriteLine("Respuesta no valida. Seleccione A, B, C o D.")
                                End If
                            Loop While respuestaEstudiante <> "A" AndAlso respuestaEstudiante <> "B" AndAlso respuestaEstudiante <> "C" AndAlso respuestaEstudiante <> "D"
                            respuestasEstudiante(i) = respuestaEstudiante
                            If respuestasEstudiante(i) = respuestasCorrectas(i) Then
                                estados(i) = "Correcta"
                                correctas += 1
                                Console.WriteLine("Respuesta correcta.")
                            Else
                                estados(i) = "Incorrecta"
                                incorrectas += 1
                                Console.WriteLine("Respuesta incorrecta.")
                            End If
                        Next
                        Dim porcentaje As Double = (correctas * 100) / cantidad
                        Dim nota As Double = (correctas * 5) / cantidad
                        Dim resultado As String
                        If nota >= 3 Then
                            resultado = "APROBADO"
                        Else
                            resultado = "REPROBADO"
                        End If
                        Console.WriteLine()
                        Console.WriteLine("========================================")
                        Console.WriteLine("          RESULTADO FINAL")
                        Console.WriteLine("========================================")
                        Console.WriteLine("Total de preguntas: " & cantidad & " | Correctas: " & correctas & " | Incorrectas: " & incorrectas & " | Porcentaje: " & porcentaje.ToString("N2") & "% | Nota: " & nota.ToString("N2") & " | Resultado: " & resultado)
                    End If
                '--------------------'
                '--|ver_resultados|--'
                '--------------------'
                Case 7
                    If cantidad = 0 Then
                        Console.WriteLine("No existen resultados disponibles.")
                    Else
                        Dim correctas As Integer = 0
                        Dim incorrectas As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i) = "Correcta" Then
                                correctas += 1
                            ElseIf estados(i) = "Incorrecta" Then
                                incorrectas += 1
                            End If
                        Next
                        Dim respondidas As Integer = correctas + incorrectas
                        If respondidas = 0 Then
                            Console.WriteLine("La evaluacion aun no ha sido realizada.")
                        Else
                            Dim porcentaje As Double = (correctas * 100) / respondidas
                            Dim nota As Double = (correctas * 5) / respondidas
                            Dim resultado As String
                            If nota >= 3 Then
                                resultado = "APROBADO"
                            Else
                                resultado = "REPROBADO"
                            End If
                            Console.WriteLine("Total respondidas: " & respondidas & " | Correctas: " & correctas & " | Incorrectas: " & incorrectas & " | Porcentaje: " & porcentaje.ToString("N2") & "% | Nota: " & nota.ToString("N2") & " | Resultado: " & resultado)
                            For i As Integer = 0 To cantidad - 1
                                Console.WriteLine("ID: " & ids(i) & " | Pregunta: " & preguntas(i) & " | Correcta: " & respuestasCorrectas(i) & " | Respuesta estudiante: " & respuestasEstudiante(i) & " | Estado: " & estados(i))
                            Next
                        End If
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 8
                    Console.WriteLine("Gracias por utilizar Evaluacion de Conocimientos.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 8
    End Sub
End Module