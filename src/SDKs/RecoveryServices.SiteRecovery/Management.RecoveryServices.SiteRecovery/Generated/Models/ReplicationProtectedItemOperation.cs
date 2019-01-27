// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{

    /// <summary>
    /// Defines values for ReplicationProtectedItemOperation.
    /// </summary>
    public static class ReplicationProtectedItemOperation
    {
        public const string ReverseReplicate = "ReverseReplicate";
        public const string Commit = "Commit";
        public const string PlannedFailover = "PlannedFailover";
        public const string UnplannedFailover = "UnplannedFailover";
        public const string DisableProtection = "DisableProtection";
        public const string TestFailover = "TestFailover";
        public const string TestFailoverCleanup = "TestFailoverCleanup";
        public const string Failback = "Failback";
        public const string FinalizeFailback = "FinalizeFailback";
        public const string ChangePit = "ChangePit";
        public const string RepairReplication = "RepairReplication";
        public const string SwitchProtection = "SwitchProtection";
        public const string CompleteMigration = "CompleteMigration";
    }
}
