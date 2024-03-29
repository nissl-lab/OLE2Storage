﻿/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

using NStorage.Properties;

namespace NStorage.Test.POIFS.Storage
{
    public class LocalProperty : NStorage.Properties.Property
    {
        /**
         * Constructor TestProperty
         *
         * @param name name of the property
         */
        public LocalProperty(string name) : base()
        {
            Name = name;
        }

        /**
         * do nothing
         */

        public override void PreWrite()
        {

        }

        /**
          * @return false
        */

        public override bool IsDirectory
        {
            get { return false; }
        }
    }
}
