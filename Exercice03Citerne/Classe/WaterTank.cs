namespace Exercice03Citerne.Classe
{
    internal class WaterTank
    {
        public int FillLevel { get; private set; }
        public int MaxCapacity { get; private set; }
        public int WeightEmpty { get; private set; }
        public static int TotalFillLevels { get; private set; }

        public WaterTank(int fillLevel, int maxCapacity, int weightEmpty)
        {
            FillLevel = fillLevel;
            MaxCapacity = maxCapacity;
            WeightEmpty = weightEmpty;
            TotalFillLevels += fillLevel;
        }

        public int TotalWeight()
        {
            return WeightEmpty + FillLevel;
        }

        public int Fill(int liters)
        {
            int spaceAvailable = MaxCapacity - FillLevel;
            int actualFill = Math.Min(liters, spaceAvailable);
            FillLevel += actualFill;
            TotalFillLevels += actualFill;
            return liters - actualFill;
        }

        public int Empty(int liters)
        {
            int actualEmpty = liters;
            if (actualEmpty > FillLevel)
            {
                actualEmpty = FillLevel;
            }

            FillLevel -= actualEmpty;
            TotalFillLevels -= actualEmpty;
            return actualEmpty;
        }

        public void AffichageCiterne()
        {
            string[,] citerneAscii = {
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│            │",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
                {"┌──────O─────┐",
                "│~~~~~~~~~~~~│",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "│            │",
                "└────────────┘"},
            };
            int niveauCiterne = FillLevel == 1 ? 1 : (FillLevel * 8 / MaxCapacity);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(citerneAscii[niveauCiterne, i]);
            }
        }
    }
}
