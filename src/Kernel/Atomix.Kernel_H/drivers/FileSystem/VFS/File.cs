﻿using System;
using System.Collections.Generic;

namespace Atomix.Kernel_H.drivers.FileSystem.VFS
{
    public class File : Node
    {
        public readonly Stream Data;

        public File(string aName, Stream MountPoint)
            :base(aName)
        {
            this.Data = MountPoint;
        }
    }
}
