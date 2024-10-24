// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Redis;

/// <summary>
/// SKU parameters supplied to the create Redis operation.
/// </summary>
public partial class RedisSku : ProvisionableConstruct
{
    /// <summary>
    /// The type of Redis cache to deploy. Valid values: (Basic, Standard,
    /// Premium).
    /// </summary>
    public BicepValue<RedisSkuName> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<RedisSkuName> _name;

    /// <summary>
    /// The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P =
    /// Premium).
    /// </summary>
    public BicepValue<RedisSkuFamily> Family { get => _family; set => _family.Assign(value); }
    private readonly BicepValue<RedisSkuFamily> _family;

    /// <summary>
    /// The size of the Redis cache to deploy. Valid values: for C
    /// (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family
    /// (1, 2, 3, 4).
    /// </summary>
    public BicepValue<int> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<int> _capacity;

    /// <summary>
    /// Creates a new RedisSku.
    /// </summary>
    public RedisSku()
    {
        _name = BicepValue<RedisSkuName>.DefineProperty(this, "Name", ["name"]);
        _family = BicepValue<RedisSkuFamily>.DefineProperty(this, "Family", ["family"]);
        _capacity = BicepValue<int>.DefineProperty(this, "Capacity", ["capacity"]);
    }
}
