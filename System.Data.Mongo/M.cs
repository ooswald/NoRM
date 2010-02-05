﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Mongo.Commands;

namespace System.Data.Mongo
{
    /// <summary>
    /// Shorthand to construct modifier operations
    /// for MongoDB fields.
    /// </summary>
    public class M
    {
        /// <summary>
        /// Creates a $inc operation to be applied to a field using the update command.
        /// </summary>
        /// <param name="amountToIncrementBy"></param>
        /// <returns></returns>
        public static IncrementOperation Inc(int amountToIncrementBy)
        {
           return new IncrementOperation(amountToIncrementBy);
        }
    }
}
