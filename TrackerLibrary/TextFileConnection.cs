using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextFileConnection : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to a text file.

        /// <summary>
        /// Saves the new prize into the text file
        /// </summary>
        /// <param name="model">The prize information created in the CreatePrizeForm.</param>
        /// <returns>The new prize information, including the assigned Id property.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
