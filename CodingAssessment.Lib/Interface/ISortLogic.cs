using System.Collections.Generic;

namespace CodingAssessment.Lib.Interface
{
    public interface ISortLogic <T>
    {
        public List<T> Sort(List<T> inputList);
    }
}
