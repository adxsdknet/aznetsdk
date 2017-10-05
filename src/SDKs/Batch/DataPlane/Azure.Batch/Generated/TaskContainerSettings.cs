// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The container settings for a task.
    /// </summary>
    public partial class TaskContainerSettings : ITransportObjectProvider<Models.TaskContainerSettings>, IPropertyMetadata
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskContainerSettings"/> class.
        /// </summary>
        /// <param name='imageName'>The image to use to create the container in which the task will run.</param>
        /// <param name='containerRunOptions'>Additional options to the container create command.</param>
        /// <param name='registry'>The private registry which contains the container image.</param>
        public TaskContainerSettings(
            string imageName,
            string containerRunOptions = default(string),
            ContainerRegistry registry = default(ContainerRegistry))
        {
            this.ImageName = imageName;
            this.ContainerRunOptions = containerRunOptions;
            this.Registry = registry;
        }

        internal TaskContainerSettings(Models.TaskContainerSettings protocolObject)
        {
            this.ContainerRunOptions = protocolObject.ContainerRunOptions;
            this.ImageName = protocolObject.ImageName;
            this.Registry = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Registry, o => new ContainerRegistry(o).Freeze());
        }

        #endregion Constructors

        #region TaskContainerSettings

        /// <summary>
        /// Gets additional options to the container create command.
        /// </summary>
        /// <remarks>
        /// These additional options are supplied as arguments to the "docker create" command, in addition to those controlled 
        /// by the Batch Service.
        /// </remarks>
        public string ContainerRunOptions { get; }

        /// <summary>
        /// Gets the image to use to create the container in which the task will run.
        /// </summary>
        /// <remarks>
        /// This is the full image reference, as would be specified to "docker pull". If no tag is provided as part of the 
        /// image name, the tag ":latest" is used as a default.
        /// </remarks>
        public string ImageName { get; }

        /// <summary>
        /// Gets the private registry which contains the container image.
        /// </summary>
        /// <remarks>
        /// This setting can be omitted if was already provided at pool creation.
        /// </remarks>
        public ContainerRegistry Registry { get; }

        #endregion // TaskContainerSettings

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.TaskContainerSettings ITransportObjectProvider<Models.TaskContainerSettings>.GetTransportObject()
        {
            Models.TaskContainerSettings result = new Models.TaskContainerSettings()
            {
                ContainerRunOptions = this.ContainerRunOptions,
                ImageName = this.ImageName,
                Registry = UtilitiesInternal.CreateObjectWithNullCheck(this.Registry, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}