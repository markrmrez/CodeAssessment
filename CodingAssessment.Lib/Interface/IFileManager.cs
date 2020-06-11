using System.Collections.Generic;

namespace CodingAssessment.Lib.Interface
{
    public interface IFileManager
    {
        public List<string> Open();
        public void Save(List<string> stringList);
    }
}
