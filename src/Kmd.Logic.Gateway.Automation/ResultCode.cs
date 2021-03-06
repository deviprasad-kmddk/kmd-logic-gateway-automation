﻿namespace Kmd.Logic.Gateway.Automation
{
    public enum ResultCode
    {
        /// <summary>
        /// Validation failed.
        /// </summary>
        ValidationFailed,

        /// <summary>
        /// Product created successfully.
        /// </summary>
        ProductCreated,

        /// <summary>
        /// Product updated successfully.
        /// </summary>
        ProductUpdated,

        /// <summary>
        /// Api created successfully.
        /// </summary>
        ApiCreated,

        /// <summary>
        /// Api updated successfully.
        /// </summary>
        ApiUpdated,

        /// <summary>
        /// Api version marked as current.
        /// </summary>
        ApiVersionMarkedAsCurrent,

        /// <summary>
        /// Version created successfully.
        /// </summary>
        VersionCreated,

        /// <summary>
        /// Revision created successfully.
        /// </summary>
        RevisionCreated,

        /// <summary>
        /// Revision updated successfully.
        /// </summary>
        RevisionUpdated,

        /// <summary>
        /// Rate limit policy created successfully.
        /// </summary>
        RateLimitPolicyCreated,

        /// <summary>
        /// Rate limit policy updated successfully.
        /// </summary>
        RateLimitPolicyUpdated,

        /// <summary>
        /// Custom policy created successfully.
        /// </summary>
        CustomPolicyCreated,

        /// <summary>
        /// Custom policy updated successfully.
        /// </summary>
        CustomPolicyUpdated,
    }
}
