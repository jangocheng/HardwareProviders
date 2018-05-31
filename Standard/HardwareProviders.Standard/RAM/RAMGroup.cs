﻿/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2012-2013 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

namespace HardwareProviders.RAM
{
    public class RAMGroup : IGroup
    {
        private readonly Hardware[] hardware;

        public RAMGroup()
        {
            hardware = new Hardware[] {new GenericRAM("Generic Memory")};
        }

        public string GetReport()
        {
            return null;
        }

        public IHardware[] Hardware => hardware;

        public void Close()
        {
            foreach (var ram in hardware)
                ram.Close();
        }
    }
}