using Exercice03Citerne.Classe;

WaterTank watertank1 = new WaterTank(10, 20, 10);
WaterTank watertank2 = new WaterTank(10, 10, 5);
Console.WriteLine($"Poids total de la citerne 1 : {watertank1.TotalWeight()}");
Console.WriteLine($"Poids total de la citerne 2 : {watertank2.TotalWeight()}");
Console.WriteLine("----------------------");
Console.WriteLine($"Quantité d'eau dans la citerne 1 : {watertank1.FillLevel}");
watertank1.AffichageCiterne(); // affiche le dessin de la citerne
Console.WriteLine($"Quantité d'eau dans la citerne 2 : {watertank2.FillLevel}");
watertank2.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans toutes les citernes : {WaterTank.TotalFillLevels}");
Console.WriteLine("----------------------");
int excessWater = watertank1.Fill(11);
Console.WriteLine($"Quantité d'eau dans la citerne 1 après ajout de 11 litres: {watertank1.FillLevel}/{watertank1.MaxCapacity}");
Console.WriteLine($"Excès d'eau récupéré : {excessWater}");
int waterTaken = watertank2.Empty(11);
Console.WriteLine($"Quantité d'eau dans la citerne 2 après tentative de retrait de 11 litres: {watertank2.FillLevel}/{watertank2.MaxCapacity}");
Console.WriteLine($"Quantité d'eau récupérée : {waterTaken}");
Console.WriteLine("----------------------");
Console.WriteLine($"Quantité d'eau dans la citerne 1 : {watertank1.FillLevel}");
watertank1.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans la citerne 2 : {watertank2.FillLevel}");
watertank2.AffichageCiterne();
Console.WriteLine($"Quantité d'eau dans toutes les citernes : {WaterTank.TotalFillLevels}");