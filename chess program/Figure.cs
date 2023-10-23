using Chess;

Console.WriteLine("Пешка");
Pawn pawn = new Pawn(1, 2);
Console.WriteLine(pawn.Move(1, 4));
Console.WriteLine(pawn.Move(1, 3));
Console.WriteLine(pawn.Move(1, 5));

Console.WriteLine("Ферзь");
Queen queen = new Queen(4, 1);
Console.WriteLine(queen.Move(3, 3));
Console.WriteLine(queen.Move(3, 4));
Console.WriteLine(queen.Move(5, 4));
Console.WriteLine(queen.Move(5, 3));
Console.WriteLine(queen.Move(3, 5));
Console.WriteLine(queen.Move(2, 6));
Console.WriteLine(queen.Move(2, 3));

Console.WriteLine("Ладья");
Rook rook = new Rook(1, 1);
Console.WriteLine(rook.Move(1, 6));
Console.WriteLine(rook.Move(5, 4));
Console.WriteLine(rook.Move(4, 5));
Console.WriteLine(rook.Move(4, 3));
Console.WriteLine(rook.Move(3, 3));

Console.WriteLine("Конь");
Knight knight = new Knight(2, 1);
Console.WriteLine(knight.Move(3, 3));
Console.WriteLine(knight.Move(3, 6));
Console.WriteLine(knight.Move(5, 2));
Console.WriteLine(knight.Move(1, 1));

Console.WriteLine("Король");
King king = new King(5, 1);
Console.WriteLine(king.Move(4, 1));
Console.WriteLine(king.Move(5, 2));
Console.WriteLine(king.Move(6, 1));
Console.WriteLine(king.Move(6, 2));
Console.WriteLine(king.Move(6, 3));

Console.WriteLine("Слон");
Bishop bishop = new Bishop(4, 4);
Console.WriteLine(bishop.Move(3, 3));
Console.WriteLine(bishop.Move(2, 2));
Console.WriteLine(bishop.Move(5, 5));
Console.WriteLine(bishop.Move(3, 5));
Console.WriteLine(bishop.Move(5, 3));
Console.WriteLine(bishop.Move(2, 7));

