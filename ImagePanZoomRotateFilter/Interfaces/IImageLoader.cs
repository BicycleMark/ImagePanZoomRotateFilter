using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ImagePanZoomRotateFilter.Interfaces
{
    interface IImageLoader
    {    
        Task<int> Load(Stream imageStream);
        public byte[] data { get; }
    }
}
