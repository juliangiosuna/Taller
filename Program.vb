Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Console.WriteLine("Ingrese el punto que quiere ingresar")
        opcion = Console.ReadLine

        Select Case opcion
            Case 1

                Primer()

            Case 2

                Segundo()

            Case 3

                Tercero()

            Case 4

                Cuarto()

            Case 5

                Quinto()

            Case 6

                Sexto()
            Case 7

                Septimo()

            Case 8
                Octavo()
            Case 9
                Noveno()
            Case 10
                Decimo()
            Case 11
                Undecimo()
            Case 12
                Duodecimo()



        End Select
    End Sub

    Sub Primer()
        Dim num As Integer
        Console.WriteLine("Ingrese un numero")
        num = Console.ReadLine

        If (num Mod 2 = 0 And num > 0) Then
            Console.WriteLine("El numero es positivo y par")
        Else
            Console.WriteLine("El numero no es positivo ni par")
        End If

    End Sub
    Sub Segundo()
        Dim num1 As Integer
        Console.WriteLine("Ingrese un numero")
        num1 = Console.ReadLine

        If (num1 Mod 3 = 0 Or num1 Mod 5 = 0) Then

            num1 = num1 ^ 3

            Console.WriteLine("El cubo del valor ingresaso es:{0}", num1)
        Else
            Console.WriteLine("el numero no es multiplo de 3 ni de 5")
        End If


    End Sub
    Sub Tercero()

        Dim num1 As Integer
        Console.WriteLine("Ingrese un numero")
        num1 = Console.ReadLine

        If (num1 Mod 4 = 0 Or num1 Mod 16 = 0) Then

            num1 = num1 ^ 2

            Console.WriteLine("El cubo del valor ingresaso es:{0}", num1)
        Else
            Console.WriteLine("el numero no es multiplo de 4 ni de 16")
        End If

    End Sub
    Sub Cuarto()
        Dim nota As Integer
        Console.WriteLine("Ingrese la nota")
        nota = Console.ReadLine

        If (nota >= 0 And nota <= 40) Then

            Console.WriteLine("Pésimo, Aplazado sin oportunidad")

        ElseIf (nota >= 41 And nota <= 45) Then

            Console.WriteLine("Deficiente, Aplazado a reparación")

        ElseIf (nota >= 46 And nota <= 50) Then

            Console.WriteLine("Bajo, Aplazado repetir examen")

        ElseIf (nota >= 51 And nota <= 60) Then

            Console.WriteLine("Regular, No aplazado – Remedial")

        ElseIf (nota >= 61 And nota <= 70) Then

            Console.WriteLine("Bien")

        ElseIf (nota >= 71 And nota <= 80) Then

            Console.WriteLine("Muy bien")

        ElseIf (nota >= 81 And nota <= 100) Then

            Console.WriteLine("Excelente")

        End If




    End Sub
    Sub Quinto()

        Dim gal As Double
        Dim Total As Double
        Dim Opc As Integer
        Const premiumExtra As Double = 5000
        Const premium As Double = 3900
        Const Corriente As Double = 3200
        Console.WriteLine("Ingrese 1. para gasolina premium Extra" & vbCrLf & "2. Para gasolina premium ")
        Console.WriteLine("3. Corriente")
        Opc = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de galones")
        gal = Console.ReadLine

        If (Opc = 1) Then

            Total = gal * (premiumExtra * 4.54609)
            Console.WriteLine("EL precio total con gasolina Premium Extra  {0}", Total)
            Console.WriteLine("la cantidad de galones es:{0}", gal)

        ElseIf (Opc = 2) Then

            Total = gal * (premium * 4.54609)
            Console.WriteLine("EL precio total Premium {0}", Total)
            Console.WriteLine("la cantidad de galones es:{0}", gal)


        ElseIf (Opc = 3) Then

            Total = gal * (premium * 4.54609)
            Console.WriteLine("EL precio total Corriente {0}", Total)
            Console.WriteLine("la cantidad de galones es:{0}", gal)

        End If





    End Sub
    Sub Sexto()
        Dim mb As Double
        Dim nivel As Integer
        Dim total As Double
        Const nivel1 As Double = 5000
        Const nivel2 As Double = 7000
        Const nivel3 As Double = 9000
        Const nivel4 As Double = 15000
        Const nivel5 As Double = 22000
        Const nivel6 As Double = 30000
        Const nivelesSuperiores As Double = 35000

        Console.WriteLine("Ingrese la cantidad de MB")
        mb = Console.ReadLine
        Console.WriteLine("Ingrese el nivel")
        nivel = Console.ReadLine

        If (nivel = 1) Then
            total = nivel1 * mb
            Console.WriteLine("el total a pagar es {0}", total)
        ElseIf (nivel = 2) Then
            total = nivel2 * mb
            Console.WriteLine("el total a pagar es {0}", total)
        ElseIf (nivel = 3) Then
            total = nivel3 * mb
            Console.WriteLine("el total a pagar es {0}", total)
        ElseIf (nivel = 4) Then
            total = nivel4 * mb
            Console.WriteLine("el total a pagar es {0}", total)
        ElseIf (nivel = 5) Then
            total = nivel5 * mb
            Console.WriteLine("el total a pagar es {0}", total)
        ElseIf (nivel = 6) Then
            total = nivel6 * mb
            Console.WriteLine("el total a pagar es {0}", total)
        ElseIf (nivel > 6) Then
            total = nivelesSuperiores * mb
            Console.WriteLine("el total a pagar es {0}", total)
        End If


    End Sub
    Sub Septimo()
        Dim horas As Double
        Dim sueldo As Double
        Dim total As Double

        Console.WriteLine("Ingrese las horas trabajadas")
        horas = Console.ReadLine
        Console.WriteLine("Ingrese el sueldo por hora")
        sueldo = Console.ReadLine

        total = horas * sueldo

        Console.WriteLine("el total a pagar al trabajador es: {0}", total)


    End Sub
    Sub Octavo()

        Dim interes As Double
        Dim dias As Integer
        Dim dinero As Double
        Dim total As Double
        Dim interesT As Double

        Console.WriteLine("Ingrese el interes")
        interes = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de dias")
        dias = Console.ReadLine
        Console.WriteLine("Ingrese la cantidad de dinero")
        dinero = Console.ReadLine

        total = (dinero * interes) * dias
        interesT = total - dinero


        Console.WriteLine("La cantidad total con los intereses son: {0}", total)
        Console.WriteLine("los intereses pagados son: {0}", interesT)


    End Sub
    Sub Noveno()

        Dim num1 As Integer
        Dim num2 As Integer
        Console.WriteLine("Ingrese el numero 1")
        num1 = Console.ReadLine
        Console.WriteLine("Ingrese el numero 2")
        num2 = Console.ReadLine

        If (num1 > 0 And num2 < 0) Then

            Console.WriteLine("el numero 1 es positivo")
        Else

            Console.WriteLine("el numero 2 es positivo")

        End If


    End Sub
    Sub Decimo()
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim suma As Double
        Console.WriteLine("Ingrese el numero 1")
        num1 = Console.ReadLine
        Console.WriteLine("Ingrese el numero 2")
        num2 = Console.ReadLine
        Console.WriteLine("Ingrese el numero 3")
        num3 = Console.ReadLine

        suma = num1 + num2 + num3

        Console.WriteLine("la suma es:{0}", suma)

    End Sub
    Sub Undecimo()

        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim suma As Double


        Console.WriteLine("Ingrese el numero 1")
        num1 = Console.ReadLine
        Console.WriteLine("Ingrese el numero 2")
        num2 = Console.ReadLine
        Console.WriteLine("Ingrese el numero 3")
        num3 = Console.ReadLine

        If (num1 Mod 2 = 0 Or num2 Mod 2 = 0 Or num3 Mod 2 = 0) Then

            Console.WriteLine("Todos los numeros no son impares")
        Else
            suma = num1 + num2 + num3
            Console.WriteLine("la suma es: {0}", suma)


        End If



    End Sub
    Sub Duodecimo()

        Dim compraSin As Double
        Dim TotalIva As Double
        Dim Totalc As Double
        Const iva As Double = 19%

        Console.WriteLine("Ingrese el total de la compra")
        Totalc = Console.ReadLine

        compraSin = Totalc - iva
        TotalIva = Totalc * iva

        Console.WriteLine("El total de la compra sin iva es: {0} ", compraSin)
        Console.WriteLine("El total del iva es:{0}", TotalIva)


    End Sub
End Module
