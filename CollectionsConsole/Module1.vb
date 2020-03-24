Module Module1

    Sub Main()
        Dictionaries()
        Queues()
        Stacks()

        'don't exit.
        Console.ReadKey()
    End Sub
    Private Sub Dictionaries()
        Dim fortunes As New Dictionary(Of String, String)()

        fortunes.Add("Vincent", "Be a good friend and a fair enemy.")
        fortunes.Add("Alex", "A thrilling time is in store for you.")
        fortunes.Add("Bob", "The expanse of your intelligence is a void no universe could ever fill.")

        Dim myName = "Vincent"

        Dim doesContainKey = fortunes.ContainsKey(myName)
        Console.WriteLine($"Is Vincent's fortune in the dictionary?: {doesContainKey}")
        'Console.WriteLine($"Vincent's Fortune: {fortunes(myName)}")

        For Each kvp In fortunes
            Console.WriteLine($"Key: {kvp.Key}   Value:{kvp.Value}")
        Next
    End Sub

    Private Sub Stacks()
        Dim numbers = New Stack(Of Integer)

        numbers.Push(1)
        numbers.Push(2)
        numbers.Push(3)
        numbers.Push(4)
        numbers.Push(5)

        'When iterating over a Stack the values are looped through in the order they would
        'be popped in.
        For Each number In numbers
            Console.WriteLine(number)
        Next

        Console.WriteLine($"Popping {numbers.Pop()}")
        Console.WriteLine($"Peek at the next item to destack: {numbers.Peek()}")
        Console.WriteLine($"Popping {numbers.Pop()}")
    End Sub
    Private Sub Queues()
        Dim numbers As New Queue(Of String)
        Dim numbersNumbers As New Queue(Of Integer)
        numbersNumbers.Enqueue(1)

        numbers.Enqueue("one")
        numbers.Enqueue("two")
        numbers.Enqueue("three")
        numbers.Enqueue("four")

        For Each number In numbers
            Console.WriteLine(number)
        Next

        Console.WriteLine($"Dequeuing {numbers.Dequeue}")
        Console.WriteLine($"Peek at next item to dequeue: {numbers.Peek()}")
        Console.WriteLine($"Dequeuing {numbers.Dequeue}")
    End Sub

End Module
