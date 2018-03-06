Imports System.Net
Imports System.IO

Module Module1

    Sub Main()
        Console.Title = "Rabbit Hash Cracker"
        Console.ForegroundColor = ConsoleColor.DarkGray
        Console.WriteLine("             __ ")
        Console.WriteLine("           /    \ ")
        Console.WriteLine("           | /| \ ")
        Console.WriteLine("           | ||_/ ")
        Console.WriteLine("           | || ")
        Console.WriteLine("     /\    | || ")
        Console.WriteLine("   /   |   | || ")
        Console.WriteLine(" /  |\ |   | || ")
        Console.WriteLine("|__/|| |   | || ")
        Console.WriteLine("    || |   | || ")
        Console.WriteLine("    || |   | || ")
        Console.WriteLine("   /    ~~~    \ ")
        Console.WriteLine("  |   ^     ^   | ")
        Console.WriteLine("  |  (o)   (o)  | ")
        Console.WriteLine("  \      !      / ")
        Console.WriteLine("  >\     ^     /< ")
        Console.WriteLine("    \_________/ ")
        Console.WriteLine("      (\   /) ")
        Console.WriteLine("      ( >o< )")
        Console.WriteLine("      (/   \)v1.0 ")
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.WriteLine("# Hello, welcome to Rabbit Hash Cracker based on hashtoolkit.")
        Console.WriteLine("# Coded By Riyad Pathan (fb/Syn7axErrOr)")
        Console.WriteLine()
start:
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("Enter the Hash (ex: c11855a9627cee943e2637d047f782c9173df781)")
        Console.ForegroundColor = ConsoleColor.DarkGray
        Dim hash As String
        Console.WriteLine()
        hash = Console.ReadLine()
        Try
            Dim req As HttpWebRequest = DirectCast(WebRequest.Create("http://www.hashtoolkit.com/reverse-hash?hash=" & hash), HttpWebRequest)
            req.Method = "Get"
            req.UserAgent = "mozilla/4.0 (compatible; MSIE 6.0; windows NT 6.1)"
            req.ContentType = "Application / x - www-form-urlencoded"
            Dim Resp As HttpWebResponse
            Resp = DirectCast(req.GetResponse(), HttpWebResponse)
            Dim Reqreader As New StreamReader(Resp.GetResponseStream())
            Dim Result As String = Reqreader.ReadToEnd
            If Result.Contains("Invalid Input!") Then
                Console.WriteLine("Invalid Input")
            Else
                Try
                    Dim Alg As String = (Split(Result, "<td>")(1).Split("</td>")(0))
                    Dim Decry As String = (Split(Result, "<span title=""decrypted " & Alg & " hash"">")(1).Split("</td>")(0))
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.WriteLine("Algorithm: " + Alg & vbNewLine & "Hash: " + hash & vbNewLine & "Decrypted: " + Decry)
                Catch ex As Exception
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.WriteLine("  ___")
                    Console.WriteLine(" | __|_ _ _ _ ___ _ _  ")
                    Console.WriteLine(" | _|| '_| '_/ _ \ '_| ")
                    Console.WriteLine(" |___|_| |_| \___/_| unable to crack hash... :|")
                End Try 
            End If
        Catch ex As Exception

        End Try
        Console.WriteLine()
        GoTo start
        Console.ReadLine()
    End Sub

End Module
