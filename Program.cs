using System.Text;

string[] binaryNumbers = File.ReadAllLines(@"C:\Users\jenni\source\repos\BinaryDiagnosticFirstPart\input.txt");
int binaryNumberLength = binaryNumbers[0].Length;
StringBuilder binaryGammaRate = new("000000000000", binaryNumbers[0].Length);
StringBuilder binaryEpsilonRate = new("000000000000", binaryNumbers[0].Length);

for (int i = 0; i < binaryNumberLength; i++)
{
    int nbOfOne = 0;

    for (int j = 0; j < binaryNumbers.Length; j++)
    {
        string binaryNumber = binaryNumbers[j];

        if (binaryNumber[i] == '1')
        {
            nbOfOne++;
        }
    }
    binaryGammaRate[i] = nbOfOne < (binaryNumbers.Length / 2) ? '0' : '1';
    binaryEpsilonRate[i] = binaryGammaRate[i] == '1' ? '0' : '1';
}

int decimalGammaRate = Convert.ToInt32(binaryGammaRate.ToString(), 2);
int decimalEpsilonRate = Convert.ToInt32(binaryEpsilonRate.ToString(), 2);

Console.WriteLine($"power consumption : {decimalGammaRate * decimalEpsilonRate}");