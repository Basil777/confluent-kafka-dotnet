// *** Auto-generated from librdkafka v2.11.0 *** - do not modify manually.
//
// Copyright 2018-2022 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the 'License');
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an 'AS IS' BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Confluent.Kafka
{
    /// <summary>
    ///     Partitioner enum values
    /// </summary>
    public enum Partitioner
    {
        /// <summary>
        ///     Random
        /// </summary>
        Random,

        /// <summary>
        ///     Consistent
        /// </summary>
        Consistent,

        /// <summary>
        ///     ConsistentRandom
        /// </summary>
        ConsistentRandom,

        /// <summary>
        ///     Murmur2
        /// </summary>
        Murmur2,

        /// <summary>
        ///     Murmur2Random
        /// </summary>
        Murmur2Random
    }

    /// <summary>
    ///     AutoOffsetReset enum values
    /// </summary>
    public enum AutoOffsetReset
    {
        /// <summary>
        ///     Latest
        /// </summary>
        Latest,

        /// <summary>
        ///     Earliest
        /// </summary>
        Earliest,

        /// <summary>
        ///     Error
        /// </summary>
        Error
    }

    /// <summary>
    ///     MetadataRecoveryStrategy enum values
    /// </summary>
    public enum MetadataRecoveryStrategy
    {
        /// <summary>
        ///     None
        /// </summary>
        None,

        /// <summary>
        ///     Rebootstrap
        /// </summary>
        Rebootstrap
    }

    /// <summary>
    ///     BrokerAddressFamily enum values
    /// </summary>
    public enum BrokerAddressFamily
    {
        /// <summary>
        ///     Any
        /// </summary>
        Any,

        /// <summary>
        ///     V4
        /// </summary>
        V4,

        /// <summary>
        ///     V6
        /// </summary>
        V6
    }

    /// <summary>
    ///     SecurityProtocol enum values
    /// </summary>
    public enum SecurityProtocol
    {
        /// <summary>
        ///     Plaintext
        /// </summary>
        Plaintext,

        /// <summary>
        ///     Ssl
        /// </summary>
        Ssl,

        /// <summary>
        ///     SaslPlaintext
        /// </summary>
        SaslPlaintext,

        /// <summary>
        ///     SaslSsl
        /// </summary>
        SaslSsl
    }

    /// <summary>
    ///     SslEndpointIdentificationAlgorithm enum values
    /// </summary>
    public enum SslEndpointIdentificationAlgorithm
    {
        /// <summary>
        ///     None
        /// </summary>
        None,

        /// <summary>
        ///     Https
        /// </summary>
        Https
    }

    /// <summary>
    ///     SaslOauthbearerMethod enum values
    /// </summary>
    public enum SaslOauthbearerMethod
    {
        /// <summary>
        ///     Default
        /// </summary>
        Default,

        /// <summary>
        ///     Oidc
        /// </summary>
        Oidc
    }

    /// <summary>
    ///     SaslOauthbearerGrantType enum values
    /// </summary>
    public enum SaslOauthbearerGrantType
    {
        /// <summary>
        ///     ClientCredentials
        /// </summary>
        ClientCredentials,

        /// <summary>
        ///     JwtBearer
        /// </summary>
        JwtBearer
    }

    /// <summary>
    ///     SaslOauthbearerAssertionAlgorithm enum values
    /// </summary>
    public enum SaslOauthbearerAssertionAlgorithm
    {
        /// <summary>
        ///     RS256
        /// </summary>
        RS256,

        /// <summary>
        ///     ES256
        /// </summary>
        ES256
    }

    /// <summary>
    ///     PartitionAssignmentStrategy enum values
    /// </summary>
    public enum PartitionAssignmentStrategy
    {
        /// <summary>
        ///     Range
        /// </summary>
        Range,

        /// <summary>
        ///     RoundRobin
        /// </summary>
        RoundRobin,

        /// <summary>
        ///     CooperativeSticky
        /// </summary>
        CooperativeSticky
    }

    /// <summary>
    ///     GroupProtocol enum values
    /// </summary>
    public enum GroupProtocol
    {
        /// <summary>
        ///     Classic
        /// </summary>
        Classic,

        /// <summary>
        ///     Consumer
        /// </summary>
        Consumer
    }

    /// <summary>
    ///     IsolationLevel enum values
    /// </summary>
    public enum IsolationLevel
    {
        /// <summary>
        ///     ReadUncommitted
        /// </summary>
        ReadUncommitted,

        /// <summary>
        ///     ReadCommitted
        /// </summary>
        ReadCommitted
    }

    /// <summary>
    ///     CompressionType enum values
    /// </summary>
    public enum CompressionType
    {
        /// <summary>
        ///     None
        /// </summary>
        None,

        /// <summary>
        ///     Gzip
        /// </summary>
        Gzip,

        /// <summary>
        ///     Snappy
        /// </summary>
        Snappy,

        /// <summary>
        ///     Lz4
        /// </summary>
        Lz4,

        /// <summary>
        ///     Zstd
        /// </summary>
        Zstd
    }

    /// <summary>
    ///     ClientDnsLookup enum values
    /// </summary>
    public enum ClientDnsLookup
    {
        /// <summary>
        ///     UseAllDnsIps
        /// </summary>
        UseAllDnsIps,

        /// <summary>
        ///     ResolveCanonicalBootstrapServersOnly
        /// </summary>
        ResolveCanonicalBootstrapServersOnly
    }

    /// <summary>
    ///     SaslMechanism enum values
    /// </summary>
    public enum SaslMechanism
    {
        /// <summary>
        ///     GSSAPI
        /// </summary>
        Gssapi,

        /// <summary>
        ///     PLAIN
        /// </summary>
        Plain,

        /// <summary>
        ///     SCRAM-SHA-256
        /// </summary>
        ScramSha256,

        /// <summary>
        ///     SCRAM-SHA-512
        /// </summary>
        ScramSha512,

        /// <summary>
        ///     OAUTHBEARER
        /// </summary>
        OAuthBearer
    }

    /// <summary>
    ///     Acks enum values
    /// </summary>
    public enum Acks : int
    {
        /// <summary>
        ///     None
        /// </summary>
        None = 0,

        /// <summary>
        ///     Leader
        /// </summary>
        Leader = 1,

        /// <summary>
        ///     All
        /// </summary>
        All = -1
    }

    /// <summary>
    ///     Configuration common to all clients
    /// </summary>
    public class ClientConfig : Config
    {

        /// <summary>
        ///     Initialize a new empty <see cref="ClientConfig" /> instance.
        /// </summary>
        public ClientConfig() : base() { }

        /// <summary>
        ///     Initialize a new <see cref="ClientConfig" /> instance wrapping
        ///     an existing <see cref="ClientConfig" /> instance.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public ClientConfig(ClientConfig config) : base(config) { }

        /// <summary>
        ///     Initialize a new <see cref="ClientConfig" /> instance wrapping
        ///     an existing key/value pair collection.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public ClientConfig(IDictionary<string, string> config) : base(config) { }

        /// <summary>
        ///     SASL mechanism to use for authentication. Supported: GSSAPI, PLAIN, SCRAM-SHA-256, SCRAM-SHA-512. **NOTE**: Despite the name, you may not configure more than one mechanism.
        /// </summary>
        public SaslMechanism? SaslMechanism
        {
            get
            {
                var r = Get("sasl.mechanism");
                if (r == null) { return null; }
                if (r == "GSSAPI") { return Confluent.Kafka.SaslMechanism.Gssapi; }
                if (r == "PLAIN") { return Confluent.Kafka.SaslMechanism.Plain; }
                if (r == "SCRAM-SHA-256") { return Confluent.Kafka.SaslMechanism.ScramSha256; }
                if (r == "SCRAM-SHA-512") { return Confluent.Kafka.SaslMechanism.ScramSha512; }
                if (r == "OAUTHBEARER") { return Confluent.Kafka.SaslMechanism.OAuthBearer; }
                throw new ArgumentException($"Unknown sasl.mechanism value {r}");
            }
            set
            {
                if (value == null) { this.properties.Remove("sasl.mechanism"); }
                else if (value == Confluent.Kafka.SaslMechanism.Gssapi) { this.properties["sasl.mechanism"] = "GSSAPI"; }
                else if (value == Confluent.Kafka.SaslMechanism.Plain) { this.properties["sasl.mechanism"] = "PLAIN"; }
                else if (value == Confluent.Kafka.SaslMechanism.ScramSha256) { this.properties["sasl.mechanism"] = "SCRAM-SHA-256"; }
                else if (value == Confluent.Kafka.SaslMechanism.ScramSha512) { this.properties["sasl.mechanism"] = "SCRAM-SHA-512"; }
                else if (value == Confluent.Kafka.SaslMechanism.OAuthBearer) { this.properties["sasl.mechanism"] = "OAUTHBEARER"; }
                else throw new ArgumentException($"Unknown sasl.mechanism value {value}");
            }
        }


        /// <summary>
        ///     This field indicates the number of acknowledgements the leader broker must receive from ISR brokers
        ///     before responding to the request: Zero=Broker does not send any response/ack to client, One=The
        ///     leader will write the record to its local log but will respond without awaiting full acknowledgement
        ///     from all followers. All=Broker will block until message is committed by all in sync replicas (ISRs).
        ///     If there are less than min.insync.replicas (broker configuration) in the ISR set the produce request
        ///     will fail.
        /// </summary>
        public Acks? Acks
        {
            get
            {
                var r = Get("acks");
                if (r == null) { return null; }
                if (r == "0") { return Confluent.Kafka.Acks.None; }
                if (r == "1") { return Confluent.Kafka.Acks.Leader; }
                if (r == "-1" || r == "all") { return Confluent.Kafka.Acks.All; }
                return (Acks)(int.Parse(r));
            }
            set
            {
                if (value == null) { this.properties.Remove("acks"); }
                else if (value == Confluent.Kafka.Acks.None) { this.properties["acks"] = "0"; }
                else if (value == Confluent.Kafka.Acks.Leader) { this.properties["acks"] = "1"; }
                else if (value == Confluent.Kafka.Acks.All) { this.properties["acks"] = "-1"; }
                else { this.properties["acks"] = ((int)value.Value).ToString(); }
            }
        }

        /// <summary>
        /// <![CDATA[
        ///     Client identifier.
        ///
        ///     default: rdkafka
        ///     importance: low
        /// ]]>
        /// </summary>
        public string ClientId { get { return Get("client.id"); } set { this.SetObject("client.id", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Initial list of brokers as a CSV list of broker host or host:port. The application may also use `rd_kafka_brokers_add()` to add brokers during runtime.
        ///
        ///     default: ''
        ///     importance: high
        /// ]]>
        /// </summary>
        public string BootstrapServers { get { return Get("bootstrap.servers"); } set { this.SetObject("bootstrap.servers", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum Kafka protocol request message size. Due to differing framing overhead between protocol versions the producer is unable to reliably enforce a strict max message limit at produce time and may exceed the maximum size by one message in protocol ProduceRequests, the broker will enforce the the topic's `max.message.bytes` limit (see Apache Kafka documentation).
        ///
        ///     default: 1000000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? MessageMaxBytes { get { return GetInt("message.max.bytes"); } set { this.SetObject("message.max.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum size for message to be copied to buffer. Messages larger than this will be passed by reference (zero-copy) at the expense of larger iovecs.
        ///
        ///     default: 65535
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? MessageCopyMaxBytes { get { return GetInt("message.copy.max.bytes"); } set { this.SetObject("message.copy.max.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum Kafka protocol response message size. This serves as a safety precaution to avoid memory exhaustion in case of protocol hickups. This value must be at least `fetch.max.bytes`  + 512 to allow for protocol overhead; the value is adjusted automatically unless the configuration property is explicitly set.
        ///
        ///     default: 100000000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? ReceiveMessageMaxBytes { get { return GetInt("receive.message.max.bytes"); } set { this.SetObject("receive.message.max.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum number of in-flight requests per broker connection. This is a generic property applied to all broker communication, however it is primarily relevant to produce requests. In particular, note that other mechanisms limit the number of outstanding consumer fetch request per broker to one.
        ///
        ///     default: 1000000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? MaxInFlight { get { return GetInt("max.in.flight"); } set { this.SetObject("max.in.flight", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Controls how the client recovers when none of the brokers known to it is available. If set to `none`, the client doesn't re-bootstrap. If set to `rebootstrap`, the client repeats the bootstrap process using `bootstrap.servers` and brokers added through `rd_kafka_brokers_add()`. Rebootstrapping is useful when a client communicates with brokers so infrequently that the set of brokers may change entirely before the client refreshes metadata. Metadata recovery is triggered when all last-known brokers appear unavailable simultaneously or the client cannot refresh metadata within `metadata.recovery.rebootstrap.trigger.ms` or it's requested in a metadata response.
        ///
        ///     default: rebootstrap
        ///     importance: low
        /// ]]>
        /// </summary>
        public MetadataRecoveryStrategy? MetadataRecoveryStrategy { get { return (MetadataRecoveryStrategy?)GetEnum(typeof(MetadataRecoveryStrategy), "metadata.recovery.strategy"); } set { this.SetObject("metadata.recovery.strategy", value); } }

        /// <summary>
        /// <![CDATA[
        ///     If a client configured to rebootstrap using `metadata.recovery.strategy=rebootstrap` is unable to obtain metadata from any of the brokers for this interval, client repeats the bootstrap process using `bootstrap.servers` configuration and brokers added through `rd_kafka_brokers_add()`.
        ///
        ///     default: 300000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? MetadataRecoveryRebootstrapTriggerMs { get { return GetInt("metadata.recovery.rebootstrap.trigger.ms"); } set { this.SetObject("metadata.recovery.rebootstrap.trigger.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Period of time in milliseconds at which topic and broker metadata is refreshed in order to proactively discover any new brokers, topics, partitions or partition leader changes. Use -1 to disable the intervalled refresh (not recommended). If there are no locally referenced topics (no topic objects created, no messages produced, no subscription or no assignment) then only the broker list will be refreshed every interval but no more often than every 10s.
        ///
        ///     default: 300000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? TopicMetadataRefreshIntervalMs { get { return GetInt("topic.metadata.refresh.interval.ms"); } set { this.SetObject("topic.metadata.refresh.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Metadata cache max age. Defaults to topic.metadata.refresh.interval.ms * 3
        ///
        ///     default: 900000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? MetadataMaxAgeMs { get { return GetInt("metadata.max.age.ms"); } set { this.SetObject("metadata.max.age.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     When a topic loses its leader a new metadata request will be enqueued immediately and then with this initial interval, exponentially increasing upto `retry.backoff.max.ms`, until the topic metadata has been refreshed. If not set explicitly, it will be defaulted to `retry.backoff.ms`. This is used to recover quickly from transitioning leader brokers.
        ///
        ///     default: 100
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? TopicMetadataRefreshFastIntervalMs { get { return GetInt("topic.metadata.refresh.fast.interval.ms"); } set { this.SetObject("topic.metadata.refresh.fast.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Sparse metadata requests (consumes less network bandwidth)
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? TopicMetadataRefreshSparse { get { return GetBool("topic.metadata.refresh.sparse"); } set { this.SetObject("topic.metadata.refresh.sparse", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Apache Kafka topic creation is asynchronous and it takes some time for a new topic to propagate throughout the cluster to all brokers. If a client requests topic metadata after manual topic creation but before the topic has been fully propagated to the broker the client is requesting metadata from, the topic will seem to be non-existent and the client will mark the topic as such, failing queued produced messages with `ERR__UNKNOWN_TOPIC`. This setting delays marking a topic as non-existent until the configured propagation max time has passed. The maximum propagation time is calculated from the time the topic is first referenced in the client, e.g., on produce().
        ///
        ///     default: 30000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? TopicMetadataPropagationMaxMs { get { return GetInt("topic.metadata.propagation.max.ms"); } set { this.SetObject("topic.metadata.propagation.max.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Topic blacklist, a comma-separated list of regular expressions for matching topic names that should be ignored in broker metadata information as if the topics did not exist.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string TopicBlacklist { get { return Get("topic.blacklist"); } set { this.SetObject("topic.blacklist", value); } }

        /// <summary>
        /// <![CDATA[
        ///     A comma-separated list of debug contexts to enable. Detailed Producer debugging: broker,topic,msg. Consumer: consumer,cgrp,topic,fetch
        ///
        ///     default: ''
        ///     importance: medium
        /// ]]>
        /// </summary>
        public string Debug { get { return Get("debug"); } set { this.SetObject("debug", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Default timeout for network requests. Producer: ProduceRequests will use the lesser value of `socket.timeout.ms` and remaining `message.timeout.ms` for the first message in the batch. Consumer: FetchRequests will use `fetch.wait.max.ms` + `socket.timeout.ms`. Admin: Admin requests will use `socket.timeout.ms` or explicitly set `rd_kafka_AdminOptions_set_operation_timeout()` value.
        ///
        ///     default: 60000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SocketTimeoutMs { get { return GetInt("socket.timeout.ms"); } set { this.SetObject("socket.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Broker socket send buffer size. System default is used if 0.
        ///
        ///     default: 0
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SocketSendBufferBytes { get { return GetInt("socket.send.buffer.bytes"); } set { this.SetObject("socket.send.buffer.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Broker socket receive buffer size. System default is used if 0.
        ///
        ///     default: 0
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SocketReceiveBufferBytes { get { return GetInt("socket.receive.buffer.bytes"); } set { this.SetObject("socket.receive.buffer.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Enable TCP keep-alives (SO_KEEPALIVE) on broker sockets
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? SocketKeepaliveEnable { get { return GetBool("socket.keepalive.enable"); } set { this.SetObject("socket.keepalive.enable", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Disable the Nagle algorithm (TCP_NODELAY) on broker sockets.
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? SocketNagleDisable { get { return GetBool("socket.nagle.disable"); } set { this.SetObject("socket.nagle.disable", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Disconnect from broker when this number of send failures (e.g., timed out requests) is reached. Disable with 0. WARNING: It is highly recommended to leave this setting at its default value of 1 to avoid the client and broker to become desynchronized in case of request timeouts. NOTE: The connection is automatically re-established.
        ///
        ///     default: 1
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SocketMaxFails { get { return GetInt("socket.max.fails"); } set { this.SetObject("socket.max.fails", value); } }

        /// <summary>
        /// <![CDATA[
        ///     How long to cache the broker address resolving results (milliseconds).
        ///
        ///     default: 1000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? BrokerAddressTtl { get { return GetInt("broker.address.ttl"); } set { this.SetObject("broker.address.ttl", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Allowed broker IP address families: any, v4, v6
        ///
        ///     default: any
        ///     importance: low
        /// ]]>
        /// </summary>
        public BrokerAddressFamily? BrokerAddressFamily { get { return (BrokerAddressFamily?)GetEnum(typeof(BrokerAddressFamily), "broker.address.family"); } set { this.SetObject("broker.address.family", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum time allowed for broker connection setup (TCP connection setup as well SSL and SASL handshake). If the connection to the broker is not fully functional after this the connection will be closed and retried.
        ///
        ///     default: 30000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? SocketConnectionSetupTimeoutMs { get { return GetInt("socket.connection.setup.timeout.ms"); } set { this.SetObject("socket.connection.setup.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Close broker connections after the specified time of inactivity. Disable with 0. If this property is left at its default value some heuristics are performed to determine a suitable default value, this is currently limited to identifying brokers on Azure (see librdkafka issue #3109 for more info).
        ///
        ///     default: 0
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? ConnectionsMaxIdleMs { get { return GetInt("connections.max.idle.ms"); } set { this.SetObject("connections.max.idle.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The initial time to wait before reconnecting to a broker after the connection has been closed. The time is increased exponentially until `reconnect.backoff.max.ms` is reached. -25% to +50% jitter is applied to each reconnect backoff. A value of 0 disables the backoff and reconnects immediately.
        ///
        ///     default: 100
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? ReconnectBackoffMs { get { return GetInt("reconnect.backoff.ms"); } set { this.SetObject("reconnect.backoff.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The maximum time to wait before reconnecting to a broker after the connection has been closed.
        ///
        ///     default: 10000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? ReconnectBackoffMaxMs { get { return GetInt("reconnect.backoff.max.ms"); } set { this.SetObject("reconnect.backoff.max.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     librdkafka statistics emit interval. The application also needs to register a stats callback using `rd_kafka_conf_set_stats_cb()`. The granularity is 1000ms. A value of 0 disables statistics.
        ///
        ///     default: 0
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? StatisticsIntervalMs { get { return GetInt("statistics.interval.ms"); } set { this.SetObject("statistics.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Disable spontaneous log_cb from internal librdkafka threads, instead enqueue log messages on queue set with `rd_kafka_set_log_queue()` and serve log callbacks or events through the standard poll APIs. **NOTE**: Log messages will linger in a temporary queue until the log queue has been set.
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? LogQueue { get { return GetBool("log.queue"); } set { this.SetObject("log.queue", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Print internal thread name in log messages (useful for debugging librdkafka internals)
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? LogThreadName { get { return GetBool("log.thread.name"); } set { this.SetObject("log.thread.name", value); } }

        /// <summary>
        /// <![CDATA[
        ///     If enabled librdkafka will initialize the PRNG with srand(current_time.milliseconds) on the first invocation of rd_kafka_new() (required only if rand_r() is not available on your platform). If disabled the application must call srand() prior to calling rd_kafka_new().
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? EnableRandomSeed { get { return GetBool("enable.random.seed"); } set { this.SetObject("enable.random.seed", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Log broker disconnects. It might be useful to turn this off when interacting with 0.9 brokers with an aggressive `connections.max.idle.ms` value.
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? LogConnectionClose { get { return GetBool("log.connection.close"); } set { this.SetObject("log.connection.close", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Signal that librdkafka will use to quickly terminate on rd_kafka_destroy(). If this signal is not set then there will be a delay before rd_kafka_wait_destroyed() returns true as internal threads are timing out their system calls. If this signal is set however the delay will be minimal. The application should mask this signal as an internal signal handler is installed.
        ///
        ///     default: 0
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? InternalTerminationSignal { get { return GetInt("internal.termination.signal"); } set { this.SetObject("internal.termination.signal", value); } }

        /// <summary>
        /// <![CDATA[
        ///     **DEPRECATED** **Post-deprecation actions: remove this configuration property, brokers < 0.10.0 won't be supported anymore in librdkafka 3.x.** Request broker's supported API versions to adjust functionality to available protocol features. If set to false, or the ApiVersionRequest fails, the fallback version `broker.version.fallback` will be used. **NOTE**: Depends on broker version >=0.10.0. If the request is not supported by (an older) broker the `broker.version.fallback` fallback is used.
        ///
        ///     default: true
        ///     importance: high
        /// ]]>
        /// </summary>
        public bool? ApiVersionRequest { get { return GetBool("api.version.request"); } set { this.SetObject("api.version.request", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Timeout for broker API version requests.
        ///
        ///     default: 10000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? ApiVersionRequestTimeoutMs { get { return GetInt("api.version.request.timeout.ms"); } set { this.SetObject("api.version.request.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     **DEPRECATED** **Post-deprecation actions: remove this configuration property, brokers < 0.10.0 won't be supported anymore in librdkafka 3.x.** Dictates how long the `broker.version.fallback` fallback is used in the case the ApiVersionRequest fails. **NOTE**: The ApiVersionRequest is only issued when a new connection to the broker is made (such as after an upgrade).
        ///
        ///     default: 0
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? ApiVersionFallbackMs { get { return GetInt("api.version.fallback.ms"); } set { this.SetObject("api.version.fallback.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     **DEPRECATED** **Post-deprecation actions: remove this configuration property, brokers < 0.10.0 won't be supported anymore in librdkafka 3.x.** Older broker versions (before 0.10.0) provide no way for a client to query for supported protocol features (ApiVersionRequest, see `api.version.request`) making it impossible for the client to know what features it may use. As a workaround a user may set this property to the expected broker version and the client will automatically adjust its feature set accordingly if the ApiVersionRequest fails (or is disabled). The fallback broker version will be used for `api.version.fallback.ms`. Valid values are: 0.9.0, 0.8.2, 0.8.1, 0.8.0. Any other value >= 0.10, such as 0.10.2.1, enables ApiVersionRequests.
        ///
        ///     default: 0.10.0
        ///     importance: medium
        /// ]]>
        /// </summary>
        public string BrokerVersionFallback { get { return Get("broker.version.fallback"); } set { this.SetObject("broker.version.fallback", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Allow automatic topic creation on the broker when subscribing to or assigning non-existent topics. The broker must also be configured with `auto.create.topics.enable=true` for this configuration to take effect. Note: the default value (true) for the producer is different from the default value (false) for the consumer. Further, the consumer default value is different from the Java consumer (true), and this property is not supported by the Java producer. Requires broker version >= 0.11.0.0, for older broker versions only the broker configuration applies.
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? AllowAutoCreateTopics { get { return GetBool("allow.auto.create.topics"); } set { this.SetObject("allow.auto.create.topics", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Protocol used to communicate with brokers.
        ///
        ///     default: plaintext
        ///     importance: high
        /// ]]>
        /// </summary>
        public SecurityProtocol? SecurityProtocol { get { return (SecurityProtocol?)GetEnum(typeof(SecurityProtocol), "security.protocol"); } set { this.SetObject("security.protocol", value); } }

        /// <summary>
        /// <![CDATA[
        ///     A cipher suite is a named combination of authentication, encryption, MAC and key exchange algorithm used to negotiate the security settings for a network connection using TLS or SSL network protocol. See manual page for `ciphers(1)` and `SSL_CTX_set_cipher_list(3).
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCipherSuites { get { return Get("ssl.cipher.suites"); } set { this.SetObject("ssl.cipher.suites", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The supported-curves extension in the TLS ClientHello message specifies the curves (standard/named, or 'explicit' GF(2^k) or GF(p)) the client is willing to have the server use. See manual page for `SSL_CTX_set1_curves_list(3)`. OpenSSL >= 1.0.2 required.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCurvesList { get { return Get("ssl.curves.list"); } set { this.SetObject("ssl.curves.list", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The client uses the TLS ClientHello signature_algorithms extension to indicate to the server which signature/hash algorithm pairs may be used in digital signatures. See manual page for `SSL_CTX_set1_sigalgs_list(3)`. OpenSSL >= 1.0.2 required.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslSigalgsList { get { return Get("ssl.sigalgs.list"); } set { this.SetObject("ssl.sigalgs.list", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to client's private key (PEM) used for authentication.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslKeyLocation { get { return Get("ssl.key.location"); } set { this.SetObject("ssl.key.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Private key passphrase (for use with `ssl.key.location` and `set_ssl_cert()`)
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslKeyPassword { get { return Get("ssl.key.password"); } set { this.SetObject("ssl.key.password", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client's private key string (PEM format) used for authentication.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslKeyPem { get { return Get("ssl.key.pem"); } set { this.SetObject("ssl.key.pem", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to client's public key (PEM) used for authentication.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCertificateLocation { get { return Get("ssl.certificate.location"); } set { this.SetObject("ssl.certificate.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client's public key string (PEM format) used for authentication.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCertificatePem { get { return Get("ssl.certificate.pem"); } set { this.SetObject("ssl.certificate.pem", value); } }

        /// <summary>
        /// <![CDATA[
        ///     File or directory path to CA certificate(s) for verifying the broker's key. Defaults: On Windows the system's CA certificates are automatically looked up in the Windows Root certificate store. On Mac OSX this configuration defaults to `probe`. It is recommended to install openssl using Homebrew, to provide CA certificates. On Linux install the distribution's ca-certificates package. If OpenSSL is statically linked or `ssl.ca.location` is set to `probe` a list of standard paths will be probed and the first one found will be used as the default CA certificate location path. If OpenSSL is dynamically linked the OpenSSL library's default path will be used (see `OPENSSLDIR` in `openssl version -a`).
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCaLocation { get { return Get("ssl.ca.location"); } set { this.SetObject("ssl.ca.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     File or directory path to CA certificate(s) for verifying HTTPS endpoints, like `sasl.oauthbearer.token.endpoint.url` used for OAUTHBEARER/OIDC authentication. Mutually exclusive with `https.ca.pem`. Defaults: On Windows the system's CA certificates are automatically looked up in the Windows Root certificate store. On Mac OSX this configuration defaults to `probe`. It is recommended to install openssl using Homebrew, to provide CA certificates. On Linux install the distribution's ca-certificates package. If OpenSSL is statically linked or `https.ca.location` is set to `probe` a list of standard paths will be probed and the first one found will be used as the default CA certificate location path. If OpenSSL is dynamically linked the OpenSSL library's default path will be used (see `OPENSSLDIR` in `openssl version -a`).
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string HttpsCaLocation { get { return Get("https.ca.location"); } set { this.SetObject("https.ca.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     CA certificate string (PEM format) for verifying HTTPS endpoints. Mutually exclusive with `https.ca.location`. Optional: see `https.ca.location`.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string HttpsCaPem { get { return Get("https.ca.pem"); } set { this.SetObject("https.ca.pem", value); } }

        /// <summary>
        /// <![CDATA[
        ///     CA certificate string (PEM format) for verifying the broker's key.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCaPem { get { return Get("ssl.ca.pem"); } set { this.SetObject("ssl.ca.pem", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Comma-separated list of Windows Certificate stores to load CA certificates from. Certificates will be loaded in the same order as stores are specified. If no certificates can be loaded from any of the specified stores an error is logged and the OpenSSL library's default CA location is used instead. Store names are typically one or more of: MY, Root, Trust, CA.
        ///
        ///     default: Root
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCaCertificateStores { get { return Get("ssl.ca.certificate.stores"); } set { this.SetObject("ssl.ca.certificate.stores", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to CRL for verifying broker's certificate validity.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslCrlLocation { get { return Get("ssl.crl.location"); } set { this.SetObject("ssl.crl.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to client's keystore (PKCS#12) used for authentication.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslKeystoreLocation { get { return Get("ssl.keystore.location"); } set { this.SetObject("ssl.keystore.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client's keystore (PKCS#12) password.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslKeystorePassword { get { return Get("ssl.keystore.password"); } set { this.SetObject("ssl.keystore.password", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Comma-separated list of OpenSSL 3.0.x implementation providers. E.g., "default,legacy".
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslProviders { get { return Get("ssl.providers"); } set { this.SetObject("ssl.providers", value); } }

        /// <summary>
        /// <![CDATA[
        ///     **DEPRECATED** Path to OpenSSL engine library. OpenSSL >= 1.1.x required. DEPRECATED: OpenSSL engine support is deprecated and should be replaced by OpenSSL 3 providers.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslEngineLocation { get { return Get("ssl.engine.location"); } set { this.SetObject("ssl.engine.location", value); } }

        /// <summary>
        /// <![CDATA[
        ///     OpenSSL engine id is the name used for loading engine.
        ///
        ///     default: dynamic
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SslEngineId { get { return Get("ssl.engine.id"); } set { this.SetObject("ssl.engine.id", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Enable OpenSSL's builtin broker (server) certificate verification. This verification can be extended by the application by implementing a certificate_verify_cb.
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? EnableSslCertificateVerification { get { return GetBool("enable.ssl.certificate.verification"); } set { this.SetObject("enable.ssl.certificate.verification", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Endpoint identification algorithm to validate broker hostname using broker certificate. https - Server (broker) hostname verification as specified in RFC2818. none - No endpoint verification. OpenSSL >= 1.0.2 required.
        ///
        ///     default: https
        ///     importance: low
        /// ]]>
        /// </summary>
        public SslEndpointIdentificationAlgorithm? SslEndpointIdentificationAlgorithm { get { return (SslEndpointIdentificationAlgorithm?)GetEnum(typeof(SslEndpointIdentificationAlgorithm), "ssl.endpoint.identification.algorithm"); } set { this.SetObject("ssl.endpoint.identification.algorithm", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Kerberos principal name that Kafka runs as, not including /hostname@REALM
        ///
        ///     default: kafka
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslKerberosServiceName { get { return Get("sasl.kerberos.service.name"); } set { this.SetObject("sasl.kerberos.service.name", value); } }

        /// <summary>
        /// <![CDATA[
        ///     This client's Kerberos principal name. (Not supported on Windows, will use the logon user's principal).
        ///
        ///     default: kafkaclient
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslKerberosPrincipal { get { return Get("sasl.kerberos.principal"); } set { this.SetObject("sasl.kerberos.principal", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Shell command to refresh or acquire the client's Kerberos ticket. This command is executed on client creation and every sasl.kerberos.min.time.before.relogin (0=disable). %{config.prop.name} is replaced by corresponding config object value.
        ///
        ///     default: kinit -R -t "%{sasl.kerberos.keytab}" -k %{sasl.kerberos.principal} || kinit -t "%{sasl.kerberos.keytab}" -k %{sasl.kerberos.principal}
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslKerberosKinitCmd { get { return Get("sasl.kerberos.kinit.cmd"); } set { this.SetObject("sasl.kerberos.kinit.cmd", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to Kerberos keytab file. This configuration property is only used as a variable in `sasl.kerberos.kinit.cmd` as ` ... -t "%{sasl.kerberos.keytab}"`.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslKerberosKeytab { get { return Get("sasl.kerberos.keytab"); } set { this.SetObject("sasl.kerberos.keytab", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Minimum time in milliseconds between key refresh attempts. Disable automatic key refresh by setting this property to 0.
        ///
        ///     default: 60000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SaslKerberosMinTimeBeforeRelogin { get { return GetInt("sasl.kerberos.min.time.before.relogin"); } set { this.SetObject("sasl.kerberos.min.time.before.relogin", value); } }

        /// <summary>
        /// <![CDATA[
        ///     SASL username for use with the PLAIN and SASL-SCRAM-.. mechanisms
        ///
        ///     default: ''
        ///     importance: high
        /// ]]>
        /// </summary>
        public string SaslUsername { get { return Get("sasl.username"); } set { this.SetObject("sasl.username", value); } }

        /// <summary>
        /// <![CDATA[
        ///     SASL password for use with the PLAIN and SASL-SCRAM-.. mechanism
        ///
        ///     default: ''
        ///     importance: high
        /// ]]>
        /// </summary>
        public string SaslPassword { get { return Get("sasl.password"); } set { this.SetObject("sasl.password", value); } }

        /// <summary>
        /// <![CDATA[
        ///     SASL/OAUTHBEARER configuration. The format is implementation-dependent and must be parsed accordingly. The default unsecured token implementation (see https://tools.ietf.org/html/rfc7515#appendix-A.5) recognizes space-separated name=value pairs with valid names including principalClaimName, principal, scopeClaimName, scope, and lifeSeconds. The default value for principalClaimName is "sub", the default value for scopeClaimName is "scope", and the default value for lifeSeconds is 3600. The scope value is CSV format with the default value being no/empty scope. For example: `principalClaimName=azp principal=admin scopeClaimName=roles scope=role1,role2 lifeSeconds=600`. In addition, SASL extensions can be communicated to the broker via `extension_NAME=value`. For example: `principal=admin extension_traceId=123`
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerConfig { get { return Get("sasl.oauthbearer.config"); } set { this.SetObject("sasl.oauthbearer.config", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Enable the builtin unsecure JWT OAUTHBEARER token handler if no oauthbearer_refresh_cb has been set. This builtin handler should only be used for development or testing, and not in production.
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? EnableSaslOauthbearerUnsecureJwt { get { return GetBool("enable.sasl.oauthbearer.unsecure.jwt"); } set { this.SetObject("enable.sasl.oauthbearer.unsecure.jwt", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Set to "default" or "oidc" to control which login method to be used. If set to "oidc", the following properties must also be be specified: `sasl.oauthbearer.client.id`, `sasl.oauthbearer.client.secret`, and `sasl.oauthbearer.token.endpoint.url`.
        ///
        ///     default: default
        ///     importance: low
        /// ]]>
        /// </summary>
        public SaslOauthbearerMethod? SaslOauthbearerMethod { get { return (SaslOauthbearerMethod?)GetEnum(typeof(SaslOauthbearerMethod), "sasl.oauthbearer.method"); } set { this.SetObject("sasl.oauthbearer.method", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Public identifier for the application. Must be unique across all clients that the authorization server handles. Only used when `sasl.oauthbearer.method` is set to "oidc".
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerClientId { get { return Get("sasl.oauthbearer.client.id"); } set { this.SetObject("sasl.oauthbearer.client.id", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client secret only known to the application and the authorization server. This should be a sufficiently random string that is not guessable. Only used when `sasl.oauthbearer.method` is set to "oidc".
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerClientSecret { get { return Get("sasl.oauthbearer.client.secret"); } set { this.SetObject("sasl.oauthbearer.client.secret", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client use this to specify the scope of the access request to the broker. Only used when `sasl.oauthbearer.method` is set to "oidc".
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerScope { get { return Get("sasl.oauthbearer.scope"); } set { this.SetObject("sasl.oauthbearer.scope", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Allow additional information to be provided to the broker. Comma-separated list of key=value pairs. E.g., "supportFeatureX=true,organizationId=sales-emea".Only used when `sasl.oauthbearer.method` is set to "oidc".
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerExtensions { get { return Get("sasl.oauthbearer.extensions"); } set { this.SetObject("sasl.oauthbearer.extensions", value); } }

        /// <summary>
        /// <![CDATA[
        ///     OAuth/OIDC issuer token endpoint HTTP(S) URI used to retrieve token. Only used when `sasl.oauthbearer.method` is set to "oidc".
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerTokenEndpointUrl { get { return Get("sasl.oauthbearer.token.endpoint.url"); } set { this.SetObject("sasl.oauthbearer.token.endpoint.url", value); } }

        /// <summary>
        /// <![CDATA[
        ///     OAuth grant type to use when communicating with the identity provider.
        ///
        ///     default: client_credentials
        ///     importance: low
        /// ]]>
        /// </summary>
        public SaslOauthbearerGrantType? SaslOauthbearerGrantType { get { return (SaslOauthbearerGrantType?)GetEnum(typeof(SaslOauthbearerGrantType), "sasl.oauthbearer.grant.type"); } set { this.SetObject("sasl.oauthbearer.grant.type", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Algorithm the client should use to sign the assertion sent to the identity provider and in the OAuth alg header in the JWT assertion.
        ///
        ///     default: RS256
        ///     importance: low
        /// ]]>
        /// </summary>
        public SaslOauthbearerAssertionAlgorithm? SaslOauthbearerAssertionAlgorithm { get { return (SaslOauthbearerAssertionAlgorithm?)GetEnum(typeof(SaslOauthbearerAssertionAlgorithm), "sasl.oauthbearer.assertion.algorithm"); } set { this.SetObject("sasl.oauthbearer.assertion.algorithm", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to client's private key (PEM) used for authentication when using the JWT assertion.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionPrivateKeyFile { get { return Get("sasl.oauthbearer.assertion.private.key.file"); } set { this.SetObject("sasl.oauthbearer.assertion.private.key.file", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Private key passphrase for `sasl.oauthbearer.assertion.private.key.file` or `sasl.oauthbearer.assertion.private.key.pem`.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionPrivateKeyPassphrase { get { return Get("sasl.oauthbearer.assertion.private.key.passphrase"); } set { this.SetObject("sasl.oauthbearer.assertion.private.key.passphrase", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client's private key (PEM) used for authentication when using the JWT assertion.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionPrivateKeyPem { get { return Get("sasl.oauthbearer.assertion.private.key.pem"); } set { this.SetObject("sasl.oauthbearer.assertion.private.key.pem", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to the assertion file. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionFile { get { return Get("sasl.oauthbearer.assertion.file"); } set { this.SetObject("sasl.oauthbearer.assertion.file", value); } }

        /// <summary>
        /// <![CDATA[
        ///     JWT audience claim. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionClaimAud { get { return Get("sasl.oauthbearer.assertion.claim.aud"); } set { this.SetObject("sasl.oauthbearer.assertion.claim.aud", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Assertion expiration time in seconds. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: 300
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SaslOauthbearerAssertionClaimExpSeconds { get { return GetInt("sasl.oauthbearer.assertion.claim.exp.seconds"); } set { this.SetObject("sasl.oauthbearer.assertion.claim.exp.seconds", value); } }

        /// <summary>
        /// <![CDATA[
        ///     JWT issuer claim. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionClaimIss { get { return Get("sasl.oauthbearer.assertion.claim.iss"); } set { this.SetObject("sasl.oauthbearer.assertion.claim.iss", value); } }

        /// <summary>
        /// <![CDATA[
        ///     JWT ID claim. When set to `true`, a random UUID is generated. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? SaslOauthbearerAssertionClaimJtiInclude { get { return GetBool("sasl.oauthbearer.assertion.claim.jti.include"); } set { this.SetObject("sasl.oauthbearer.assertion.claim.jti.include", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Assertion not before time in seconds. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: 60
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? SaslOauthbearerAssertionClaimNbfSeconds { get { return GetInt("sasl.oauthbearer.assertion.claim.nbf.seconds"); } set { this.SetObject("sasl.oauthbearer.assertion.claim.nbf.seconds", value); } }

        /// <summary>
        /// <![CDATA[
        ///     JWT subject claim. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionClaimSub { get { return Get("sasl.oauthbearer.assertion.claim.sub"); } set { this.SetObject("sasl.oauthbearer.assertion.claim.sub", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Path to the JWT template file. Only used when `sasl.oauthbearer.method` is set to "oidc" and JWT assertion is needed.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string SaslOauthbearerAssertionJwtTemplateFile { get { return Get("sasl.oauthbearer.assertion.jwt.template.file"); } set { this.SetObject("sasl.oauthbearer.assertion.jwt.template.file", value); } }

        /// <summary>
        /// <![CDATA[
        ///     List of plugin libraries to load (; separated). The library search path is platform dependent (see dlopen(3) for Unix and LoadLibrary() for Windows). If no filename extension is specified the platform-specific extension (such as .dll or .so) will be appended automatically.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string PluginLibraryPaths { get { return Get("plugin.library.paths"); } set { this.SetObject("plugin.library.paths", value); } }

        /// <summary>
        /// <![CDATA[
        ///     A rack identifier for this client. This can be any string value which indicates where this client is physically located. It corresponds with the broker config `broker.rack`.
        ///
        ///     default: ''
        ///     importance: low
        /// ]]>
        /// </summary>
        public string ClientRack { get { return Get("client.rack"); } set { this.SetObject("client.rack", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The backoff time in milliseconds before retrying a protocol request, this is the first backoff time, and will be backed off exponentially until number of retries is exhausted, and it's capped by retry.backoff.max.ms.
        ///
        ///     default: 100
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? RetryBackoffMs { get { return GetInt("retry.backoff.ms"); } set { this.SetObject("retry.backoff.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The max backoff time in milliseconds before retrying a protocol request, this is the atmost backoff allowed for exponentially backed off requests.
        ///
        ///     default: 1000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? RetryBackoffMaxMs { get { return GetInt("retry.backoff.max.ms"); } set { this.SetObject("retry.backoff.max.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Controls how the client uses DNS lookups. By default, when the lookup returns multiple IP addresses for a hostname, they will all be attempted for connection before the connection is considered failed. This applies to both bootstrap and advertised servers. If the value is set to `resolve_canonical_bootstrap_servers_only`, each entry will be resolved and expanded into a list of canonical names. **WARNING**: `resolve_canonical_bootstrap_servers_only` must only be used with `GSSAPI` (Kerberos) as `sasl.mechanism`, as it's the only purpose of this configuration value. **NOTE**: Default here is different from the Java client's default behavior, which connects only to the first IP address returned for a hostname.
        ///
        ///     default: use_all_dns_ips
        ///     importance: low
        /// ]]>
        /// </summary>
        public ClientDnsLookup? ClientDnsLookup { get { return (ClientDnsLookup?)GetEnum(typeof(ClientDnsLookup), "client.dns.lookup"); } set { this.SetObject("client.dns.lookup", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Whether to enable pushing of client metrics to the cluster, if the cluster has a client metrics subscription which matches this client
        ///
        ///     default: true
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? EnableMetricsPush { get { return GetBool("enable.metrics.push"); } set { this.SetObject("enable.metrics.push", value); } }

    }


    /// <summary>
    ///     AdminClient configuration properties
    /// </summary>
    public class AdminClientConfig : ClientConfig
    {

        /// <summary>
        ///     Initialize a new empty <see cref="AdminClientConfig" /> instance.
        /// </summary>
        public AdminClientConfig() : base() { }

        /// <summary>
        ///     Initialize a new <see cref="AdminClientConfig" /> instance wrapping
        ///     an existing <see cref="ClientConfig" /> instance.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public AdminClientConfig(ClientConfig config) : base(config) { }

        /// <summary>
        ///     Initialize a new <see cref="AdminClientConfig" /> instance wrapping
        ///     an existing key/value pair collection.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public AdminClientConfig(IDictionary<string, string> config) : base(config) { }

        /// <summary>
        ///     Check if any properties have been set that have implications for
        ///     application logic and therefore shouldn't be set via external
        ///     configuration, independent of the code. Throw an ArgumentException
        ///     if so.
        ///
        ///     There are currently no such AdminClient configuration properties
        ///     and this method will never throw.
        /// </summary>
        public AdminClientConfig ThrowIfContainsNonUserConfigurable()
        {
            // noop
            return this;
        }

    }


    /// <summary>
    ///     Producer configuration properties
    /// </summary>
    public class ProducerConfig : ClientConfig
    {

        /// <summary>
        ///     Initialize a new empty <see cref="ProducerConfig" /> instance.
        /// </summary>
        public ProducerConfig() : base() { }

        /// <summary>
        ///     Initialize a new <see cref="ProducerConfig" /> instance wrapping
        ///     an existing <see cref="ClientConfig" /> instance.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public ProducerConfig(ClientConfig config) : base(config) { }

        /// <summary>
        ///     Initialize a new <see cref="ProducerConfig" /> instance wrapping
        ///     an existing key/value pair collection.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public ProducerConfig(IDictionary<string, string> config) : base(config) { }

        /// <summary>
        ///     Check if any properties have been set that have implications for
        ///     application logic and therefore shouldn't be set via external
        ///     configuration, independent of the code. Throw an ArgumentException
        ///     if so.
        ///
        ///     There are currently no such Producer configuration properties
        ///     and this method will never throw.
        /// </summary>
        public ProducerConfig ThrowIfContainsNonUserConfigurable()
        {
            // noop
            return this;
        }

        /// <summary>
        ///     Specifies whether or not the producer should start a background poll
        ///     thread to receive delivery reports and event notifications. Generally,
        ///     this should be set to true. If set to false, you will need to call
        ///     the Poll function manually.
        ///
        ///     default: true
        ///     importance: low
        /// </summary>
        public bool? EnableBackgroundPoll { get { return GetBool("dotnet.producer.enable.background.poll"); } set { this.SetObject("dotnet.producer.enable.background.poll", value); } }

        /// <summary>
        ///     Specifies whether to enable notification of delivery reports. Typically
        ///     you should set this parameter to true. Set it to false for "fire and
        ///     forget" semantics and a small boost in performance.
        ///
        ///     default: true
        ///     importance: low
        /// </summary>
        public bool? EnableDeliveryReports { get { return GetBool("dotnet.producer.enable.delivery.reports"); } set { this.SetObject("dotnet.producer.enable.delivery.reports", value); } }

        /// <summary>
        ///     A comma separated list of fields that may be optionally set in delivery
        ///     reports. Disabling delivery report fields that you do not require will
        ///     improve maximum throughput and reduce memory usage. Allowed values:
        ///     key, value, timestamp, headers, status, all, none.
        ///
        ///     default: all
        ///     importance: low
        /// </summary>
        public string DeliveryReportFields { get { return Get("dotnet.producer.delivery.report.fields"); } set { this.SetObject("dotnet.producer.delivery.report.fields", value.ToString()); } }

        /// <summary>
        /// <![CDATA[
        ///     The ack timeout of the producer request in milliseconds. This value is only enforced by the broker and relies on `request.required.acks` being != 0.
        ///
        ///     default: 30000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? RequestTimeoutMs { get { return GetInt("request.timeout.ms"); } set { this.SetObject("request.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Local message timeout. This value is only enforced locally and limits the time a produced message waits for successful delivery. A time of 0 is infinite. This is the maximum time librdkafka may use to deliver a message (including retries). Delivery error occurs when either the retry count or the message timeout are exceeded. The message timeout is automatically adjusted to `transaction.timeout.ms` if `transactional.id` is configured.
        ///
        ///     default: 300000
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? MessageTimeoutMs { get { return GetInt("message.timeout.ms"); } set { this.SetObject("message.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Partitioner: `random` - random distribution, `consistent` - CRC32 hash of key (Empty and NULL keys are mapped to single partition), `consistent_random` - CRC32 hash of key (Empty and NULL keys are randomly partitioned), `murmur2` - Java Producer compatible Murmur2 hash of key (NULL keys are mapped to single partition), `murmur2_random` - Java Producer compatible Murmur2 hash of key (NULL keys are randomly partitioned. This is functionally equivalent to the default partitioner in the Java Producer.), `fnv1a` - FNV-1a hash of key (NULL keys are mapped to single partition), `fnv1a_random` - FNV-1a hash of key (NULL keys are randomly partitioned).
        ///
        ///     default: consistent_random
        ///     importance: high
        /// ]]>
        /// </summary>
        public Partitioner? Partitioner { get { return (Partitioner?)GetEnum(typeof(Partitioner), "partitioner"); } set { this.SetObject("partitioner", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Compression level parameter for algorithm selected by configuration property `compression.codec`. Higher values will result in better compression at the cost of more CPU usage. Usable range is algorithm-dependent: [0-9] for gzip; [0-12] for lz4; only 0 for snappy; -1 = codec-dependent default compression level.
        ///
        ///     default: -1
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? CompressionLevel { get { return GetInt("compression.level"); } set { this.SetObject("compression.level", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Enables the transactional producer. The transactional.id is used to identify the same transactional producer instance across process restarts. It allows the producer to guarantee that transactions corresponding to earlier instances of the same producer have been finalized prior to starting any new transactions, and that any zombie instances are fenced off. If no transactional.id is provided, then the producer is limited to idempotent delivery (if enable.idempotence is set). Requires broker version >= 0.11.0.
        ///
        ///     default: ''
        ///     importance: high
        /// ]]>
        /// </summary>
        public string TransactionalId { get { return Get("transactional.id"); } set { this.SetObject("transactional.id", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The maximum amount of time in milliseconds that the transaction coordinator will wait for a transaction status update from the producer before proactively aborting the ongoing transaction. If this value is larger than the `transaction.max.timeout.ms` setting in the broker, the init_transactions() call will fail with ERR_INVALID_TRANSACTION_TIMEOUT. The transaction timeout automatically adjusts `message.timeout.ms` and `socket.timeout.ms`, unless explicitly configured in which case they must not exceed the transaction timeout (`socket.timeout.ms` must be at least 100ms lower than `transaction.timeout.ms`). This is also the default timeout value if no timeout (-1) is supplied to the transactional API methods.
        ///
        ///     default: 60000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? TransactionTimeoutMs { get { return GetInt("transaction.timeout.ms"); } set { this.SetObject("transaction.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     When set to `true`, the producer will ensure that messages are successfully produced exactly once and in the original produce order. The following configuration properties are adjusted automatically (if not modified by the user) when idempotence is enabled: `max.in.flight.requests.per.connection=5` (must be less than or equal to 5), `retries=INT32_MAX` (must be greater than 0), `acks=all`, `queuing.strategy=fifo`. Producer instantation will fail if user-supplied configuration is incompatible.
        ///
        ///     default: false
        ///     importance: high
        /// ]]>
        /// </summary>
        public bool? EnableIdempotence { get { return GetBool("enable.idempotence"); } set { this.SetObject("enable.idempotence", value); } }

        /// <summary>
        /// <![CDATA[
        ///     **EXPERIMENTAL**: subject to change or removal. When set to `true`, any error that could result in a gap in the produced message series when a batch of messages fails, will raise a fatal error (ERR__GAPLESS_GUARANTEE) and stop the producer. Messages failing due to `message.timeout.ms` are not covered by this guarantee. Requires `enable.idempotence=true`.
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? EnableGaplessGuarantee { get { return GetBool("enable.gapless.guarantee"); } set { this.SetObject("enable.gapless.guarantee", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum number of messages allowed on the producer queue. This queue is shared by all topics and partitions. A value of 0 disables this limit.
        ///
        ///     default: 100000
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? QueueBufferingMaxMessages { get { return GetInt("queue.buffering.max.messages"); } set { this.SetObject("queue.buffering.max.messages", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum total message size sum allowed on the producer queue. This queue is shared by all topics and partitions. This property has higher priority than queue.buffering.max.messages.
        ///
        ///     default: 1048576
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? QueueBufferingMaxKbytes { get { return GetInt("queue.buffering.max.kbytes"); } set { this.SetObject("queue.buffering.max.kbytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Delay in milliseconds to wait for messages in the producer queue to accumulate before constructing message batches (MessageSets) to transmit to brokers. A higher value allows larger and more effective (less overhead, improved compression) batches of messages to accumulate at the expense of increased message delivery latency.
        ///
        ///     default: 5
        ///     importance: high
        /// ]]>
        /// </summary>
        public double? LingerMs { get { return GetDouble("linger.ms"); } set { this.SetObject("linger.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     How many times to retry sending a failing Message. **Note:** retrying may cause reordering unless `enable.idempotence` is set to true.
        ///
        ///     default: 2147483647
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? MessageSendMaxRetries { get { return GetInt("message.send.max.retries"); } set { this.SetObject("message.send.max.retries", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The threshold of outstanding not yet transmitted broker requests needed to backpressure the producer's message accumulator. If the number of not yet transmitted requests equals or exceeds this number, produce request creation that would have otherwise been triggered (for example, in accordance with linger.ms) will be delayed. A lower number yields larger and more effective batches. A higher value can improve latency when using compression on slow machines.
        ///
        ///     default: 1
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? QueueBufferingBackpressureThreshold { get { return GetInt("queue.buffering.backpressure.threshold"); } set { this.SetObject("queue.buffering.backpressure.threshold", value); } }

        /// <summary>
        /// <![CDATA[
        ///     compression codec to use for compressing message sets. This is the default value for all topics, may be overridden by the topic configuration property `compression.codec`.
        ///
        ///     default: none
        ///     importance: medium
        /// ]]>
        /// </summary>
        public CompressionType? CompressionType { get { return (CompressionType?)GetEnum(typeof(CompressionType), "compression.type"); } set { this.SetObject("compression.type", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum number of messages batched in one MessageSet. The total MessageSet size is also limited by batch.size and message.max.bytes.
        ///
        ///     default: 10000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? BatchNumMessages { get { return GetInt("batch.num.messages"); } set { this.SetObject("batch.num.messages", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum size (in bytes) of all messages batched in one MessageSet, including protocol framing overhead. This limit is applied after the first message has been added to the batch, regardless of the first message's size, this is to ensure that messages that exceed batch.size are produced. The total MessageSet size is also limited by batch.num.messages and message.max.bytes.
        ///
        ///     default: 1000000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? BatchSize { get { return GetInt("batch.size"); } set { this.SetObject("batch.size", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Delay in milliseconds to wait to assign new sticky partitions for each topic. By default, set to double the time of linger.ms. To disable sticky behavior, set to 0. This behavior affects messages with the key NULL in all cases, and messages with key lengths of zero when the consistent_random partitioner is in use. These messages would otherwise be assigned randomly. A higher value allows for more effective batching of these messages.
        ///
        ///     default: 10
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? StickyPartitioningLingerMs { get { return GetInt("sticky.partitioning.linger.ms"); } set { this.SetObject("sticky.partitioning.linger.ms", value); } }

    }


    /// <summary>
    ///     Consumer configuration properties
    /// </summary>
    public class ConsumerConfig : ClientConfig
    {

        /// <summary>
        ///     Initialize a new empty <see cref="ConsumerConfig" /> instance.
        /// </summary>
        public ConsumerConfig() : base() { }

        /// <summary>
        ///     Initialize a new <see cref="ConsumerConfig" /> instance wrapping
        ///     an existing <see cref="ClientConfig" /> instance.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public ConsumerConfig(ClientConfig config) : base(config) { }

        /// <summary>
        ///     Initialize a new <see cref="ConsumerConfig" /> instance wrapping
        ///     an existing key/value pair collection.
        ///     This will change the values "in-place" i.e. operations on this class WILL modify the provided collection
        /// </summary>
        public ConsumerConfig(IDictionary<string, string> config) : base(config) { }

        /// <summary>
        ///     Check if any properties have been set that have implications for
        ///     application logic and therefore shouldn't be set via external
        ///     configuration, independent of the code. Throw an ArgumentException
        ///     if so.
        /// </summary>
        public ConsumerConfig ThrowIfContainsNonUserConfigurable()
        {
            var toCheck = new string[] { "enable.partition.eof", "partition.assignment.strategy", "enable.auto.commit", "enable.auto.offset.store" };
            this.Where(kv => toCheck.Contains(kv.Key)).ToList()
                .ForEach(kv => { throw new ArgumentException($"Consumer config property '{kv.Key}' is not user configurable."); });
            return this;
        }

        /// <summary>
        ///     A comma separated list of fields that may be optionally set
        ///     in <see cref="Confluent.Kafka.ConsumeResult{TKey,TValue}" />
        ///     objects returned by the
        ///     <see cref="Confluent.Kafka.Consumer{TKey,TValue}.Consume(System.TimeSpan)" />
        ///     method. Disabling fields that you do not require will improve
        ///     throughput and reduce memory consumption. Allowed values:
        ///     headers, timestamp, topic, all, none
        ///
        ///     default: all
        ///     importance: low
        /// </summary>
        public string ConsumeResultFields { set { this.SetObject("dotnet.consumer.consume.result.fields", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Action to take when there is no initial offset in offset store or the desired offset is out of range: 'smallest','earliest' - automatically reset the offset to the smallest offset, 'largest','latest' - automatically reset the offset to the largest offset, 'error' - trigger an error (ERR__AUTO_OFFSET_RESET) which is retrieved by consuming messages and checking 'message->err'.
        ///
        ///     default: largest
        ///     importance: high
        /// ]]>
        /// </summary>
        public AutoOffsetReset? AutoOffsetReset { get { return (AutoOffsetReset?)GetEnum(typeof(AutoOffsetReset), "auto.offset.reset"); } set { this.SetObject("auto.offset.reset", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client group id string. All clients sharing the same group.id belong to the same group.
        ///
        ///     default: ''
        ///     importance: high
        /// ]]>
        /// </summary>
        public string GroupId { get { return Get("group.id"); } set { this.SetObject("group.id", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Enable static group membership. Static group members are able to leave and rejoin a group within the configured `session.timeout.ms` without prompting a group rebalance. This should be used in combination with a larger `session.timeout.ms` to avoid group rebalances caused by transient unavailability (e.g. process restarts). Requires broker version >= 2.3.0.
        ///
        ///     default: ''
        ///     importance: medium
        /// ]]>
        /// </summary>
        public string GroupInstanceId { get { return Get("group.instance.id"); } set { this.SetObject("group.instance.id", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The name of one or more partition assignment strategies. The elected group leader will use a strategy supported by all members of the group to assign partitions to group members. If there is more than one eligible strategy, preference is determined by the order of this list (strategies earlier in the list have higher priority). Cooperative and non-cooperative (eager)strategies must not be mixed. `partition.assignment.strategy` is not supported for `group.protocol=consumer`. Use `group.remote.assignor` instead. Available strategies: range, roundrobin, cooperative-sticky.
        ///
        ///     default: range,roundrobin
        ///     importance: medium
        /// ]]>
        /// </summary>
        public PartitionAssignmentStrategy? PartitionAssignmentStrategy { get { return (PartitionAssignmentStrategy?)GetEnum(typeof(PartitionAssignmentStrategy), "partition.assignment.strategy"); } set { this.SetObject("partition.assignment.strategy", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Client group session and failure detection timeout. The consumer sends periodic heartbeats (heartbeat.interval.ms) to indicate its liveness to the broker. If no hearts are received by the broker for a group member within the session timeout, the broker will remove the consumer from the group and trigger a rebalance. The allowed range is configured with the **broker** configuration properties `group.min.session.timeout.ms` and `group.max.session.timeout.ms`. `session.timeout.ms` is not supported for `group.protocol=consumer`. It is set with the broker configuration property `group.consumer.session.timeout.ms` by default or can be configured through the AdminClient IncrementalAlterConfigs API. The allowed range is configured with the broker configuration properties `group.consumer.min.session.timeout.ms` and `group.consumer.max.session.timeout.ms`. Also see `max.poll.interval.ms`.
        ///
        ///     default: 45000
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? SessionTimeoutMs { get { return GetInt("session.timeout.ms"); } set { this.SetObject("session.timeout.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Group session keepalive heartbeat interval. `heartbeat.interval.ms` is not supported for `group.protocol=consumer`. It is set with the broker configuration property `group.consumer.heartbeat.interval.ms` by default or can be configured through the AdminClient IncrementalAlterConfigs API. The allowed range is configured with the broker configuration properties `group.consumer.min.heartbeat.interval.ms` and `group.consumer.max.heartbeat.interval.ms`.
        ///
        ///     default: 3000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? HeartbeatIntervalMs { get { return GetInt("heartbeat.interval.ms"); } set { this.SetObject("heartbeat.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Group protocol type for the `classic` group protocol. NOTE: Currently, the only supported group protocol type is `consumer`. `group.protocol.type` is not supported for `group.protocol=consumer`
        ///
        ///     default: consumer
        ///     importance: low
        /// ]]>
        /// </summary>
        public string GroupProtocolType { get { return Get("group.protocol.type"); } set { this.SetObject("group.protocol.type", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Group protocol to use. Use `classic` for the original protocol and `consumer` for the new protocol introduced in KIP-848. Available protocols: classic or consumer. Default is `classic`, but will change to `consumer` in next releases.
        ///
        ///     default: classic
        ///     importance: high
        /// ]]>
        /// </summary>
        public GroupProtocol? GroupProtocol { get { return (GroupProtocol?)GetEnum(typeof(GroupProtocol), "group.protocol"); } set { this.SetObject("group.protocol", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Server side assignor to use. Keep it null to make server select a suitable assignor for the group. Available assignors: uniform or range. Default is null
        ///
        ///     default: ''
        ///     importance: medium
        /// ]]>
        /// </summary>
        public string GroupRemoteAssignor { get { return Get("group.remote.assignor"); } set { this.SetObject("group.remote.assignor", value); } }

        /// <summary>
        /// <![CDATA[
        ///     How often to query for the current client group coordinator. If the currently assigned coordinator is down the configured query interval will be divided by ten to more quickly recover in case of coordinator reassignment.
        ///
        ///     default: 600000
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? CoordinatorQueryIntervalMs { get { return GetInt("coordinator.query.interval.ms"); } set { this.SetObject("coordinator.query.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum allowed time between calls to consume messages (e.g., rd_kafka_consumer_poll()) for high-level consumers. If this interval is exceeded the consumer is considered failed and the group will rebalance in order to reassign the partitions to another consumer group member. Warning: Offset commits may be not possible at this point. Note: It is recommended to set `enable.auto.offset.store=false` for long-time processing applications and then explicitly store offsets (using offsets_store()) *after* message processing, to make sure offsets are not auto-committed prior to processing has finished. The interval is checked two times per second. See KIP-62 for more information.
        ///
        ///     default: 300000
        ///     importance: high
        /// ]]>
        /// </summary>
        public int? MaxPollIntervalMs { get { return GetInt("max.poll.interval.ms"); } set { this.SetObject("max.poll.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Automatically and periodically commit offsets in the background. Note: setting this to false does not prevent the consumer from fetching previously committed start offsets. To circumvent this behaviour set specific start offsets per partition in the call to assign().
        ///
        ///     default: true
        ///     importance: high
        /// ]]>
        /// </summary>
        public bool? EnableAutoCommit { get { return GetBool("enable.auto.commit"); } set { this.SetObject("enable.auto.commit", value); } }

        /// <summary>
        /// <![CDATA[
        ///     The frequency in milliseconds that the consumer offsets are committed (written) to offset storage. (0 = disable). This setting is used by the high-level consumer.
        ///
        ///     default: 5000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? AutoCommitIntervalMs { get { return GetInt("auto.commit.interval.ms"); } set { this.SetObject("auto.commit.interval.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Automatically store offset of last message provided to application. The offset store is an in-memory store of the next offset to (auto-)commit for each partition.
        ///
        ///     default: true
        ///     importance: high
        /// ]]>
        /// </summary>
        public bool? EnableAutoOffsetStore { get { return GetBool("enable.auto.offset.store"); } set { this.SetObject("enable.auto.offset.store", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Minimum number of messages per topic+partition librdkafka tries to maintain in the local consumer queue.
        ///
        ///     default: 100000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? QueuedMinMessages { get { return GetInt("queued.min.messages"); } set { this.SetObject("queued.min.messages", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum number of kilobytes of queued pre-fetched messages in the local consumer queue. If using the high-level consumer this setting applies to the single consumer queue, regardless of the number of partitions. When using the legacy simple consumer or when separate partition queues are used this setting applies per partition. This value may be overshot by fetch.message.max.bytes. This property has higher priority than queued.min.messages.
        ///
        ///     default: 65536
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? QueuedMaxMessagesKbytes { get { return GetInt("queued.max.messages.kbytes"); } set { this.SetObject("queued.max.messages.kbytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum time the broker may wait to fill the Fetch response with fetch.min.bytes of messages.
        ///
        ///     default: 500
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? FetchWaitMaxMs { get { return GetInt("fetch.wait.max.ms"); } set { this.SetObject("fetch.wait.max.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     How long to postpone the next fetch request for a topic+partition in case the current fetch queue thresholds (queued.min.messages or queued.max.messages.kbytes) have been exceded. This property may need to be decreased if the queue thresholds are set low and the application is experiencing long (~1s) delays between messages. Low values may increase CPU utilization.
        ///
        ///     default: 1000
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? FetchQueueBackoffMs { get { return GetInt("fetch.queue.backoff.ms"); } set { this.SetObject("fetch.queue.backoff.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Initial maximum number of bytes per topic+partition to request when fetching messages from the broker. If the client encounters a message larger than this value it will gradually try to increase it until the entire message can be fetched.
        ///
        ///     default: 1048576
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? MaxPartitionFetchBytes { get { return GetInt("max.partition.fetch.bytes"); } set { this.SetObject("max.partition.fetch.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Maximum amount of data the broker shall return for a Fetch request. Messages are fetched in batches by the consumer and if the first message batch in the first non-empty partition of the Fetch request is larger than this value, then the message batch will still be returned to ensure the consumer can make progress. The maximum message batch size accepted by the broker is defined via `message.max.bytes` (broker config) or `max.message.bytes` (broker topic config). `fetch.max.bytes` is automatically adjusted upwards to be at least `message.max.bytes` (consumer config).
        ///
        ///     default: 52428800
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? FetchMaxBytes { get { return GetInt("fetch.max.bytes"); } set { this.SetObject("fetch.max.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Minimum number of bytes the broker responds with. If fetch.wait.max.ms expires the accumulated data will be sent to the client regardless of this setting.
        ///
        ///     default: 1
        ///     importance: low
        /// ]]>
        /// </summary>
        public int? FetchMinBytes { get { return GetInt("fetch.min.bytes"); } set { this.SetObject("fetch.min.bytes", value); } }

        /// <summary>
        /// <![CDATA[
        ///     How long to postpone the next fetch request for a topic+partition in case of a fetch error.
        ///
        ///     default: 500
        ///     importance: medium
        /// ]]>
        /// </summary>
        public int? FetchErrorBackoffMs { get { return GetInt("fetch.error.backoff.ms"); } set { this.SetObject("fetch.error.backoff.ms", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Controls how to read messages written transactionally: `read_committed` - only return transactional messages which have been committed. `read_uncommitted` - return all messages, even transactional messages which have been aborted.
        ///
        ///     default: read_committed
        ///     importance: high
        /// ]]>
        /// </summary>
        public IsolationLevel? IsolationLevel { get { return (IsolationLevel?)GetEnum(typeof(IsolationLevel), "isolation.level"); } set { this.SetObject("isolation.level", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Emit RD_KAFKA_RESP_ERR__PARTITION_EOF event whenever the consumer reaches the end of a partition.
        ///
        ///     default: false
        ///     importance: low
        /// ]]>
        /// </summary>
        public bool? EnablePartitionEof { get { return GetBool("enable.partition.eof"); } set { this.SetObject("enable.partition.eof", value); } }

        /// <summary>
        /// <![CDATA[
        ///     Verify CRC32 of consumed messages, ensuring no on-the-wire or on-disk corruption to the messages occurred. This check comes at slightly increased CPU usage.
        ///
        ///     default: false
        ///     importance: medium
        /// ]]>
        /// </summary>
        public bool? CheckCrcs { get { return GetBool("check.crcs"); } set { this.SetObject("check.crcs", value); } }

    }

}
