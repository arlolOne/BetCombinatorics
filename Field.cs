
namespace BetCombinatorics
{
    public class Field
    {
        private readonly char[][] chars = new char[50][];

        public Field(string initSequence)
        {
            if (!IsInputValid(initSequence))
            {
                throw new InvalidInputDataException();
            }
            
            for (int i = 0; i < 50; i++)
            {
                chars[i] = new char[15];
            }
            
            string[] lines = initSequence.Split('\n');

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    chars[j][i] = lines[i][j];
                }
            }
        }

        private bool IsInputValid(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            string[] lines = input.Split('\n');

            if (lines.Length != 15)
            {
                return false;
            }

            for (int i = 0; i < 14; i++)
            {
                if (lines[i].Length != 51)
                {
                    return false;
                }
            }

            if (lines[14].Length != 50)
            {
                return false;
            }

            return true;
        }

        private string FieldToString()
        {
            char[] finalChars = new char[765];
            int k = 0;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    finalChars[k] = chars[j][i];
                    k++;
                }

                finalChars[k] = '\n';
                k++;
            }

            return new string(finalChars);
        }

        private void SingleShift(int j)
        {
            char firstChar = chars[j][14];

            for (int i = 13; i >= 0; i--)
            {
                chars[j][i + 1] = chars[j][i];
            }

            chars[j][0] = firstChar;
        }

        public void GetCombinations()
        {
            int count = 1;
            int step = 5;
            
            for (int i = 0; i < 15; i++)
            {
                if (i != 0) 
                {
                    for (int b = 0; b < 50; b += step)
                    {
                        SingleShift(b);
                    }
                }

                for (int j = 0; j < 15; j++)
                {
                    if (j != 0 || i != 0) 
                    {
                        for (int b = 1; b < 50; b += step)
                        {
                            SingleShift(b);
                        }
                    }

                    for (int k = 0; k < 15; k++)
                    {
                        if (k != 0 || j != 0 || i != 0)
                        {
                            for (int b = 2; b < 50; b += step)
                            {
                                SingleShift(b);
                            }
                        }

                        for (int l = 0; l < 15; l++)
                        {
                            if (l != 0 || k != 0 || j != 0 || i != 0)
                            { 
                                for (int b = 3; b < 50; b += step)
                                {
                                    SingleShift(b);
                                } 
                            }

                            for (int m = 0; m < 15; m++)
                            {
                                if (m != 0 || l != 0 || k != 0 || j != 0 || i != 0)
                                {
                                    for (int b = 4; b < 50; b += step)
                                    {
                                        SingleShift(b);
                                    }
                                }

                                FileTXT.Write("Combination number: " + count++);
                                FileTXT.Write(FieldToString());
                            }
                        }
                    }
                }
            }
        }
    }
}
