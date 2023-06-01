using System.IO;

namespace BetCombinatorics
{
    public class AuxiliaryClass
    {
        public static dynamic GetMaxSequence(StreamReader reader)
        {
            string currentLine;
            char foundChar = '-';
            int maxLength = 1;

            while ((currentLine = reader.ReadLine()) != null)
            {
                int currentLength = 1;

                for (int i = 1; i < currentLine.Length; i++)
                {
                    if (currentLine[i - 1] == currentLine[i])
                    {
                        currentLength++;
                    }
                    else
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            foundChar = currentLine[i - 1];
                            currentLength = 1;
                        }
                        else
                        {
                            currentLength = 1;
                        }
                    }

                    if (currentLength > maxLength && i == currentLine.Length - 1)
                    {
                        maxLength = currentLength;
                        foundChar = currentLine[i - 1];
                        currentLength = 1;
                    }
                }
            }

            return new { MaxLength = maxLength, FoundChar = foundChar };
        }

        public static int GetCountSequences(StreamReader reader, int length)
        {
            string currentLine;
            int sequenceCount = 0;

            while ((currentLine = reader.ReadLine()) != null)
            {
                int currentLength = 1;

                for (int i = 1; i < currentLine.Length; i++)
                {
                    if (currentLine[i - 1] == currentLine[i])
                    {
                        currentLength++;

                        if (currentLength == length)
                        {
                            sequenceCount++;
                        }
                    }
                    else
                    {
                        currentLength = 1;
                    }
                }
            }

            return sequenceCount;
        }
    }
}
