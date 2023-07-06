'
' Created by SharpDevelop.
' User: Malek
' Date: 20/12/2020
' Time: 09:27 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	
	Dim grid(3,3) As Char
	Dim row,column As Integer
	
	Dim win As Boolean
	Dim P1 , P2 As String
	
	Sub Main()
		

		
		Console.WriteLine("enter first player name ( X )")
		P1=Console.ReadLine

		Console.WriteLine("enter Second player name( O )")
		P2 =Console.ReadLine

			
		start()
		
			
		While(win=False)
			
			turn1(grid)
			Console.Clear()
			update(grid)
			
			If(win1()=True) Then
				Console.Clear()
				Console.WriteLine(P1 & " WON")
				Exit While
			End If
			
			If(draw()=True) Then
				Console.Clear()
				Console.WriteLine("Game is draw")
				Exit While
				End If
			turn2(grid)
			Console.Clear()
			update(grid)
			
			If(win2()=True) Then
				Console.Clear()
				Console.WriteLine(P2 & " WON")
				Exit While
			End If
			
			If(draw()=True) Then
				Console.Clear()
				Console.WriteLine("Game is draw")
				Exit While
				
				
			End If
		End While
		
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
	
	Sub start()
		Console.clear()
		For i=1 To 3 
			For j=1 To 3
				grid(i,j)="-"
				Next
			
			 Next
				
		
		Console.WriteLine("  1 2 3")
		Console.WriteLine("1 - - -")
		Console.WriteLine("2 - - -")
		Console.WriteLine("3 - - -")
		Console.WriteLine("")
		
	End Sub
	
	Sub turn1(  byref grid(,) As Char)
		Console.WriteLine(p1 & "'s turn")
		Console.WriteLine("")
		
			Try
			Console.WriteLine("Enter Row number")
			row = Console.ReadLine()

			Console.WriteLine("Enter Column number")
			column=Console.ReadLine
			
			If (grid(row,column)="-") Then
				grid(row,column)="X"
				
			Else
				Console.writeline("")
				Console.Clear
				
				Console.WriteLine("Slot is occupied,choose another slot.")
				
				update(grid)
				turn1(grid)
			End If
	
			
			Catch x As IndexOutOfRangeException
				Console.Clear()
				Console.WriteLine("Choose number between 1 & 3 for row & column")
				update(grid)
				turn1(grid)
			End Try
			
		
	End Sub
	
	Sub turn2 ( byref grid(,) As Char)
		
		Console.WriteLine(p2 & "'s turn")
		Console.WriteLine("")
		
			Try
			Console.WriteLine("Enter Row number")
			row=Console.ReadLine
			
			Console.WriteLine("Enter Column number")
			column=Console.ReadLine
			
	
	        If(grid(row,column)="-") Then
		           grid(row,column)="O"
		
	        Else 
	        	Console.Clear()
	        	
	        	Console.WriteLine("Slot is occupied,choose another slot.")
	        	update(grid)
				turn2(grid)
		
				   End If
				
			
			Catch x As IndexOutOfRangeException
				Console.Clear()
				Console.WriteLine("Choose number between 1 & 3 for row & column")
				update(grid)
				turn2(grid)
			End Try
			
			
	End Sub
	
	Sub update(grid(,) As Char)
		Console.WriteLine("")
		
		Console.WriteLine("  1 2 3")
		For i=1 To 3
			Dim j As Integer=1
			Console.Write(i &" ")
			Do
				
			Console.Write(grid(i,j) & " ")
			j=j+1
			Loop Until(j=4)
			Console.WriteLine(" ")
				
		Next
		Console.WriteLine("")
	End Sub
	
	
	Function win1 () As Boolean
		
				If(grid(1,1)="X" And grid(2,2)="X" And grid(3,3)="X") Then
					
					
					Return True
					
					
				ElseIf(grid(1,3)="X" And grid(2,2)="X" And grid(3,1)="X") Then
					Return True
					
				End If
				
				For i=1 To 3
					If(grid(i,1)="X" And grid(i,2)="X" And grid(i,3)="X") Then
						Return True
					End If
				Next
				Dim count As Integer=0
				For i=1 To 3
					For j=1 To 3
						If(grid(j,i)="X") Then
							count=count+1
						End If
						
					Next
					If (count=3) Then
						Return True
					End If
					count=0
				Next
				
		
	End Function
	
	Function win2() As Boolean
		
				If(grid(1,1)="O" And grid(2,2)="O" And grid(3,3)="O") Then
					
					Return True
					
					
				ElseIf(grid(1,3)="O" And grid(2,2)="O" And grid(3,1)="O") Then
					Return True
					
					
				End If
				
				For i=1 To 3
					If(grid(i,1)="O" And grid(i,2)="O" And grid(i,3)="O") Then
						Return True
					End If
				Next
				Dim count As Integer=0
				For i=1 To 3
					For j=1 To 3
						If(grid(j,i)="O") Then
							count=count+1
						End If
						
					Next
					If (count=3) Then
						Return True
					End If
					count=0
				Next
				
		
	End Function
	
	Function draw () As Boolean
		Dim count As Integer=0
		For i=1 To 3
			For j=1 To 3
				If(grid(i,j)="-") Then
					count=count+1
					
				End If
				
				
					
			Next
		Next
		If (count=0) Then
					Return True
				End If
	End Function
	
End Module


