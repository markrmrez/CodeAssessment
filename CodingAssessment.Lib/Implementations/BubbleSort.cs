using CodingAssessment.Lib.ExtensionMethods;
using CodingAssessment.Lib.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CodingAssessment.Lib.Implementations
{
    /// <summary>
    /// This class would implement the BubbleSorting logic.
    /// </summary>
    public class BubbleSort : ISortLogic<string>
    {
        /// <summary>
        /// This method will perform the actual BubbleSort Logic.
        /// </summary>
        /// <param name="inputList">Unordered List</param>
        /// <returns>Ordered List</returns>
        public List<string> Sort(List<string> inputList)
        {
            string temp;
            string[] nameArray = inputList.ToArray();

            for ( int x = 0; x < nameArray.Length; x++)
            {
                for (int i = 0; i < nameArray.Length - 1; i++)
                {
                    if (nameArray[i].GetLastElement(' ').CompareTo(nameArray[i + 1].GetLastElement(' ')) > 0)
                    {
                        temp = nameArray[i];
                        nameArray[i] = nameArray[i + 1];
                        nameArray[i + 1] = temp;
                    }
                }
            }
            return nameArray.ToList<string>();
        }
    }
}
