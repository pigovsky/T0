using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filedublicates.NET
{
    public class FindDuplicatesAmongAllFileLengthGroups : IAbstractComparer
    {
        public GroupFilesBySize filesWithSameLength { get; set; }

        public AbstractComparer abstractComparer { get; set; }

        override public void detectDuplicates()
        {

            abstractComparer.searchingDuplicatesProgressDialog = searchingDuplicatesProgressDialog;

            searchingDuplicatesProgressDialog.totalNumberOfIterationsInOverallProcess
                = filesWithSameLength.Count;
            searchingDuplicatesProgressDialog.numberOfIterationsInOverallProcessPassed = 0;
            
            foreach (var group in filesWithSameLength)
            {
                abstractComparer.filesWithSameLengthAndDuplicates =
                    group.Value;
                abstractComparer.detectDuplicates();
                searchingDuplicatesProgressDialog.numberOfIterationsInOverallProcessPassed++;
            }
        }

    }
}
