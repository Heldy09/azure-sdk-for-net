// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting target rolling window size.
    /// Please note <see cref="TargetRollingWindowSize"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutoTargetRollingWindowSize"/> and <see cref="CustomTargetRollingWindowSize"/>.
    /// </summary>
    public abstract partial class TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of TargetRollingWindowSize. </summary>
        protected TargetRollingWindowSize()
        {
        }

        /// <summary> Initializes a new instance of TargetRollingWindowSize. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        internal TargetRollingWindowSize(TargetRollingWindowSizeMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] TargetRollingWindowSiz detection mode. </summary>
        internal TargetRollingWindowSizeMode Mode { get; set; }
    }
}
