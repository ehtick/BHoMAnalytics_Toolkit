/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.BHoMAnalytics;
using BH.oM.Base.Attributes;
using BH.oM.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.Engine.BHoMAnalytics
{
    public static partial class Create
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        [Description("Create the settings for the BHoMAnalytics toolkit. This contains the reference to the database where to save the analytics data as well as the method in charge to do so.")]
        [Input("serverAddress", "Connection string of the Mongo server in charge of storing teh analytics data. Be aware that this generally includes the port number.")]
        [Input("databaseName", "Name of the database on the Mongo server that will contain the analytics data.")]
        [Input("collectionName", "Name of the collection inside that database that will contain the analytics data.")]
        public static ToolkitSettings ToolkitSettings(string serverAddress, string databaseName, string collectionName)
        {
            return new ToolkitSettings(serverAddress, databaseName, collectionName);
        }

        /***************************************************/
    }
}


