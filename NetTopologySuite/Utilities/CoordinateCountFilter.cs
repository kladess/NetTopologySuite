using System;
using System.Collections;
using System.Text;

using GisSharpBlog.NetTopologySuite.Geometries;

namespace GisSharpBlog.NetTopologySuite.Utilities
{
    /// <summary>
    /// A <c>CoordinateFilter</c> that counts the total number of coordinates
    /// in a <c>Geometry</c>.
    /// </summary>
    public class CoordinateCountFilter : ICoordinateFilter 
    {
        private int n = 0;

        /// <summary>
        /// 
        /// </summary>
        public CoordinateCountFilter() { }

        /// <summary>
        /// Returns the result of the filtering.
        /// </summary>
        public virtual int Count 
        {
            get
            {
                return n;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coord"></param>
        public virtual void Filter(Coordinate coord) 
        {
            n++;
        }
    }
}