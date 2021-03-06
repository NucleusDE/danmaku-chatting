﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Model
{
    public class DataPackage
    {
        private System.Net.Sockets.TcpClient client;
        private byte[] data;

        public TcpClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
                if (client == null)
                    throw new Exception(libData.ConstData.DataPackageException);
            }
        }

        public byte[] Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
                if (data.Length == 0)
                    throw new Exception(libData.ConstData.DataPackageException);
            }
        }
    }
}
