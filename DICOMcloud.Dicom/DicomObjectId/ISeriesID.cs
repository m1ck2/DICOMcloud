﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICOMcloud.Dicom.Data
{
    public interface ISeriesID : IStudyID
    { 
        string SeriesInstanceUID { get; set ; }
    }
}
