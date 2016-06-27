﻿using UnityEngine;

namespace PhotoshopFile
{
    /// <summary>
    /// The blending ranges for a layer
    /// </summary>
    public class BlendingRanges
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlendingRanges"/> class.
        /// </summary>
        /// <param name="reader">The reader containing the PSD file data</param>
        public BlendingRanges(BinaryReverseReader reader)
        {
            // read the data length
            int count = reader.ReadInt32();
            if (count <= 0)
            {
                return;
            }

            // read the data
       byte [] data=     reader.ReadBytes(count);

            //string info = "BlendingRanges data=\n";
            //for (int index = 0; index < data.Length; index++)
            //{
            //    info += "data[" + index + "]=" + data[index] + "\n";
            //}
            //Debug.Log(info);
        }
    }
}
